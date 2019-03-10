using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Agenda
{
    class SQL
    {
        static string strCon = @"Data Source=localhost;Initial Catalog=Agenda;Integrated Security=True";

        #region DB
        public static void Add(int id, string name, string fname, string phone, string email)
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("execute DB_Add '" + id + "', '" + name + "', '" + fname + "', '" + phone + "', '" + email + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show("Failed to add! \nError: " + e.Message); }
        }

        public static void Del(int id)
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("execute DB_Del " + id, con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show("Failed to delete! \nError: " + e.Message); }
        }

        public static void Update(int id, string name, string fname, string phone, string email)
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("execute DB_Update '" + id + "', '" + name + "', '" + fname + "', '" + phone + "', '" + email + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                System.Windows.Forms.MessageBox.Show("Succesfully edited!");
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show("Failed to edit! \nError: " + e.Message); }
        }

        public static void Edit(int id, string name, string fname, string phone, string email)
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("execute DB_Edit '" + id + "', '" + name + "', '" + fname + "', '" + phone + "', '" + email + "'", con);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show("Failed to edit! \nError: " + e.Message); }
        }
        #endregion

        #region GUI
        public static int getMaxID()
        {
            try
            {
                SqlConnection con = new SqlConnection(strCon);
                SqlCommand cmd = new SqlCommand("execute GUI_getMaxID ", con);
                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                reader.Read();
                int x = Convert.ToInt32(reader[""].ToString());
                con.Close();
                return x;
            }
            catch (Exception e) { System.Windows.Forms.MessageBox.Show("Error: " + e.Message); return 0; }

        }
        #endregion
    }
}
