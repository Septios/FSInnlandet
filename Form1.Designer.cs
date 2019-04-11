namespace studentCRUD
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.labelFornavn = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.logoPic = new System.Windows.Forms.PictureBox();
            this.txtEtternavn = new System.Windows.Forms.TextBox();
            this.txtAdresse = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtKjønn = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAlder = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelEtternavn = new System.Windows.Forms.Label();
            this.labelAdresse = new System.Windows.Forms.Label();
            this.labelPostnummer = new System.Windows.Forms.Label();
            this.labelKjønn = new System.Windows.Forms.Label();
            this.labelTelefon = new System.Windows.Forms.Label();
            this.labelAlder = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.txtFornavn = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtFylke = new System.Windows.Forms.TextBox();
            this.labelFylke = new System.Windows.Forms.Label();
            this.labelFylkePost = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Location = new System.Drawing.Point(994, 138);
            this.dgvStudent.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.ReadOnly = true;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(1970, 1235);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.DoubleClick += new System.EventHandler(this.dgvStudent_DoubleClick);
            // 
            // labelFornavn
            // 
            this.labelFornavn.AutoSize = true;
            this.labelFornavn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFornavn.Location = new System.Drawing.Point(21, 532);
            this.labelFornavn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelFornavn.Name = "labelFornavn";
            this.labelFornavn.Size = new System.Drawing.Size(195, 50);
            this.labelFornavn.TabIndex = 2;
            this.labelFornavn.Text = "Fornavn:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(994, 36);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(1560, 71);
            this.txtSearch.TabIndex = 3;
            // 
            // logoPic
            // 
            this.logoPic.Image = ((System.Drawing.Image)(resources.GetObject("logoPic.Image")));
            this.logoPic.Location = new System.Drawing.Point(0, 0);
            this.logoPic.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.logoPic.Name = "logoPic";
            this.logoPic.Size = new System.Drawing.Size(674, 511);
            this.logoPic.TabIndex = 4;
            this.logoPic.TabStop = false;
            // 
            // txtEtternavn
            // 
            this.txtEtternavn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEtternavn.Location = new System.Drawing.Point(344, 604);
            this.txtEtternavn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtEtternavn.Name = "txtEtternavn";
            this.txtEtternavn.Size = new System.Drawing.Size(636, 57);
            this.txtEtternavn.TabIndex = 3;
            // 
            // txtAdresse
            // 
            this.txtAdresse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdresse.Location = new System.Drawing.Point(344, 682);
            this.txtAdresse.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtAdresse.Name = "txtAdresse";
            this.txtAdresse.Size = new System.Drawing.Size(636, 57);
            this.txtAdresse.TabIndex = 3;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostnummer.Location = new System.Drawing.Point(344, 997);
            this.txtPostnummer.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(636, 57);
            this.txtPostnummer.TabIndex = 3;
            // 
            // txtKjønn
            // 
            this.txtKjønn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKjønn.Location = new System.Drawing.Point(344, 918);
            this.txtKjønn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtKjønn.MaxLength = 1;
            this.txtKjønn.Name = "txtKjønn";
            this.txtKjønn.Size = new System.Drawing.Size(636, 57);
            this.txtKjønn.TabIndex = 3;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefon.Location = new System.Drawing.Point(344, 761);
            this.txtTelefon.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(636, 57);
            this.txtTelefon.TabIndex = 3;
            // 
            // txtAlder
            // 
            this.txtAlder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAlder.Location = new System.Drawing.Point(344, 839);
            this.txtAlder.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtAlder.Name = "txtAlder";
            this.txtAlder.Size = new System.Drawing.Size(636, 57);
            this.txtAlder.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.Green;
            this.btnSave.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSave.Location = new System.Drawing.Point(66, 1179);
            this.btnSave.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(297, 150);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lagre";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelEtternavn
            // 
            this.labelEtternavn.AutoSize = true;
            this.labelEtternavn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEtternavn.Location = new System.Drawing.Point(21, 610);
            this.labelEtternavn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelEtternavn.Name = "labelEtternavn";
            this.labelEtternavn.Size = new System.Drawing.Size(221, 50);
            this.labelEtternavn.TabIndex = 2;
            this.labelEtternavn.Text = "Etternavn:";
            // 
            // labelAdresse
            // 
            this.labelAdresse.AutoSize = true;
            this.labelAdresse.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdresse.Location = new System.Drawing.Point(21, 689);
            this.labelAdresse.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAdresse.Name = "labelAdresse";
            this.labelAdresse.Size = new System.Drawing.Size(194, 50);
            this.labelAdresse.TabIndex = 2;
            this.labelAdresse.Text = "Adresse:";
            // 
            // labelPostnummer
            // 
            this.labelPostnummer.AutoSize = true;
            this.labelPostnummer.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostnummer.Location = new System.Drawing.Point(21, 1004);
            this.labelPostnummer.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelPostnummer.Name = "labelPostnummer";
            this.labelPostnummer.Size = new System.Drawing.Size(284, 50);
            this.labelPostnummer.TabIndex = 2;
            this.labelPostnummer.Text = "Postnummer:";
            // 
            // labelKjønn
            // 
            this.labelKjønn.AutoSize = true;
            this.labelKjønn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelKjønn.Location = new System.Drawing.Point(21, 925);
            this.labelKjønn.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelKjønn.Name = "labelKjønn";
            this.labelKjønn.Size = new System.Drawing.Size(148, 50);
            this.labelKjønn.TabIndex = 2;
            this.labelKjønn.Text = "Kjønn:";
            // 
            // labelTelefon
            // 
            this.labelTelefon.AutoSize = true;
            this.labelTelefon.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTelefon.Location = new System.Drawing.Point(21, 768);
            this.labelTelefon.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelTelefon.Name = "labelTelefon";
            this.labelTelefon.Size = new System.Drawing.Size(174, 50);
            this.labelTelefon.TabIndex = 2;
            this.labelTelefon.Text = "Telefon:";
            // 
            // labelAlder
            // 
            this.labelAlder.AutoSize = true;
            this.labelAlder.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAlder.Location = new System.Drawing.Point(21, 846);
            this.labelAlder.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelAlder.Name = "labelAlder";
            this.labelAlder.Size = new System.Drawing.Size(136, 50);
            this.labelAlder.TabIndex = 2;
            this.labelAlder.Text = "Alder:";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.SteelBlue;
            this.btnSearch.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.Location = new System.Drawing.Point(2579, 27);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(385, 97);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Søk";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(2862, -689);
            this.textBox8.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(1602, 57);
            this.textBox8.TabIndex = 3;
            // 
            // txtFornavn
            // 
            this.txtFornavn.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFornavn.Location = new System.Drawing.Point(344, 525);
            this.txtFornavn.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtFornavn.Name = "txtFornavn";
            this.txtFornavn.Size = new System.Drawing.Size(636, 57);
            this.txtFornavn.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Crimson;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnDelete.Location = new System.Drawing.Point(378, 1179);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(297, 150);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "Slett";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Orange;
            this.btnCancel.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCancel.Location = new System.Drawing.Point(689, 1179);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(297, 150);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Avbryt";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtFylke
            // 
            this.txtFylke.BackColor = System.Drawing.SystemColors.ControlDark;
            this.txtFylke.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFylke.Location = new System.Drawing.Point(344, 1075);
            this.txtFylke.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.txtFylke.Name = "txtFylke";
            this.txtFylke.ReadOnly = true;
            this.txtFylke.Size = new System.Drawing.Size(636, 57);
            this.txtFylke.TabIndex = 3;
            this.txtFylke.Text = "0";
            // 
            // labelFylke
            // 
            this.labelFylke.AutoSize = true;
            this.labelFylke.Font = new System.Drawing.Font("Arial", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFylke.Location = new System.Drawing.Point(21, 1082);
            this.labelFylke.Margin = new System.Windows.Forms.Padding(7, 0, 7, 0);
            this.labelFylke.Name = "labelFylke";
            this.labelFylke.Size = new System.Drawing.Size(138, 50);
            this.labelFylke.TabIndex = 2;
            this.labelFylke.Text = "Fylke:";
            // 
            // labelFylkePost
            // 
            this.labelFylkePost.BackColor = System.Drawing.Color.Yellow;
            this.labelFylkePost.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFylkePost.Location = new System.Drawing.Point(700, 290);
            this.labelFylkePost.Name = "labelFylkePost";
            this.labelFylkePost.Size = new System.Drawing.Size(280, 221);
            this.labelFylkePost.TabIndex = 5;
            this.labelFylkePost.Text = "Legg til Fylke og Postnummer";
            this.labelFylkePost.UseVisualStyleBackColor = false;
            this.labelFylkePost.Click += new System.EventHandler(this.labelFylkePost_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2992, 1401);
            this.Controls.Add(this.labelFylkePost);
            this.Controls.Add(this.logoPic);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtAlder);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtKjønn);
            this.Controls.Add(this.txtFylke);
            this.Controls.Add(this.txtAdresse);
            this.Controls.Add(this.txtFornavn);
            this.Controls.Add(this.txtEtternavn);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.labelAlder);
            this.Controls.Add(this.labelTelefon);
            this.Controls.Add(this.labelKjønn);
            this.Controls.Add(this.labelFylke);
            this.Controls.Add(this.labelPostnummer);
            this.Controls.Add(this.labelAdresse);
            this.Controls.Add(this.labelEtternavn);
            this.Controls.Add(this.labelFornavn);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvStudent);
            this.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.Name = "Form1";
            this.Text = "StudentDB";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.Label labelFornavn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.PictureBox logoPic;
        private System.Windows.Forms.TextBox txtEtternavn;
        private System.Windows.Forms.TextBox txtAdresse;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.TextBox txtKjønn;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAlder;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelEtternavn;
        private System.Windows.Forms.Label labelAdresse;
        private System.Windows.Forms.Label labelPostnummer;
        private System.Windows.Forms.Label labelKjønn;
        private System.Windows.Forms.Label labelTelefon;
        private System.Windows.Forms.Label labelAlder;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox txtFornavn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtFylke;
        private System.Windows.Forms.Label labelFylke;
        private System.Windows.Forms.Button labelFylkePost;
    }
}

