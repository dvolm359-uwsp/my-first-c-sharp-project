using System.Configuration;

namespace LocalDB_assign
{
    public static class Connection
    {
        public static string ConnectionString
            => @"Data Source=(LocalDB)\MSSQLLocalDB;
                AttachDbFilename='|DataDirectory|\sampleDatabase.mdf';Integrated Security=True";
    }
}
