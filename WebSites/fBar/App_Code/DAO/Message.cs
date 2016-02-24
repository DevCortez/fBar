using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SQLite;

/// <summary>
/// Summary description for Message
/// </summary>
/// 

namespace DAO
{
    public class Message
    {
        private int internalId;

        public string Author
        {
            get
            {
                SQLiteDataReader title = new SQLiteCommand("SELECT sender FROM messages WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                title.Read();
                return new Login(title.GetInt32(0)).Name;
            }
        }

        public string Text
        {
            get
            {
                SQLiteDataReader title = new SQLiteCommand("SELECT text FROM messages WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                title.Read();
                return title.GetValue(0).ToString();
            }
        }

        public DateTime TimeSent
        {
            get
            {
                SQLiteDataReader title = new SQLiteCommand("SELECT timeSent FROM messages WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                title.Read();
                return DateTime.FromBinary(title.GetInt64(0));
            }
        }

        public static IEnumerable<Message> FromThread(int Id)
        {
            SQLiteDataReader title = new SQLiteCommand("SELECT ROWID FROM messages WHERE thread = " + Id.ToString(), Connector.Connector.GetConnection()).ExecuteReader();

            while (title.Read())
            {
                yield return new Message(title.GetInt32(0));
            }
        }

        public Message(int Id)
        {
            internalId = Id;
        }

        public Message(string Text, int Sender, int Thread)
        {//CREATE TABLE messages (thread int, sender int, text varchar(1024), timeSent int, upvotes int)
            new SQLiteCommand(string.Format("INSERT INTO messages (thread, sender, text, timeSent) VALUES ({0}, {1}, '{2}', {3})", 
                Thread.ToString(), Sender.ToString(), Text, DateTime.Now.ToBinary()), Connector.Connector.GetConnection()).ExecuteNonQuery();

            SQLiteDataReader query = new SQLiteCommand("SELECT ROWID FROM messages ORDER BY timeSent DESC LIMIT 1", Connector.Connector.GetConnection()).ExecuteReader();
            query.Read();
            internalId = query.GetInt32(0);
        }
    }
}