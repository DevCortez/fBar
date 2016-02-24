using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Connector;
using System.Data.SQLite;

/// <summary>
/// Summary description for Thread
/// </summary>
/// 

namespace DAO
{
    public class Thread
    {
        private int internalId;

        public string Title
        {
            get
            {
                SQLiteDataReader title = new SQLiteCommand("SELECT title FROM thread WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                title.Read();
                return title.GetValue(0).ToString();
            }
        }

        public int MessageCount
        {
            get
            {
                return Message.FromThread(internalId).Count();
            }
        }

        public string Author
        {
            get
            {
                SQLiteDataReader author = new SQLiteCommand("SELECT starter FROM thread WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                author.Read();                
                return new Login(author.GetInt32(0)).Name;
            }
        }

        public DateTime LastActive
        {
            get
            {
                SQLiteDataReader lastActive = new SQLiteCommand("SELECT lastActive FROM thread WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                lastActive.Read();
                return DateTime.FromBinary(lastActive.GetInt64(0));
            }

            set
            {
                new SQLiteCommand(string.Format("UPDATE thread SET lastActive = {0} WHERE ROWID = {1}", value.ToString(), internalId.ToString()), Connector.Connector.GetConnection()).ExecuteNonQuery();
            }
        }

        public DateTime Created
        {
            get
            {
                SQLiteDataReader created = new SQLiteCommand("SELECT timeCreated FROM thread WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                created.Read();
                return DateTime.FromBinary(created.GetInt64(0));
            }
        }

        public int Id
        {
            get
            {
                return internalId;
            }
        }

        public string Description
        {
            get
            {
                SQLiteDataReader title = new SQLiteCommand("SELECT description FROM thread WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                title.Read();
                return title.GetValue(0).ToString();
            }
        }

        public static IEnumerable<Thread> GetAll()
        {
            SQLiteDataReader threads = new SQLiteCommand("SELECT ROWID FROM threads ORDER BY timeCreated desc", Connector.Connector.GetConnection()).ExecuteReader();

            while(threads.Read())
            {
                yield return new Thread(threads.GetInt32(0));
            }
        }

        public Thread(int Id)
        {
            internalId = Id;    
        }
    }
}