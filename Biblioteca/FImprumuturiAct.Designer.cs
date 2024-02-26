namespace Biblioteca
{
    partial class FImprumuturiAct
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblOp = new System.Windows.Forms.Label();
            this.btnConfirmare = new System.Windows.Forms.Button();
            this.cmbPersoana = new System.Windows.Forms.ComboBox();
            this.persoaneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProiectDataSet = new Biblioteca.DBProiectDataSet();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.cartiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nRInventarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrZileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumutContinutManevraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cartiTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.CartiTableAdapter();
            this.persoaneTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.PersoaneTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutContinutManevraBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Persoana";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Data";
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lblOp.Location = new System.Drawing.Point(480, 12);
            this.lblOp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(139, 24);
            this.lblOp.TabIndex = 24;
            this.lblOp.Text = "Imprumut nou";
            // 
            // btnConfirmare
            // 
            this.btnConfirmare.Location = new System.Drawing.Point(11, 95);
            this.btnConfirmare.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfirmare.Name = "btnConfirmare";
            this.btnConfirmare.Size = new System.Drawing.Size(84, 30);
            this.btnConfirmare.TabIndex = 23;
            this.btnConfirmare.Text = "Confirmare";
            this.btnConfirmare.UseVisualStyleBackColor = true;
            this.btnConfirmare.Click += new System.EventHandler(this.btnConfirmare_Click);
            // 
            // cmbPersoana
            // 
            this.cmbPersoana.DataSource = this.persoaneBindingSource;
            this.cmbPersoana.DisplayMember = "Nume";
            this.cmbPersoana.FormattingEnabled = true;
            this.cmbPersoana.Location = new System.Drawing.Point(61, 63);
            this.cmbPersoana.Margin = new System.Windows.Forms.Padding(2);
            this.cmbPersoana.Name = "cmbPersoana";
            this.cmbPersoana.Size = new System.Drawing.Size(135, 21);
            this.cmbPersoana.TabIndex = 22;
            this.cmbPersoana.ValueMember = "IdPersoana";
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(55, 20);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(135, 20);
            this.dateTimePicker1.TabIndex = 21;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nrcDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.nRInventarDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.nrZileDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn,
            this.idCarteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imprumutContinutManevraBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 129);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(611, 287);
            this.dataGridView1.TabIndex = 29;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.dataGridView1_DataError);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.Width = 49;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.DataSource = this.cartiBindingSource;
            this.titluDataGridViewTextBoxColumn.DisplayMember = "Titlu";
            this.titluDataGridViewTextBoxColumn.DisplayStyleForCurrentCellOnly = true;
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.titluDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.titluDataGridViewTextBoxColumn.Width = 52;
            // 
            // cartiBindingSource
            // 
            this.cartiBindingSource.DataMember = "Carti";
            this.cartiBindingSource.DataSource = this.dBProiectDataSet;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.Width = 57;
            // 
            // nRInventarDataGridViewTextBoxColumn
            // 
            this.nRInventarDataGridViewTextBoxColumn.DataPropertyName = "NRInventar";
            this.nRInventarDataGridViewTextBoxColumn.HeaderText = "NRInventar";
            this.nRInventarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nRInventarDataGridViewTextBoxColumn.Name = "nRInventarDataGridViewTextBoxColumn";
            this.nRInventarDataGridViewTextBoxColumn.Width = 87;
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            this.tarifZiDataGridViewTextBoxColumn.Width = 62;
            // 
            // nrZileDataGridViewTextBoxColumn
            // 
            this.nrZileDataGridViewTextBoxColumn.DataPropertyName = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.HeaderText = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrZileDataGridViewTextBoxColumn.Name = "nrZileDataGridViewTextBoxColumn";
            this.nrZileDataGridViewTextBoxColumn.Width = 60;
            // 
            // valoareDataGridViewTextBoxColumn
            // 
            this.valoareDataGridViewTextBoxColumn.DataPropertyName = "Valoare";
            this.valoareDataGridViewTextBoxColumn.HeaderText = "Valoare";
            this.valoareDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.valoareDataGridViewTextBoxColumn.Name = "valoareDataGridViewTextBoxColumn";
            this.valoareDataGridViewTextBoxColumn.ReadOnly = true;
            this.valoareDataGridViewTextBoxColumn.Width = 68;
            // 
            // idCarteDataGridViewTextBoxColumn
            // 
            this.idCarteDataGridViewTextBoxColumn.DataPropertyName = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.HeaderText = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCarteDataGridViewTextBoxColumn.Name = "idCarteDataGridViewTextBoxColumn";
            this.idCarteDataGridViewTextBoxColumn.Width = 66;
            // 
            // imprumutContinutManevraBindingSource
            // 
            this.imprumutContinutManevraBindingSource.DataMember = "ImprumutContinutManevra";
            this.imprumutContinutManevraBindingSource.DataSource = this.dBProiectDataSet;
            this.imprumutContinutManevraBindingSource.CurrentChanged += new System.EventHandler(this.imprumutContinutManevraBindingSource_CurrentChanged);
            // 
            // cartiTableAdapter
            // 
            this.cartiTableAdapter.ClearBeforeFill = true;
            // 
            // persoaneTableAdapter
            // 
            this.persoaneTableAdapter.ClearBeforeFill = true;
            // 
            // FImprumuturiAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 424);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.btnConfirmare);
            this.Controls.Add(this.cmbPersoana);
            this.Controls.Add(this.dateTimePicker1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FImprumuturiAct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FImprumuturiAct";
            this.Load += new System.EventHandler(this.FImprumuturiAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.persoaneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cartiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumutContinutManevraBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Button btnConfirmare;
        private System.Windows.Forms.ComboBox cmbPersoana;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource imprumutContinutManevraBindingSource;
        private DBProiectDataSet dBProiectDataSet;
        private System.Windows.Forms.BindingSource cartiBindingSource;
        private DBProiectDataSetTableAdapters.CartiTableAdapter cartiTableAdapter;
        private System.Windows.Forms.BindingSource persoaneBindingSource;
        private DBProiectDataSetTableAdapters.PersoaneTableAdapter persoaneTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nRInventarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarteDataGridViewTextBoxColumn;
    }
}