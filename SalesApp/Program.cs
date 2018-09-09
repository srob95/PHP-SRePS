using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace SalesApp
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new AddSale());

            testSQL();
        }

        static void testSQL()
        {
            // Some random sql stuff to test functionality


            // Create (or overwite) a database
            // the file is stored in "PHP-SRePS\SalesApp\bin\Debug"
            SQLiteConnection.CreateFile("MyDatabase.sqlite");


            SQLiteConnection dbConn = new SQLiteConnection("Data Source=MyDatabase.sqlite;Version=3");
            dbConn.Open();

            string sql = "create table highscores (name varchar(20), score int)";
            SQLiteCommand command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();

            sql = "insert into highscores (name, score) values ('Me', 3000)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('Myself', 6000)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();
            sql = "insert into highscores (name, score) values ('And I', 9001)";
            command = new SQLiteCommand(sql, dbConn);
            command.ExecuteNonQuery();

            sql = "select * from highscores order by score desc";
            command = new SQLiteCommand(sql, dbConn);
            SQLiteDataReader reader = command.ExecuteReader();
            while (reader.Read())
                Console.WriteLine("Name: " + reader["name"] + "\tScore: " + reader["score"]);
        }
    }
}
