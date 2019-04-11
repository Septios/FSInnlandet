namespace studentCRUD
{
    partial class Form2
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
            this.txtFylke = new System.Windows.Forms.TextBox();
            this.txtPostnummer = new System.Windows.Forms.TextBox();
            this.txtPoststed = new System.Windows.Forms.TextBox();
            this.labelPostnummer = new System.Windows.Forms.Label();
            this.labelPoststed = new System.Windows.Forms.Label();
            this.btnCancelPost = new System.Windows.Forms.Button();
            this.dgvPostnummer = new System.Windows.Forms.DataGridView();
            this.dgvFylke = new System.Windows.Forms.DataGridView();
            this.txtFylkeID = new System.Windows.Forms.TextBox();
            this.btnSavePost = new System.Windows.Forms.Button();
            this.btnSaveFylke = new System.Windows.Forms.Button();
            this.btnCancelFylke = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostnummer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFylke)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFylke
            // 
            this.txtFylke.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFylke.Location = new System.Drawing.Point(1459, 385);
            this.txtFylke.Name = "txtFylke";
            this.txtFylke.Size = new System.Drawing.Size(440, 58);
            this.txtFylke.TabIndex = 0;
            // 
            // txtPostnummer
            // 
            this.txtPostnummer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPostnummer.Location = new System.Drawing.Point(332, 165);
            this.txtPostnummer.Name = "txtPostnummer";
            this.txtPostnummer.Size = new System.Drawing.Size(440, 58);
            this.txtPostnummer.TabIndex = 0;
            // 
            // txtPoststed
            // 
            this.txtPoststed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoststed.Location = new System.Drawing.Point(332, 311);
            this.txtPoststed.Name = "txtPoststed";
            this.txtPoststed.Size = new System.Drawing.Size(440, 58);
            this.txtPoststed.TabIndex = 0;
            // 
            // labelPostnummer
            // 
            this.labelPostnummer.AutoSize = true;
            this.labelPostnummer.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPostnummer.Location = new System.Drawing.Point(23, 168);
            this.labelPostnummer.Name = "labelPostnummer";
            this.labelPostnummer.Size = new System.Drawing.Size(272, 50);
            this.labelPostnummer.TabIndex = 1;
            this.labelPostnummer.Text = "Postnummer";
            // 
            // labelPoststed
            // 
            this.labelPoststed.AutoSize = true;
            this.labelPoststed.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPoststed.Location = new System.Drawing.Point(23, 311);
            this.labelPoststed.Name = "labelPoststed";
            this.labelPoststed.Size = new System.Drawing.Size(191, 50);
            this.labelPoststed.TabIndex = 1;
            this.labelPoststed.Text = "Poststed";
            // 
            // btnCancelPost
            // 
            this.btnCancelPost.BackColor = System.Drawing.Color.Orange;
            this.btnCancelPost.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelPost.Location = new System.Drawing.Point(959, 354);
            this.btnCancelPost.Name = "btnCancelPost";
            this.btnCancelPost.Size = new System.Drawing.Size(267, 155);
            this.btnCancelPost.TabIndex = 2;
            this.btnCancelPost.Text = "Cancel";
            this.btnCancelPost.UseVisualStyleBackColor = false;
            // 
            // dgvPostnummer
            // 
            this.dgvPostnummer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPostnummer.Location = new System.Drawing.Point(12, 544);
            this.dgvPostnummer.Name = "dgvPostnummer";
            this.dgvPostnummer.RowTemplate.Height = 46;
            this.dgvPostnummer.Size = new System.Drawing.Size(1214, 734);
            this.dgvPostnummer.TabIndex = 3;
            this.dgvPostnummer.DoubleClick += new System.EventHandler(this.dgvPostnummer_DoubleClick);
            // 
            // dgvFylke
            // 
            this.dgvFylke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFylke.Location = new System.Drawing.Point(1318, 544);
            this.dgvFylke.Name = "dgvFylke";
            this.dgvFylke.RowTemplate.Height = 46;
            this.dgvFylke.Size = new System.Drawing.Size(1205, 734);
            this.dgvFylke.TabIndex = 3;
            this.dgvFylke.DoubleClick += new System.EventHandler(this.dgvFylke_DoubleClick);
            // 
            // txtFylkeID
            // 
            this.txtFylkeID.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFylkeID.Location = new System.Drawing.Point(332, 453);
            this.txtFylkeID.Name = "txtFylkeID";
            this.txtFylkeID.Size = new System.Drawing.Size(440, 58);
            this.txtFylkeID.TabIndex = 0;
            // 
            // btnSavePost
            // 
            this.btnSavePost.BackColor = System.Drawing.Color.Green;
            this.btnSavePost.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSavePost.Location = new System.Drawing.Point(959, 165);
            this.btnSavePost.Name = "btnSavePost";
            this.btnSavePost.Size = new System.Drawing.Size(267, 155);
            this.btnSavePost.TabIndex = 2;
            this.btnSavePost.Text = "Save";
            this.btnSavePost.UseVisualStyleBackColor = false;
            this.btnSavePost.Click += new System.EventHandler(this.btnSavePost_Click);
            // 
            // btnSaveFylke
            // 
            this.btnSaveFylke.BackColor = System.Drawing.Color.Green;
            this.btnSaveFylke.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFylke.Location = new System.Drawing.Point(1959, 282);
            this.btnSaveFylke.Name = "btnSaveFylke";
            this.btnSaveFylke.Size = new System.Drawing.Size(267, 155);
            this.btnSaveFylke.TabIndex = 2;
            this.btnSaveFylke.Text = "Save";
            this.btnSaveFylke.UseVisualStyleBackColor = false;
            this.btnSaveFylke.Click += new System.EventHandler(this.btnSaveFylke_Click);
            // 
            // btnCancelFylke
            // 
            this.btnCancelFylke.BackColor = System.Drawing.Color.Orange;
            this.btnCancelFylke.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelFylke.Location = new System.Drawing.Point(2256, 282);
            this.btnCancelFylke.Name = "btnCancelFylke";
            this.btnCancelFylke.Size = new System.Drawing.Size(267, 155);
            this.btnCancelFylke.TabIndex = 2;
            this.btnCancelFylke.Text = "Cancel";
            this.btnCancelFylke.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1316, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 50);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fylke";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 50);
            this.label2.TabIndex = 1;
            this.label2.Text = "FylkeID";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo.Location = new System.Drawing.Point(1316, 484);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(735, 50);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "Listen under viser ID\'en til hvert fylke";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2535, 1290);
            this.Controls.Add(this.dgvFylke);
            this.Controls.Add(this.dgvPostnummer);
            this.Controls.Add(this.btnSaveFylke);
            this.Controls.Add(this.btnSavePost);
            this.Controls.Add(this.btnCancelFylke);
            this.Controls.Add(this.btnCancelPost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPoststed);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPostnummer);
            this.Controls.Add(this.txtPoststed);
            this.Controls.Add(this.txtPostnummer);
            this.Controls.Add(this.txtFylkeID);
            this.Controls.Add(this.txtFylke);
            this.Margin = new System.Windows.Forms.Padding(7);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPostnummer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFylke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFylke;
        private System.Windows.Forms.TextBox txtPostnummer;
        private System.Windows.Forms.TextBox txtPoststed;
        private System.Windows.Forms.Label labelPostnummer;
        private System.Windows.Forms.Label labelPoststed;
        private System.Windows.Forms.Button btnCancelPost;
        private System.Windows.Forms.DataGridView dgvPostnummer;
        private System.Windows.Forms.DataGridView dgvFylke;
        private System.Windows.Forms.TextBox txtFylkeID;
        private System.Windows.Forms.Button btnSavePost;
        private System.Windows.Forms.Button btnSaveFylke;
        private System.Windows.Forms.Button btnCancelFylke;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelInfo;
    }
}