﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;

namespace S_Foundation
{
    class DBClass
    {
        SqlConnection conn;
        SqlCommand sqlCommand;
        public DBClass()
        {
            conn  = new SqlConnection(@"Data Source=.;Initial Catalog=S_Foundation;Integrated Security=true");
        }


        public bool InsertUpdateDelete(string command)
        {
            SqlCommand cmd = new SqlCommand(command, conn);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
                return true;
            else
                return false;

        }

        public DataTable ReadBulkData(string command)
        {
            SqlDataAdapter da = new SqlDataAdapter(command, conn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public SqlDataReader readData(string command)
        {
            conn.Open();
            sqlCommand=new SqlCommand(command, conn);
            SqlDataReader dr= sqlCommand.ExecuteReader();
            conn.Close();
            return dr;
        }

        public object readScalarData(string command)
        {
            if(conn.State==ConnectionState.Closed)
            conn.Open();
            sqlCommand = new SqlCommand(command,conn);
            object var= sqlCommand.ExecuteScalar();
            return var;
        }

        public bool spUpdate(string name,string email,string age,string gender,string password)
        {
            SqlCommand cmd = new SqlCommand("updateProcedure", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@email", email);     
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@password", password);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
                return true;
            else
                return false;
        }

        public bool spDelete(String mail)
        {
            SqlCommand cmd = new SqlCommand("deleteProcedure", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@mail", mail);
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
                return true;
            else
                return false;
        }

        public bool spRegistration(string name, string email, string age, string gender, string password, string registeredBy)
        {
            SqlCommand cmd = new SqlCommand("registration", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@gender", gender);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@age", age);
            cmd.Parameters.AddWithValue("@password", password);
            cmd.Parameters.AddWithValue("@registeredBy", registeredBy);
            cmd.Parameters.AddWithValue("@date", DateTime.Now.ToString());
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            int res = cmd.ExecuteNonQuery();
            conn.Close();
            if (res > 0)
                return true;
            else
                return false;
        }
    }
}
