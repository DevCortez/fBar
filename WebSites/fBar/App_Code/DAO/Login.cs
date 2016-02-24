using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Connector;
using System.Data.SQLite;
using System.Security.Cryptography;


/// <summary>
/// Summary description for Login
/// </summary>
/// 

namespace DAO
{
    public class Login
    {
        private int internalId;        

        public int Id
        {
            get
            {
                return internalId;
            }
        }

        public string Name
        {
            get
            {
                SQLiteDataReader name = new SQLiteCommand("SELECT user FROM login WHERE ROWID = " + internalId.ToString(), Connector.Connector.GetConnection()).ExecuteReader();
                name.Read();
                return name.GetValue(0).ToString();
            }
        }

        private string HashPassword(string pwd)
        {
            MD5 md5 = MD5.Create();
            md5.ComputeHash(System.Text.Encoding.ASCII.GetBytes(pwd));

            string result = "";
            foreach (byte a in md5.Hash)            
                result += a.ToString();

            return result;            
        }

        public Login(int Id)
        {
            internalId = Id;
        }

        public Login(string user, string pwd)
        {
            if((user == string.Empty && pwd == string.Empty))
            {
                throw new Exception("Usr or pwd is empty dude");
            }

            SQLiteDataReader userExists = new SQLiteCommand(string.Format("SELECT ROWID FROM login WHERE user = '{0}'", user), Connector.Connector.GetConnection()).ExecuteReader();
            string pwdHash = HashPassword(pwd);

            if (userExists.HasRows)
            {
                SQLiteDataReader validateLogin = new SQLiteCommand(string.Format("SELECT ROWID FROM login WHERE user = '{0}' AND pwd = '{1}'", user, pwdHash), Connector.Connector.GetConnection()).ExecuteReader();

                if(validateLogin.HasRows)
                {
                    validateLogin.Read();
                    internalId = validateLogin.GetInt32(0);
                }
                else
                {
                    throw new Exception("Senha inválida");
                }
            }
            else
            {
                new SQLiteCommand(string.Format("INSERT INTO login (user, pwd) VALUES ('{0}', '{1}')", user, pwdHash), Connector.Connector.GetConnection()).ExecuteNonQuery();

                SQLiteDataReader userId = new SQLiteCommand(string.Format("SELECT ROWID FROM login WHERE user = '{0}'", user), Connector.Connector.GetConnection()).ExecuteReader();
                userId.Read();
                internalId = userId.GetInt32(0);
            }
        }
    }
}