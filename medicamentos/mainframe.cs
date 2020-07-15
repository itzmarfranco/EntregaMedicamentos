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
    public partial class mainframe : Form
    {
        public mainframe()
        {
            InitializeComponent();   
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            save();
        }

        private void save()
        {
            using(SqlConnection connection = new SqlConnection(globalVariables.connectionString))
            {
                if (txtMedName.Text != "")
                {
                    if (dpExpDate.Value.ToShortDateString() != "")
                    {
                        if(txtlot.Text != "")
                        {
                            if (txtQuantity.Text != "")
                            {
                                try
                                {
                                    connection.Open();
                                    SqlCommand command = new SqlCommand(globalVariables.sp_saveMedicine, connection);
                                    command.CommandType = CommandType.StoredProcedure;
                                    command.Parameters.AddWithValue(globalVariables.spvar_medName, txtMedName.Text);
                                    //get date and formate like YYYY/MM/DD
                                    DateTime dt = Convert.ToDateTime(dpExpDate.Value.ToShortDateString());
                                    command.Parameters.AddWithValue(globalVariables.spvar_expDate, dt.Year.ToString() + '/' + dt.Month.ToString() + '/' + dt.Day.ToString());
                                    command.Parameters.AddWithValue(globalVariables.spvar_lot, txtlot.Text);
                                    command.Parameters.AddWithValue(globalVariables.spvar_quantity, txtQuantity.Text);
                                    command.ExecuteNonQuery();
                                    connection.Close();
                                    //clear text boxes
                                    clearTextBoxes();
                                    txtMedName.Focus();
                                }
                                catch (Exception e)
                                {
                                    MessageBox.Show("No se pudo abrir conexión para guardar " + e);
                                }
                            }
                            else MessageBox.Show("Ingrese el lote del medicamento");
                        }
                        else MessageBox.Show("Ingrese la cantidad de unidades del medicamento");
                    }
                    else MessageBox.Show("Ingrese la fecha de expiración del medicamento");
                }
                else MessageBox.Show("Ingrese el nombre del medicamento");
            }
            loadMedicines(dgvMedicines);
        }

        private void mainframe_Load(object sender, EventArgs e)
        {
            if(globalVariables.currentUser != null) lblCurrentUser.Text = "Usuario: " + globalVariables.currentUser.fullName;

            //load medicaments into table
            loadMedicines(dgvMedicines);
        }

        private void loadMedicines(DataGridView dgv)
        {
            using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
            {
                try
                {
                    con.Open();
                    SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_loadMedicines, con);
                    sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                    DataTable dt = new DataTable();
                    sda.Fill(dt);

                    con.Close();
                    dgv.DataSource = dt;
                }
                catch (Exception e)
                {
                    //MessageBox.Show(e.ToString());
                }
            }
        }

        private void loadMedicineToText()
        {
            if(dgvMedicines.CurrentRow.Index != -1)
            {
                txtID.Text = dgvMedicines.CurrentRow.Cells[0].Value.ToString();
                txtMedName .Text = dgvMedicines.CurrentRow.Cells[1].Value.ToString();
                DateTime dt = Convert.ToDateTime(dgvMedicines.CurrentRow.Cells[2].Value.ToString());
                txtQuantity.Text = dgvMedicines.CurrentRow.Cells[3].Value.ToString();
            }
        }

        private void dgvMedicines_DoubleClick(object sender, EventArgs e)
        {
            //loadMedicineToText();
            string id = dgvMedicines.CurrentRow.Cells[0].Value.ToString();
            string medName = dgvMedicines.CurrentRow.Cells[1].Value.ToString();
            DateTime dt = Convert.ToDateTime(dgvMedicines.CurrentRow.Cells[2].Value.ToString());
            string lot = dgvMedicines.CurrentRow.Cells[3].Value.ToString();
            txtQuantity.Text = dgvMedicines.CurrentRow.Cells[4].Value.ToString();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Entregando: " + medName, "Entregas", "Cantidad", 400, 400);
            int quatity = -1;
            try
            {
                quatity = Convert.ToInt32(input);
                if (quatity <= 0)
                {
                    MessageBox.Show("Ingrese una cantidad mayor a 0");
                }
                else
                {
                    //deliver procedure


                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("El valor ingresado no es válido: " + ex.ToString());
            }
            //MessageBox.Show("Bienvenido Usuario: " + test, "Registro de Datos Personales", MessageBoxButtons.OK);
        }

        private void deliver(int medicine, int user, int quantity, int delivered)
        {
            using (SqlConnection connection = new SqlConnection(globalVariables.connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(globalVariables.sp_deliverMedicine, connection);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue(globalVariables.spvar_medId, medicine);
                    command.Parameters.AddWithValue(globalVariables.spvar_userId, user);
                    command.Parameters.AddWithValue(globalVariables.spvar_quantity, quantity);
                    command.Parameters.AddWithValue(globalVariables.spvar_delivered, delivered);

                    command.ExecuteNonQuery();
                    connection.Close();
                    //clear text boxes
                    clearTextBoxes();
                    MessageBox.Show("Entregado" + quantity.ToString());
                }
                catch (Exception e)
                {
                    MessageBox.Show("No se pudo abrir conexión para guardar " + e);
                }
            }
            
        }

        private void clearTextBoxes()
        {
            txtMedName.Text = "";
            txtQuantity.Text = "";
            txtlot.Text = "";
        }

        private void searchMedicine(string filter)
        {
            if(txtSearch.Text == "")
            {
                loadMedicines(dgvMedicines);
            }
            else
            {
                //search function
                using (SqlConnection connection = new SqlConnection(globalVariables.connectionString))
                {
                    try
                    {
                        connection.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_searchMedicine, connection);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;
                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_medName, txtSearch.Text);
                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        connection.Close();
                        dgvMedicines.DataSource = dt;

                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("No se pudo abrir conexión para guardar " + e);
                    }
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            clearTextBoxes();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchMedicine(txtSearch.Text);
        }

        private void btnDeliver_Click(object sender, EventArgs e)
        {
            string test = Microsoft.VisualBasic.Interaction.InputBox("Cantidad ", "Cantidad a entregar ", "Cantidad", 500, 500);
            if(test != "Cantidad")
            {

            }
            try
            {
                int quantity = Convert.ToInt32(test);
                int stock = Convert.ToInt32(dgvMedicines.CurrentRow.Cells[4].Value.ToString());
                if(quantity < 1)
                {
                    MessageBox.Show("No puede entregar 0 medicinas");
                }
                else
                {
                    //call deliver procedure
                    //medicina usuario cantidad entregado
                    int medID = Convert.ToInt32(dgvMedicines.CurrentRow.Cells[0].Value.ToString());
                    int userID = Convert.ToInt32(globalVariables.currentUser.id);
                    if(stock >= quantity)
                    {
                        deliver(medID, userID, quantity, 1);
                    }
                    else if(stock < quantity && stock > 0)
                    {
                        deliver(medID, userID, stock, 1);
                        deliver(medID, userID, quantity - stock, 0);
                    }
                    else if(stock == 0)
                    {
                        deliver(medID, userID, quantity, 0);
                    }
                    loadMedicines(dgvMedicines);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ingrese un número válido");
            }
        }

        private void deliverMedicine()
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exit();
        }

        private void exit()
        {
            const string message = "¿Está seguro que quiere salir?";
            const string caption = "Cerrar sesión";
            var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // If the no button was pressed ...
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnLoadReport_Click(object sender, EventArgs e)
        {
            if (cbreports.SelectedItem != null)
            {
                string reportName = cbreports.SelectedItem.ToString();
                if(reportName != "")
                {
                    loadReportToScreen(reportName);
                }
            }
        }

        private void loadReportToScreen(string report)
        {
            if (report == "Inventario actual")
            {
                using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_loadMedicines, con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DataTable dt = new DataTable();
                        sda.Fill(dt);

                        con.Close();
                        dgvreports.DataSource = dt;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }
            }
            else if (report == "Demanda de medicamentos sin existencia")
            {
                using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_loadMedicinesNonDelivered, con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DateTime dt1 = Convert.ToDateTime(dtp1.Value.ToShortDateString());
                        DateTime dt2 = Convert.ToDateTime(dtp2.Value.ToShortDateString());

                        String startDate = dt1.Month.ToString() + "/" + dt1.Day.ToString() + "/" + dt1.Year.ToString();
                        String endDate = dt2.Month.ToString() + "/" + dt2.Day.ToString() + "/" + dt2.Year.ToString();

                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_startDate, startDate);
                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_endDate, endDate); 

                        DataTable dtb = new DataTable();
                        sda.Fill(dtb);

                        con.Close();
                        dgvreports.DataSource = dtb;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }                
            }
            else if (report == "Entregas diarias")
            {
                using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_loadMedicinesDaily, con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DateTime dt1 = Convert.ToDateTime(dtp1.Value.ToShortDateString());
                        DateTime dt2 = Convert.ToDateTime(dtp2.Value.ToShortDateString());

                        String startDate = dt1.Month.ToString() + "/" + dt1.Day.ToString() + "/" + dt1.Year.ToString() + " 00:00:00";
                        String endDate = dt1.Month.ToString() + "/" + dt1.Day.ToString() + "/" + dt1.Year.ToString() + " 23:59:59";

                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_startDate, startDate);
                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_endDate, endDate);

                        DataTable dtb = new DataTable();
                        sda.Fill(dtb);

                        con.Close();
                        dgvreports.DataSource = dtb;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }     
            }
            else if (report == "Entregas en período")
            {
                using (SqlConnection con = new SqlConnection(globalVariables.connectionString))
                {
                    try
                    {
                        con.Open();
                        SqlDataAdapter sda = new SqlDataAdapter(globalVariables.sp_loadMedicinesDelivered, con);
                        sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                        DateTime dt1 = Convert.ToDateTime(dtp1.Value.ToShortDateString());
                        DateTime dt2 = Convert.ToDateTime(dtp2.Value.ToShortDateString());

                        String startDate = dt1.Month.ToString() + "/" + dt1.Day.ToString() + "/" + dt1.Year.ToString();
                        String endDate = dt2.Month.ToString() + "/" + dt2.Day.ToString() + "/" + dt2.Year.ToString();

                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_startDate, startDate);
                        sda.SelectCommand.Parameters.AddWithValue(globalVariables.spvar_endDate, endDate);

                        DataTable dtb = new DataTable();
                        sda.Fill(dtb);

                        con.Close();
                        dgvreports.DataSource = dtb;
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.ToString());
                    }
                }  
            }
            else if (report == "Entregas mensuales")
            {

            }
        }

        private void cbreports_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string report = (string)cbreports.SelectedItem;
            if (report.Equals("Inventario actual"))
            {
                dtp1.Visible = false;
                dtp2.Visible = false;
            }
            else if (report.Equals("Demanda de medicamentos sin existencia"))
            {
                dtp1.Visible = true;
                dtp2.Visible = true;
            }
            else if (report.Equals("Entregas diarias"))
            {
                dtp1.Visible = true;
                dtp2.Visible = false;
            }
            else if (report.Equals("Entregas en período"))
            {
                dtp1.Visible = true;
                dtp2.Visible = true;
            }
        }
    }
}
