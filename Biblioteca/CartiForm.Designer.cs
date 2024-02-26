namespace Biblioteca
{
    partial class CartiForm
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
            this.btnActualizare = new System.Windows.Forms.Button();
            this.btnSalvare = new System.Windows.Forms.Button();
            this.btnRenuntare = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrInventarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.spImagineDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProiectDataSet = new Biblioteca.DBProiectDataSet();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cartiTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.CartiTableAdapter();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSpImagine = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnActualizare
            // 
            this.btnActualizare.Location = new System.Drawing.Point(29, 93);
            this.btnActualizare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnActualizare.Name = "btnActualizare";
            this.btnActualizare.Size = new System.Drawing.Size(108, 31);
            this.btnActualizare.TabIndex = 1;
            this.btnActualizare.Text = "Actualizare";
            this.btnActualizare.UseVisualStyleBackColor = true;
            this.btnActualizare.Click += new System.EventHandler(this.btnActualizare_Click);
            // 
            // btnSalvare
            // 
            this.btnSalvare.Location = new System.Drawing.Point(170, 93);
            this.btnSalvare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSalvare.Name = "btnSalvare";
            this.btnSalvare.Size = new System.Drawing.Size(103, 31);
            this.btnSalvare.TabIndex = 1;
            this.btnSalvare.Text = "Salvare";
            this.btnSalvare.UseVisualStyleBackColor = true;
            this.btnSalvare.Click += new System.EventHandler(this.btnSalvare_Click);
            // 
            // btnRenuntare
            // 
            this.btnRenuntare.Location = new System.Drawing.Point(308, 93);
            this.btnRenuntare.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRenuntare.Name = "btnRenuntare";
            this.btnRenuntare.Size = new System.Drawing.Size(101, 31);
            this.btnRenuntare.TabIndex = 1;
            this.btnRenuntare.Text = "Renuntare";
            this.btnRenuntare.UseVisualStyleBackColor = true;
            this.btnRenuntare.Click += new System.EventHandler(this.btnRenuntare_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCarteDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.nrInventarDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.spImagineDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.cartiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(29, 157);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(651, 251);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // idCarteDataGridViewTextBoxColumn
            // 
            this.idCarteDataGridViewTextBoxColumn.DataPropertyName = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.HeaderText = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCarteDataGridViewTextBoxColumn.Name = "idCarteDataGridViewTextBoxColumn";
            this.idCarteDataGridViewTextBoxColumn.Visible = false;
            this.idCarteDataGridViewTextBoxColumn.Width = 98;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Width = 52;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 57;
            // 
            // nrInventarDataGridViewTextBoxColumn
            // 
            this.nrInventarDataGridViewTextBoxColumn.DataPropertyName = "NrInventar";
            this.nrInventarDataGridViewTextBoxColumn.HeaderText = "NrInventar";
            this.nrInventarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrInventarDataGridViewTextBoxColumn.Name = "nrInventarDataGridViewTextBoxColumn";
            this.nrInventarDataGridViewTextBoxColumn.Width = 82;
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            this.tarifZiDataGridViewTextBoxColumn.Width = 62;
            // 
            // spImagineDataGridViewTextBoxColumn
            // 
            this.spImagineDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.spImagineDataGridViewTextBoxColumn.DataPropertyName = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.HeaderText = "SpImagine";
            this.spImagineDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.spImagineDataGridViewTextBoxColumn.Name = "spImagineDataGridViewTextBoxColumn";
            this.spImagineDataGridViewTextBoxColumn.Width = 122;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.dBProiectDataSet;
            // 
            // dBProiectDataSet
            // 
            this.dBProiectDataSet.DataSetName = "DBProiectDataSet";
            this.dBProiectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pictureBox1
            // 
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("ImageLocation", this.cartiBindingSource, "SpImagine", true));
            this.pictureBox1.Location = new System.Drawing.Point(727, 157);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSpImagine
            // 
            this.txtSpImagine.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cartiBindingSource, "SpImagine", true));
            this.txtSpImagine.Location = new System.Drawing.Point(727, 115);
            this.txtSpImagine.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtSpImagine.Name = "txtSpImagine";
            this.txtSpImagine.ReadOnly = true;
            this.txtSpImagine.Size = new System.Drawing.Size(287, 20);
            this.txtSpImagine.TabIndex = 4;
            // 
            // CartiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 529);
            this.Controls.Add(this.txtSpImagine);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRenuntare);
            this.Controls.Add(this.btnSalvare);
            this.Controls.Add(this.btnActualizare);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CartiForm";
            this.Text = "CartiForm";
            this.Load += new System.EventHandler(this.CartiForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnActualizare;
        private System.Windows.Forms.Button btnSalvare;
        private System.Windows.Forms.Button btnRenuntare;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DBProiectDataSet dBProiectDataSet;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private DBProiectDataSetTableAdapters.CartiTableAdapter cartiTableAdapter;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrInventarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn spImagineDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSpImagine;
    }
}