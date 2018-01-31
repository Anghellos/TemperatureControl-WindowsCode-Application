using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using Domain;
using System;

namespace AzureConnection
{
    public class Broker
    {
        private const string AddUserPath = "\\SQLQuery\\AddUser.sql";
        private const string GetUserPath = "\\SQLQuery\\GetUser.sql";
        private const string UpdateUserPath = "\\SQLQuery\\UpdateUser.sql";
        private const string DeleteUserPath = "\\SQLQuery\\DeleteUser.sql";
        private const string GetUsersListPath = "\\SQLQuery\\GetUsersList.sql";
        private const string GetMaxPriorityPath = "\\SQLQuery\\GetMaxPriority.sql";

        private SqlConnection _conn;
        private string _sqlServer;
        private string _userId;
        private string _password;
        private string _table;

        //=======================================Costructor=======================================//

        public void ConnectionCredential(string sqlServer, string userId, string password, string table)
        {
            _sqlServer = sqlServer;
            _userId = userId;
            _password = password;
            _table = table;
        }

        //========================================Methods=========================================//

        public bool ConnectDB()
        {
            try
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = _sqlServer;
                builder.UserID = _userId;
                builder.Password = _password;
                builder.InitialCatalog = _table;

                _conn = new SqlConnection(builder.ConnectionString);
                _conn.Open();
                return true;
            }
            catch (SqlException e)
            {
                return false;
            }
        }

        public void AddUser(User user)
        {
            try
            {
                if (!ConnectDB())
                    return;

                string sql = ReadSql(GetMaxPriorityPath);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                user.SetPriority((int)cmd.ExecuteScalar() + 1);

                sql = ReadSql(AddUserPath);
                cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@Priority", user.Priority);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@OptimTemp", user.OptimTemp);
                cmd.ExecuteNonQuery();

                _conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Unable to add new user",
                    "Connection to DataBase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public User GetUser(User user)
        {
            try
            {
                if (!ConnectDB())
                    return user;

                string sql = ReadSql(GetUserPath);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    user.SetPriority(read.GetInt32(0));
                    user.SetOptimTemp(read.GetInt32(2));
                }
                _conn.Close();
                return user;
            }
            catch (SqlException e)
            {
                MessageBox.Show("No user found",
                    "Connection to DataBase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return user;
            }
        }

        public User UpdateUser(User user)
        {
            try
            {
                if (!ConnectDB())
                    return user;

                string sql = ReadSql(UpdateUserPath);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@Priority", user.Priority);
                cmd.Parameters.AddWithValue("@OptimTemp", user.OptimTemp);
                cmd.ExecuteNonQuery();

                _conn.Close();
                return user;
            }
            catch (SqlException e)
            {
                MessageBox.Show("No user found",
                    "Connection to DataBase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return user;
            }
        }

        public void DeleteUser(User user)
        {
            try
            {
                if (!ConnectDB())
                    return;

                string sql = ReadSql(DeleteUserPath);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.Parameters.AddWithValue("@Priority", user.Priority);
                cmd.Parameters.AddWithValue("@Name", user.Name);
                cmd.Parameters.AddWithValue("@OptimTemp", user.OptimTemp);
                cmd.ExecuteNonQuery();

                _conn.Close();
            }
            catch (SqlException e)
            {
                MessageBox.Show("Unable to delete user",
                    "Connection to DataBase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public Collection<User> GetUsersList()
        {
            try
            {
                if (!ConnectDB())
                    return new Collection<User>();

                string sql = ReadSql(GetUsersListPath);
                SqlCommand cmd = new SqlCommand(sql, _conn);
                SqlDataReader read = cmd.ExecuteReader();
                Collection<User> Users = new Collection<User>();
                while (read.Read())
                {
                    User user = new User();
                    user.SetName(read.GetString(0));
                    Users.Add(user);
                }

                read.Close();
                _conn.Close();
                return Users;
            }
            catch (SqlException e)
            {
                MessageBox.Show("No users found",
                    "Connection to DataBase Failed",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

                return new Collection<User>();
            }
        }
        
        private string ReadSql(string path)
        {
            string startupPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            FileInfo queryFile = new FileInfo(startupPath + path);
            string sql = queryFile.OpenText().ReadToEnd();
            return sql;
        }
    }
}
