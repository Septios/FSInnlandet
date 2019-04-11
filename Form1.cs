using System;
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
    public partial class Form1 : Form
    {
        //Connection string to open the connection to MySQL database.
        string connectionString = @"Server=localhost; User id=root; Password=123456; Database=student;";
        //Sets the value of idStudent to 0.
        int idStudent = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)

        {
            Clear();
            GridFill();
        }
        //void for ButtonSave Form1.
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    //Initiates the connection to the DB server.
                    mysqlCon.Open();
                    //Tells which stored procedure is going to be executed. In this case the "StudentAddOrEdit" procedure.
                    MySqlCommand mySqlCmd = new MySqlCommand("StudentAddOrEdit", mysqlCon);
                    //Setting the commandtype to Stored Procedure.
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    //These parameteres corresponds with the text boxes and inserts the text inside the correct collums in the table of the databse.
                    mySqlCmd.Parameters.AddWithValue("_idStudent", idStudent);
                    mySqlCmd.Parameters.AddWithValue("_Fornavn", txtFornavn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Etternavn", txtEtternavn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Adresse", txtAdresse.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Telefon", txtTelefon.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Alder", txtAlder.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Kjønn", txtKjønn.Text.Trim());
                    mySqlCmd.Parameters.AddWithValue("_Postnummer", txtPostnummer.Text.Trim());
                    mySqlCmd.ExecuteNonQuery();
                    //Shows a message box if the information entered was submitted successfully.
                    MessageBox.Show("Submitted Successfully");
                    Clear();
                    GridFill();
                }
            }
            //Cathches any errors that occurs in the software.
            catch (Exception ex)
            {
                //Displays a raw error message, this is usefull for IT-Admins but will most likely be gibberish to the end-user.
                MessageBox.Show(ex.Message.ToString());

            }
        }
        void GridFill()
        {
            using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
            {
                //Opens the MySQL connection.
                mysqlCon.Open();
                //Tells which stored procedure is going to be executed.
                MySqlDataAdapter sqlDa = new MySqlDataAdapter("StudentViewAll", mysqlCon);
                //Setting the commandtype to Stored Procedure.
                sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                //Takes the gathered information from the stored procedure and exports the information in to the dtblstudent Datatable.
                DataTable dtblStudent = new DataTable();
                sqlDa.Fill(dtblStudent);
                //Fills the datagridview dgvStudent with the information from the stored procedure.
                dgvStudent.DataSource = dtblStudent;
                //Makes the first column invisible because the end-user doesn't need the information.
                dgvStudent.Columns[0].Visible = false;
                //Changes the header name of Column 7 to Postnummer.
                dgvStudent.Columns[7].HeaderText = "Postnummer";
                //Changes the widht of Alder and Kjønn columns.  
                dgvStudent.Columns[5].Width = 40;
                dgvStudent.Columns[6].Width = 40;
            }
        }
        //Void for Clear Function.
        void Clear()
        {
            //Setting all the textboxes back to empty, telling the text boxes that they are equal to empty.
            txtFornavn.Text = txtEtternavn.Text = txtAdresse.Text = txtTelefon.Text = txtAlder.Text = txtKjønn.Text = txtPostnummer.Text = txtSearch.Text = "";
            //Resetting the idStudent to zero.
            idStudent = 0;
            //Changes the btnSave.Text back to saying Save.
            btnSave.Text = "Save";
            btnDelete.Enabled = false;
        }

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index != -1)
            {
                //Taking the information from the table and writes it to the corresponding textboxes, so it can be edited or deleted.
                txtFornavn.Text = dgvStudent.CurrentRow.Cells[1].Value.ToString();
                txtEtternavn.Text = dgvStudent.CurrentRow.Cells[2].Value.ToString();
                txtAdresse.Text = dgvStudent.CurrentRow.Cells[3].Value.ToString();
                txtTelefon.Text = dgvStudent.CurrentRow.Cells[4].Value.ToString();
                txtAlder.Text = dgvStudent.CurrentRow.Cells[5].Value.ToString();
                txtKjønn.Text = dgvStudent.CurrentRow.Cells[6].Value.ToString();
                txtPostnummer.Text = dgvStudent.CurrentRow.Cells[7].Value.ToString();
                idStudent = Convert.ToInt32(dgvStudent.CurrentRow.Cells[0].Value.ToString());
                //Changing the Save button text to say "Update" instead.
                btnSave.Text = "Update";
                //Makes the use of the Delete button possible.
                btnDelete.Enabled = Enabled;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    //Opens the MySQL connection.
                    mysqlCon.Open();
                    //Tells which stored procedure is going to be executed.
                    MySqlDataAdapter sqlDa = new MySqlDataAdapter("StudentSearchByValue", mysqlCon);
                    //Sets the commandtype to Stored Procedure.
                    sqlDa.SelectCommand.CommandType = CommandType.StoredProcedure;
                    //Takes the text from the txtSearch text box and exports it to _SearchValue, to be used in the stored procedure.
                    sqlDa.SelectCommand.Parameters.AddWithValue("_SearchValue", txtSearch.Text);
                    //Takes the gathered information from the stored procedure and exports the information in to the dtblstudent Datatable.
                    DataTable dtblStudent = new DataTable();
                    sqlDa.Fill(dtblStudent);
                    //Fills the DataGridView dgvStudent with the information from the stored procedure.
                    dgvStudent.DataSource = dtblStudent;
                    //Makes the first column invisible because the end-user doesn't need the information.
                    dgvStudent.Columns[0].Visible = false;
                }
            }
            //Cathches any errors that occurs in the software.
            catch (Exception search)
            {
                //Displays a raw error message, this is usefull for IT-Admins but will most likely be gibberish to the end-user.
                MessageBox.Show(search.Message.ToString());
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //Clears the text-box inputs when the Cancel button is pressed (Runs the clear function).
            Clear();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection mysqlCon = new MySqlConnection(connectionString))
                {
                    //Opens the mysql connection.
                    mysqlCon.Open();
                    //Tells which stored procedure is going to be executed.
                    MySqlCommand mySqlCmd = new MySqlCommand("StudentDeleteByID", mysqlCon);
                    //Sets the commandtype to Stored Procedure
                    mySqlCmd.CommandType = CommandType.StoredProcedure;
                    //Takes the idStudent value and sends it to the stored procedure.
                    mySqlCmd.Parameters.AddWithValue("_idStudent", idStudent);
                    mySqlCmd.ExecuteNonQuery();
                    //Shows a message box saying that the Deleted entry was done successfully.
                    MessageBox.Show("Deleted Successfully");
                    Clear();
                    GridFill();
                }
            }
            //Cathches any errors that occurs in the software.
            catch (Exception delete)
            {
                //Displays a raw error message, this is usefull for IT-Admins but will most likely be gibberish to the end-user.
                MessageBox.Show(delete.Message.ToString());
            }
        }
        //Opens up From2 when the button for adding fylke and postnummer is pressed.
        private void labelFylkePost_Click(object sender, EventArgs e)
        {
            Form2 Postnummer = new Form2();
            Postnummer.Show();
        }
    }
}