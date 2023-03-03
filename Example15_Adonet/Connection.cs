namespace Example15_Adonet
{
    public class Connection
    {
        public static string ConnectionString
        {
            get
            {
                return "Data Source=.; Initial Catalog=Northwind; " +
                    "Integrated Security=SSPI";
            }
        }
    }
}
