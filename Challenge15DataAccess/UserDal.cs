using Challenge15Entities;

namespace Challenge15DataAccess
{
    /// <summary>
    /// Yorum satırına alınan yerler CRUD islemleri generic yapıya donusturulmeden once kullanilmistir.
    /// </summary>
    public class UserDal : BaseRepository<User>//IBase<User>
    {
        //string sqlString = "Data Source=.;Initial Catalog=ToDoList;Integrated Security=SSPI";

        //public async Task<bool> Add(User entity)
        //{
        //    using (SqlConnection conn = new SqlConnection(sqlString))
        //    {
        //        string query = "Insert into Users (UserName, Password) values(@userName, @Password)";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@userName", entity.UserName);
        //            cmd.Parameters.AddWithValue("@password", entity.Password);

        //            conn.OpenAsync();

        //            int result = await cmd.ExecuteNonQueryAsync();
        //            if (result > 0)
        //            {
        //                return true;
        //            }

        //            return false;

        //        }
        //    }
        //}

        //public async Task<bool> Delete(int id)
        //{
        //    using (SqlConnection conn = new SqlConnection(sqlString))
        //    {
        //        string query = "DELETE FROM Users WHERE Id = @id";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", id);


        //            conn.OpenAsync();

        //            int result = await cmd.ExecuteNonQueryAsync();
        //            if (result > 0)
        //            {
        //                return true;
        //            }

        //            return false;

        //        }
        //    }
        //}

        //public async Task<List<User>> GetAll()
        //{
        //    List<User> users = new List<User>();
        //    using (SqlConnection conn = new SqlConnection(sqlString))
        //    {
        //        string query = "SELECT * FROM Users";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            conn.OpenAsync();

        //            SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync();
        //            while (sqlDataReader.Read())
        //            {
        //                User user = new User();
        //                user.Id = sqlDataReader.GetInt32(0);
        //                user.UserName = sqlDataReader.GetString(1);
        //                user.Password = sqlDataReader.GetString(2);

        //                users.Add(user);
        //            }

        //        }
        //    }

        //    return users;
        //}

        //public async Task<User> GetById(int id)
        //{
        //    User user = new User();
        //    using (SqlConnection conn = new SqlConnection(sqlString))
        //    {
        //        string query = "SELECT * FROM Users Where Id= @id";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("id", id);
        //            conn.OpenAsync();

        //            SqlDataReader sqlDataReader = await cmd.ExecuteReaderAsync();
        //            if (sqlDataReader.Read())
        //            {

        //                user.Id = sqlDataReader.GetInt32(0);
        //                user.UserName = sqlDataReader.GetString(1);
        //                user.Password = sqlDataReader.GetString(2);

        //            }

        //        }
        //    }

        //    return user;
        //}

        //public async Task<bool> Update(User entity)
        //{
        //    using (SqlConnection conn = new SqlConnection(sqlString))
        //    {
        //        string query = "UPDATE Users SET UserName = @userName, Password=@password WHERE Id = @id";

        //        using (SqlCommand cmd = new SqlCommand(query, conn))
        //        {
        //            cmd.Parameters.AddWithValue("@id", entity.Id);
        //            cmd.Parameters.AddWithValue("@userName", entity.UserName);
        //            cmd.Parameters.AddWithValue("@password", entity.Password);

        //            conn.OpenAsync();

        //            int result = await cmd.ExecuteNonQueryAsync();
        //            if (result > 0)
        //            {
        //                return true;
        //            }

        //            return false;

        //        }
        //    }
        //}
    }
}
