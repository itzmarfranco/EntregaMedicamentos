using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace medicamentos
{
    public partial class wndLogin : Form
    {
        public wndLogin()
        {
            InitializeComponent();
            txtUser.Text = "itzmarfranco";
            txtPassword.Text = "1234";
            //Declaramos la variable nombre
            string nombre;
            //Entrada de datos medianta un inputbox
        }


        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (login(txtUser.Text, txtPassword.Text))
            {
                mainframe main = new mainframe();
                //globalVariables.currentUser. = txtUser.Text;
                
                main.Show();
            }
            else
            {
                MessageBox.Show("Incorrecto");
            }
        }

        private bool login(string user, string password)
        {
            using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_validUser, con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                    sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_username, txtUser.Text);
                    sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_password, txtPassword.Text);
                    
                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    con.Close();
                    if (dt.Rows.Count > 0)
                    {
                        globalVariables.currentUser.id = dt.Rows[0].ItemArray[0].ToString();
                        globalVariables.currentUser.fullName = dt.Rows[0].ItemArray[1].ToString();
                        globalVariables.currentUser.username = dt.Rows[0].ItemArray[2].ToString();
                        return true;
                    }
                    else return false;
                }
                catch(Exception e){
                    return false;
                    //MessageBox.Show(e.ToString());
                }                
            }
        }
    }    
}
