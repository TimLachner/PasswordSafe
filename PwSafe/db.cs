using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace PwSafe
{
    internal class db
    {
        public static bool DatenbankVerbindung = false;
        public static MySqlConnection Connection;
        public String Host { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Database { get; set; }
        public db()
        {
            this.Host = "localhost";
            this.Username = "root";
            this.Password = "";
            this.Database = "pwmanager";
        }

        public static String GetConnectionString()
        {
            db sql = new db();
            return $"SERVER={sql.Host}; DATABASE={sql.Database}; UID={sql.Username}; PASSWORD={sql.Password}";
        }
        public static void InitConnection()
        {
            Connection = new MySqlConnection(GetConnectionString());

            try
            {
                Connection.Open();
                DatenbankVerbindung = true;
            }
            catch (Exception e)
            {
                DatenbankVerbindung = false;
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }
        public static void Register(string eName, string ePass)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "INSERT INTO user (username, password) VALUES (@name, @password)";
                command.Parameters.AddWithValue("@name", eName);
                command.Parameters.AddWithValue("@password", ePass);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }
        public static bool Login(string eName, string ePass)
        {
            string password = "";
            string username = "";

            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT * FROM user WHERE username=@name";
                command.Parameters.AddWithValue("@name", eName);

                command.ExecuteNonQuery();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        username = reader.GetString("username");
                        password = reader.GetString("password");
                    }
                }

                if (eName == username && ePass == password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return false;
            }
        }
        public static Tuple<int, bool, bool> GetSettings(int userID)
        {
            int length = 0;
            bool uppercase = true;
            bool specialchar = true;
            try
            {

                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT * FROM settings WHERE userid=@userid";
                command.Parameters.AddWithValue("@userid", userID);

                command.ExecuteNonQuery();

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        length = reader.GetInt16("length");
                        uppercase = reader.GetBoolean("uppercase");
                        specialchar = reader.GetBoolean("specialchar");

                    }
                }
                return Tuple.Create(length, uppercase, specialchar);
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR" + e);
                return null;
            }
        }

        public static bool checkSettings(int userID)
        {
            bool check = false;
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT userid FROM settings WHERE userid=@userid";
                command.Parameters.AddWithValue("@userid", userID);
                
                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        check = true;

                    } else {
                        check = false;
                    }
                }
                return check;
            }
            catch(Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return false;
            }
        }

        public static void AddSettings(int userID)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "INSERT INTO settings (userid, length, uppercase, specialchar) VALUES (@userid, @length, @uppercase, @specialchar)";
                command.Parameters.AddWithValue("@userid", userID);
                command.Parameters.AddWithValue("@length", 30);
                command.Parameters.AddWithValue("@uppercase", 1);
                command.Parameters.AddWithValue("@specialchar", 1);
                
                command.ExecuteNonQuery();


            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }

        public static void UpdateSettings(int userID, int length, bool uppercase, bool specialchar)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "UPDATE settings SET length=@length, uppercase=@uppercase, specialchar=@specialchar WHERE userid=@userid";
                command.Parameters.AddWithValue("@length", length);
                command.Parameters.AddWithValue("@uppercase", uppercase);
                command.Parameters.AddWithValue("@specialchar", specialchar);
                command.Parameters.AddWithValue("@userid", userID);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }
        public static string[] GetCategories(int userid)
        {
            List<string> categoryList = new List<string>();
            string[] categories;
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT name FROM categories WHERE userid=@userid";
                command.Parameters.AddWithValue("@userid", userid);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        categoryList.Add(reader.GetString("name"));
                    }
                    reader.Close();

                }
                categories = categoryList.ToArray();
                return categories;

            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return null;
            }

        }
        public static void SaveCategories(int userid, string name)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "INSERT INTO categories (userid, name) VALUES (@userid, @name)";
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@name", name);

                command.ExecuteNonQuery();

            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }
        public static int getUserID(string hashUsername)
        {
            int userID = 0;
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT id FROM user WHERE username=@username";
                command.Parameters.AddWithValue("@username", hashUsername);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        userID = reader.GetInt16("id");

                    }
                }
                return userID;
            }
            catch(Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return 0;
            }
        }
        public static void SavePassword(int userid, string titel,string category, string username, string password, string website, string infos)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "INSERT INTO passwordlist (userid, titel,category, username, password, website, infos) VALUES (@userid, @titel,@category, @username, @password, @website, @infos)";
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@website", website);
                command.Parameters.AddWithValue("@infos", infos);
                
                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }
        public static string[] getPasswordTitle(int userID)
        {
            List<string> passwordtitlesList = new List<string>();
            string[] passwordtitles;
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT titel FROM passwordlist WHERE userid=@userid";
            command.Parameters.AddWithValue("@userid", userID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        passwordtitlesList.Add(reader.GetString("titel"));
                    }
                    reader.Close();


                }
                passwordtitles = passwordtitlesList.ToArray();
                return passwordtitles;
            }
        }
        public static Tuple<string, string, string, string, string> GetPassswordlist(string titel, int userID)
        {
            try
            {
                string category = "";
                string username = "";
                string password = "";
                string website = "";
                string info = "";

                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT category, username, password, website, infos FROM passwordlist WHERE userid=@userid AND titel=@titel";
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@userid", userID);
                command.Parameters.AddWithValue("@website", website);
                command.Parameters.AddWithValue("@infos", info);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        category = reader.GetString("category");
                        username = reader.GetString("username");
                        password = reader.GetString("password");
                        website = reader.GetString("website");
                        info = reader.GetString("infos");

                    }
                    reader.Close();
                }
                return Tuple.Create(category, username, password, website, info);
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return null;
            }
        }
        public static string[] getPasswordtitleByCategory(int userID, string category)
        {
            List<string> passwordtitlesList = new List<string>();
            string[] passwordtitles;
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT titel FROM passwordlist WHERE userid=@userid AND category=@category";
            command.Parameters.AddWithValue("@userid", userID);
            command.Parameters.AddWithValue("@category", category);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        passwordtitlesList.Add(reader.GetString("titel"));
                    }
                    reader.Close();
                    }
                passwordtitles = passwordtitlesList.ToArray();
                return passwordtitles;
            }
        }
        public static int GetIDbyTitle(string titel, int userid)
        {
            int titelID = 0;
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT id FROM passwordlist WHERE titel=@titel AND userid=@userid";
            command.Parameters.AddWithValue("@titel", titel);
            command.Parameters.AddWithValue("@userid", userid);
            using(MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    reader.Read();
                    titelID = reader.GetInt16("id");
                }
                return titelID;
            }
        }

        public static Tuple<string, string, string, string, string> GetPassswordlistbyTitelID(int titelID, int userID)
        {
            try
            {
                string category = "";
                string username = "";
                string password = "";
                string website = "";
                string info = "";

                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "SELECT category, username, password, website, infos FROM passwordlist WHERE userid=@userid AND id=@titelID";
                command.Parameters.AddWithValue("@titelID", titelID);
                command.Parameters.AddWithValue("@userid", userID);
                command.Parameters.AddWithValue("@website", website);
                command.Parameters.AddWithValue("@infos", info);

                using (MySqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.HasRows)
                    {
                        reader.Read();
                        category = reader.GetString("category");
                        username = reader.GetString("username");
                        password = reader.GetString("password");
                        website = reader.GetString("website");
                        info = reader.GetString("infos");

                    }
                    reader.Close();
                }
                return Tuple.Create(category, username, password, website, info);
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
                return null;
            }
        }

        public static bool CheckCategory(int userID, string category)
        {
            MySqlCommand command = Connection.CreateCommand();
            command.CommandText = "SELECT name FROM categories WHERE userid=@userid AND name=@name";
            command.Parameters.AddWithValue("@name", category);
            command.Parameters.AddWithValue("@userid", userID);

            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    return true;
                }
                return false;
            }
        }
        public static void UpdatePassword(int userid, string titel, string category, string username, string password, string website, string infos, int id)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                //command.CommandText = "UPDATE passwordlist SET (userid, titel, category, username, password, website, infos) VALUES (@userid, @titel,@category, @username, @password, @website, @infos) WHERE id=@id";
                command.CommandText = "UPDATE `passwordlist` SET `userid`=@userid,`id`=@id,`titel`=@titel,`category`=@category,`username`=@username,`password`=@password,`website`=@website,`infos`=@infos WHERE `id`=@id";
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@titel", titel);
                command.Parameters.AddWithValue("@category", category);
                command.Parameters.AddWithValue("@username", username);
                command.Parameters.AddWithValue("@password", password);
                command.Parameters.AddWithValue("@website", website);
                command.Parameters.AddWithValue("@infos", infos);
                command.Parameters.AddWithValue("@id", id);

                command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show("MYSQL ERROR " + e);
            }
        }

        public static void deletePassword(int userid, int titelid)
        {
            try
            {
                MySqlCommand command = Connection.CreateCommand();
                command.CommandText = "DELETE FROM passwordlist Where userid=@userid AND id=@titelid";
                command.Parameters.AddWithValue("@userid", userid);
                command.Parameters.AddWithValue("@titelid", titelid);

                command.ExecuteNonQuery();
            }
            catch(Exception e)
            {
                MessageBox.Show("MySql ERROR " + e);
            }
        }
    }
}
