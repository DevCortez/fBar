using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;
using System.IO;

/// <summary>
/// Summary description for Connector
/// </summary>
/// 

namespace Connector
{
    public static class Connector
    {
        private static SQLiteConnection connection;

        private static void Connect()
        {
            connection = new SQLiteConnection("Data Source=fBar.sqlite;");
            connection.Open();
        }

        private static void InitializeDatabase()
        {
            new SQLiteCommand("CREATE TABLE login (user varchar(50), pwd varchar(32))", connection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE threads (title varchar(256), description varchar(1024), starter int, timeCreated int, lastActive int)", connection).ExecuteNonQuery();
            new SQLiteCommand("CREATE TABLE messages (thread int, sender int, text varchar(1024), timeSent int, upvotes int)", connection).ExecuteNonQuery();
        }

        public static SQLiteConnection GetConnection()
        {
            if(!File.Exists("fBar.sqlite"))
            {
                SQLiteConnection.CreateFile("fBar.sqlite");
                Connect();
                InitializeDatabase();
            }

            if (connection == null)
                Connect();

            return connection;
        }
    }
}