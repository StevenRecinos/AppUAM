using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.Sql;
using MySql.Data.MySqlClient;
using System.Data.Odbc;

namespace App
{
    public class ConectarBD
    {
        public static MySqlConnection abrirconexion()
        {

         MySqlConnection cn = new MySqlConnection("server=localhost; Database=prueba; persist security info=True; User Id =root; password=");
        cn.Open();
        return cn;















            /*
            const String stringSQL = "server=localhost;user id=root;password=;persist security info=True;database=prueba";
            DataSet ds = new DataSet();
            MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(stringSQL);
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand();

            public static string valor;

            public bool OpenConnection()
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (MySqlException ex)
                {
                    //When handling errors, you can your application's response based 
                    //on the error number.
                    //The two most common error numbers when connecting are as follows:
                    //0: Cannot connect to server.
                    //1045: Invalid user name and/or password.
                    switch (ex.Number)
                    {
                        case 0:
                            MessageBox.Show("Cannot connect to server.  Contact administrator");
                            break;

                        case 1045:
                            MessageBox.Show("Invalid username/password, please try again");
                            break;
                    }
                    return false;
                }
            }

            private bool CloseConnection()
            {
                try
                {
                    connection.Close();
                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show(ex.Message);
                    return false;
                }
            */
        }

    }
} 
