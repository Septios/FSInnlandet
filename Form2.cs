﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace studentCRUD
{
    public partial class Form2 : Form
    {
        //Connection string to open the connection to MySQL database.
        string ConnectionString = @"Server=localhost; User id=root; Password=123456; Database=student;";
        //Sets the value of idStudent to 0.
        int idFylke = 0;

        public Form2()
        {
            InitializeComponent();
        }

        //DataGridView Postnummer
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(ConnectionString))
            {
                //Opens the mysql connection
                mysqlCon.Open();
                //Telling the application to use the stored procedure PostnummerViewAll
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("PostnummerViewAll", mysqlCon);
                //Setting the commandtype to stored procedure
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Takes the data from the procedure and exports it into the Datatable dtblPostnummer
                DataTable dtblPostnummer = new DataTable();
                sqlDA.Fill(dtblPostnummer);
                //Telling the datagridview to display the information given from the datatable dtblPostnummer
                dgvPostnummer.DataSource = dtblPostnummer;
            }
        }

        //DataGridView Fylke
        void GridFill2()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(ConnectionString))
            {
                //Opens the mysql connection
                mysqlCon.Open();
                //Telling the application to use the stored procedure FylkeViewAll
                MySqlDataAdapter sqlDA = new MySqlDataAdapter("FylkeViewAll", mysqlCon);
                //Setting the commandtype to stored procedure
                sqlDA.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Takes the data from the procedure and exports it into the Datatable dtblFylke
                DataTable dtblFylke = new DataTable();
                sqlDA.Fill(dtblFylke);
                //Telling the datagridview to display the information given from the datatable dtblFylke
                dgvFylke.DataSource = dtblFylke;
            }
        }

        //Calls both the gridfill function to fill both the datagridviews when form2 opens
        private void Form2_Load(object sender, EventArgs e)
        {
            GridFill();
            GridFill2();
        }

        private void btnSavePost_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(ConnectionString))
                {
                    //Opens the mysql conncetion
                    mysqlCon.Open();
                    //Telling the application to use the stored procedure PostnummerAdd
                    MySqlCommand mySqlCmd = new MySqlCommand("PostnummerAdd", mysqlCon);
                    //Setting the commandtype to Stored Procedure
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    //Exporting the information fromt the text boxes into the variables used by the stored procedure in mysql databse
                    mySqlCmd.Parameters.AddWithValue("_idPostnummer", txtPostnummer.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Poststed", txtPoststed.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_fylke_idFylke", txtFylkeID.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    //Showing a message box saying the submittion was successfull
                    MessageBox.Show("Submitted Successfully");
                    btnSavePost.Text = "Save";
                    //Calling both the gridfill functions and clear function to refresh the datagridviews and clearing out the text from the text boxes
                    GridFill();
                    GridFill2();
                    Clear();
                }

            }
            //Cathching any errors that occurs in the software
            catch (Exception ex)
            {
                //Displaying a raw error message, usefull for IT-administrators, not usefull in this form for the end-user.
                MessageBox.Show(ex.Message.ToString());

            }
        }

        void Clear()
        {
            //Setting the text boxes equal to empty and clears the text boxes for postnummer
            txtPoststed.Text = txtPostnummer.Text = txtFylkeID.Text = "";
        }

        void ClearFylke()
        {
            //Setting the text boxes for Fylke to empty to clear it
            txtFylke.Text = "";
            txtFylkeID.Text = "";
            //Resetting idFylke to zero
            idFylke = 0;
        }

        //Calling the clear function when the cancel button is pressed
        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
            btnSavePost.Enabled = Enabled;
        }

        private void btnSaveFylke_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(ConnectionString))
                {
                    //Opens the mysql conncetion
                    mysqlCon.Open();
                    //Telling the application to use stored procedure FylkeAdd
                    MySqlCommand mySqlCmd = new MySqlCommand("FylkeAdd", mysqlCon);
                    //Setting the commandtype to stored procedure
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    //Saying that the _idFylke is zero and that auto increment in is to be used by the mysql databse
                    mySqlCmd.Parameters.AddWithValue("_idFylke", idFylke);
                    //Exporting the information from the text box txtFylke into _Fylke used by the stored procedure
                    mySqlCmd.Parameters.AddWithValue("_Fylke", txtFylke.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    //Showing a message box that says the submittion was successfull
                    MessageBox.Show("Submitted Successfully");
                    //Calling both the Gridfill functions to refresh the information shown in the datagridviews
                    GridFill();
                    GridFill2();
                    //Calling the ClearFylke function to clear the text boxes
                    ClearFylke();
                }
            }
            //Cathching any errors that occurs in the software
            catch (Exception ex)
            {
                //Displaying a raw error message, usefull for IT-administrators, not usefull in this form for the end-user.
                MessageBox.Show(ex.Message.ToString());

            }
        }

        //Calling the clearFylke function to clear the text boxes
        private void btnCancelFylke_Click(object sender, EventArgs e)
        {
            ClearFylke();
        }

        private void dgvPostnummer_DoubleClick(object sender, EventArgs e)
        {
            if (dgvPostnummer.CurrentRow.Index != -1)
            {
                //Taking the information from the table and writes it in to the corresponding textboxes so it can be edited or deleted
                txtFylkeID.Text = dgvPostnummer.CurrentRow.Cells[2].Value.ToString();
                txtPoststed.Text = dgvPostnummer.CurrentRow.Cells[1].Value.ToString();
                txtPostnummer.Text = dgvPostnummer.CurrentRow.Cells[0].Value.ToString();
                //idPostnummer = Convert.ToInt32(dgvPostnummer.CurrentRow.Cells[0].Value.ToString());  
                btnSavePost.Enabled = false;
            }
        }

        private void dgvFylke_DoubleClick(object sender, EventArgs e)
        {
            if (dgvFylke.CurrentRow.Index != -1)
            {
                //Taking the information from the table and writes it in to the corresponding textboxes so it can be edited or deleted
                txtFylke.Text = dgvFylke.CurrentRow.Cells[1].Value.ToString();
                txtFylkeID.Text = dgvFylke.CurrentRow.Cells[0].Value.ToString();
                //idPostnummer = Convert.ToInt32(dgvPostnummer.CurrentRow.Cells[0].Value.ToString());  
                btnSaveFylke.Enabled = false;
            }
        }
    }
}
