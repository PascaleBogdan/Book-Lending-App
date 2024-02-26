namespace Biblioteca
{
    partial class PersoaneForm
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
            this.components = new System.ComponentModel.Container();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.btnStergere = new System.Windows.Forms.Button();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdresa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNrTelefon = new System.Windows.Forms.TextBox();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProiectDataSet = new Biblioteca.DBProiectDataSet();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrTelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.persoaneTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.PersoaneTableAdapter();
            this.lblOp = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdPersoana = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdaugare
            // 
            this.btnAdaugare.Location = new System.Drawing.Point(38, 9);
            this.btnAdaugare.Margin = new System.Windows.Forms.Padding(2);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(72, 26);
            this.btnAdaugare.TabIndex = 1;
            this.btnAdaugare.Text = "Adăugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Location = new System.Drawing.Point(114, 9);
            this.btnModificare.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(72, 26);
            this.btnModificare.TabIndex = 2;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // btnStergere
            // 
            this.btnStergere.Location = new System.Drawing.Point(190, 9);
            this.btnStergere.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergere.Name = "btnStergere";
            this.btnStergere.Size = new System.Drawing.Size(72, 26);
            this.btnStergere.TabIndex = 3;
            this.btnStergere.Text = "Ștergere";
            this.btnStergere.UseVisualStyleBackColor = true;
            this.btnStergere.Click += new System.EventHandler(this.btnStergere_Click);
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(561, 22);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(72, 26);
            this.btnConfirmare.TabIndex = 4;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(637, 22);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(72, 26);
            this.btnRenuntare.TabIndex = 5;
            this.btnRenuntare.Text = "Renunțare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(561, 58);
            this.txtNume.Margin = new System.Windows.Forms.Padding(2);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(265, 20);
            this.txtNume.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(508, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nume";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 90);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Adresa";
            // 
            // txtAdresa
            // 
            this.txtAdresa.Location = new System.Drawing.Point(561, 90);
            this.txtAdresa.Margin = new System.Windows.Forms.Padding(2);
            this.txtAdresa.Name = "txtAdresa";
            this.txtAdresa.Size = new System.Drawing.Size(112, 20);
            this.txtAdresa.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(503, 125);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "NrTelefon";
            // 
            // txtNrTelefon
            // 
            this.txtNrTelefon.Location = new System.Drawing.Point(561, 125);
            this.txtNrTelefon.Margin = new System.Windows.Forms.Padding(2);
            this.txtNrTelefon.Name = "txtNrTelefon";
            this.txtNrTelefon.Size = new System.Drawing.Size(112, 20);
            this.txtNrTelefon.TabIndex = 16;
            this.txtNrTelefon.Leave += new System.EventHandler(this.txtNrTelefon_Leave);
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.Location = new System.Drawing.Point(561, 166);
            this.txtSpImagine.Margin = new System.Windows.Forms.Padding(2);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.Size = new System.Drawing.Size(112, 20);
            this.txtSpImagine.TabIndex = 17;
            this.txtSpImagine.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.txtSpImagine_MouseDoubleClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(504, 169);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Imagine";
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.persoaneBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(692, 82);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(184, 204);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // persoaneBindingSource
            // 
            this.persoaneBindingSource.DataMember = "Persoane";
            this.persoaneBindingSource.DataSource = this.dBProiectDataSet;
            // 
            // dBProiectDataSet
            // 
            this.dBProiectDataSet.DataSetName = "DBProiectDataSet";
            this.dBProiectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPersoanaDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.adresaDataGridViewTextBoxColumn,
            this.nrTelefonDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.persoaneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 58);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(442, 262);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idPersoanaDataGridViewTextBoxColumn
            // 
            this.idPersoanaDataGridViewTextBoxColumn.DataPropertyName = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.HeaderText = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPersoanaDataGridViewTextBoxColumn.Name = "idPersoanaDataGridViewTextBoxColumn";
            this.idPersoanaDataGridViewTextBoxColumn.Visible = false;
            this.idPersoanaDataGridViewTextBoxColumn.Width = 127;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.Width = 60;
            // 
            // adresaDataGridViewTextBoxColumn
            // 
            this.adresaDataGridViewTextBoxColumn.DataPropertyName = "Adresa";
            this.adresaDataGridViewTextBoxColumn.HeaderText = "Adresa";
            this.adresaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.adresaDataGridViewTextBoxColumn.Name = "adresaDataGridViewTextBoxColumn";
            this.adresaDataGridViewTextBoxColumn.Width = 65;
            // 
            // nrTelefonDataGridViewTextBoxColumn
            // 
            this.nrTelefonDataGridViewTextBoxColumn.DataPropertyName = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.HeaderText = "NrTelefon";
            this.nrTelefonDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrTelefonDataGridViewTextBoxColumn.Name = "nrTelefonDataGridViewTextBoxColumn";
            this.nrTelefonDataGridViewTextBoxColumn.Width = 79;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Width = 82;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(522, 22);
            this.lblOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(0, 13);
            this.lblOp.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 199);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "ID";
            // 
            // txtIdPersoana
            // 
            this.txtIdPersoana.Location = new System.Drawing.Point(561, 196);
            this.txtIdPersoana.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdPersoana.Name = "txtIdPersoana";
            this.txtIdPersoana.Size = new System.Drawing.Size(112, 20);
            this.txtIdPersoana.TabIndex = 22;
            this.txtIdPersoana.TextChanged += new System.EventHandler(this.txtIdPersoana_TextChanged);
            // 
            // PersoaneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 354);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtIdPersoana);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtSpImagine);
            this.Controls.Add(this.txtNrTelefon);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAdresa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNume);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.btnStergere);
            this.Controls.Add(this.btnModificare);
            this.Controls.Add(this.btnAdaugare);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "PersoaneForm";
            this.Text = "PersoaneForm";
            this.Load += new System.EventHandler(this.PersoaneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Button btnStergere;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdresa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNrTelefon;
        private System.Windows.Forms.TextBox txtSpImagine;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBProiectDataSet dBProiectDataSet;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private DBProiectDataSetTableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.DataGridViewComboBoxColumn localitateDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdPersoana;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrTelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
    }
}