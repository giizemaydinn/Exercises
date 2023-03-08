using Challenge15DataAccess.Responses;
using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Challenge15DataAccess
{
    public class BaseRepository<T> where T : class
    {
        private readonly IConfiguration _configuration;
        private string sqlString = "";
        public BaseRepository()
        {
            _configuration = new ConfigurationBuilder()
                            .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                            .Build();

            sqlString = _configuration.GetConnectionString("DefaultConnection");
        }
        //"Data Source=.;Initial Catalog=ToDoList;Integrated Security=SSPI";
        //ConfigurationManager.ConnectionStrings["ToDoListConnStr"].ConnectionString
        public async Task<DataResponse<List<T>>> GetAll(string table)
        {
            List<T> entities = new List<T>();

            var query = $"SELECT * FROM {table}";

            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    await conn.OpenAsync();

                    SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync();
                    while (sqlDataReader.Read())
                    {
                        var entity = Map(sqlDataReader);

                        entities.Add(entity);
                    }

                }
            }

            return new DataResponse<List<T>>(entities, true, "Listeleme tamamlandı.", 200);//entities;
        }

        public async Task<DataResponse<T>> GetById(int id, string table, string columnName)
        {
            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                string query = $"SELECT * FROM {table} Where {columnName}= @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    await conn.OpenAsync(); ;

                    SqlDataReader sqlDataReader = cmd.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        var entity = Map(sqlDataReader);
                        return new DataResponse<T>(entity, true, "Entity getirildi.", 200);//entity;
                    }

                    return new DataResponse<T>(null, false, "Yanlış id bilgisi.", 400);

                }
            }

        }

        public async Task<Response> Add(T entity, string table)
        {
            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                string query = $"INSERT INTO {table} ({GetColumns(entity)}) VALUES ({GetValues(entity)})";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    AddParameters(entity, cmd);

                    await conn.OpenAsync();

                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        return new Response(true, "Ekleme başarılı.", 200);
                    }

                    return new Response(false, "Ekleme başarısız.", 400);

                }
            }

        }

        public async Task<Response> Delete(int id, string table, string columnName)
        {
            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                string query = $"DELETE FROM {table} Where {columnName}= @id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("id", id);
                    await conn.OpenAsync(); ;

                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        return new Response(true, "Silme başarılı.", 200);
                    }

                    return new Response(false, "Silme başarısız.", 400);

                }
            }

        }

        public async Task<Response> Update(T entity, string table)
        {
            using (SqlConnection conn = new SqlConnection(sqlString))
            {
                string query = $"UPDATE {table} SET {JoinParameters(entity)} WHERE Id=@Id";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    AddParameters(entity, cmd);

                    await conn.OpenAsync(); ;

                    int result = await cmd.ExecuteNonQueryAsync();
                    if (result > 0)
                    {
                        return new Response(true, "Güncelleme başarılı.", 200);
                    }

                    return new Response(false, "Güncelleme başarısız.", 400);


                }
            }

        }

        private string JoinParameters(T entity)
        {
            string result = "";
            foreach (var prop in typeof(T).GetProperties())
            {
                if (prop.Name == "Id")
                    continue;

                result += prop.Name + " = @" + prop.Name + ", ";
            }
            result = result.Remove(result.Length - 2); //result'a eklenen virgulu siler. (-1'de bosluk var).
            return result;
        }
        private void AddParameters(T entity, SqlCommand cmd)
        {
            foreach (var item in typeof(T).GetProperties())
            {
                var value = item.GetValue(entity);
                cmd.Parameters.AddWithValue($"@{item.Name}", value ?? DBNull.Value);
            }
        }

        private string GetValues(T entity)
        {
            var result = "@" + string.Join(", @", GetProperties(entity));

            return result;
        }

        private string GetColumns(T entity)
        {
            var result = string.Join(", ", GetProperties(entity));

            return result;
        }

        private List<string> GetProperties(T entity)
        {
            var result = typeof(T).GetProperties().Where(p => p.Name != "Id").Select(p => p.Name).ToList();
            return result;
        }

        private T Map(SqlDataReader sqlDataReader)
        {
            var entity = Activator.CreateInstance<T>();

            foreach (var item in typeof(T).GetProperties())
            {
                var value = sqlDataReader[item.Name];

                if (value != DBNull.Value)
                {
                    item.SetValue(entity, value);
                }
            }

            return entity;
        }
    }
}
