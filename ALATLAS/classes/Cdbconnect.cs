using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using MySql.Data.MySqlClient;

namespace ALATLAS.classes
{
    public class Cdbconnect
    {
        public connection con;

        public MySqlConnection condatmysql;


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////
        /// </summary>

        public void openconn()
        {

            con = new connection();
            condatmysql = new MySqlConnection(con.conndata());

            condatmysql.Open();
        }
        public DataTable selectdata(string query)
        {



            MySqlCommand cmd = new MySqlCommand(query, condatmysql);
            cmd.CommandText = query;
            MySqlDataAdapter myadpter = new MySqlDataAdapter();

            myadpter.SelectCommand = cmd;



            DataTable dt = new DataTable();



            myadpter.Fill(dt);

            return dt;


        }

        public void closeconn()
        {
            condatmysql.Close();
        }
        public void insertdata(string query)
        {
            MySqlCommand cmd = new MySqlCommand(query, condatmysql);

            MySqlDataReader reader;


            reader = cmd.ExecuteReader();
            reader.Close();




        }





    }
}