namespace Biblioteca
{
    partial class FImprumuturi
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
            this.btnStergeImprumut = new System.Windows.Forms.Button();
            this.btnModificaImprumut = new System.Windows.Forms.Button();
            this.btnImprumutNou = new System.Windows.Forms.Button();
            this.imprumuturiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dBProiectDataSet = new Biblioteca.DBProiectDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idImprumutDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.titluDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.autorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrInventarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCarteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarifZiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nrZileDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.valoareDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumuturiContinutBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idImprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataImprumutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idPersoanaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.imprumuturiTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.ImprumuturiTableAdapter();
            this.imprumuturiContinutTableAdapter = new Biblioteca.DBProiectDataSetTableAdapters.ImprumuturiContinutTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiContinutBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnStergeImprumut
            // 
            this.btnStergeImprumut.Location = new System.Drawing.Point(535, 198);
            this.btnStergeImprumut.Margin = new System.Windows.Forms.Padding(2);
            this.btnStergeImprumut.Name = "btnStergeImprumut";
            this.btnStergeImprumut.Size = new System.Drawing.Size(111, 22);
            this.btnStergeImprumut.TabIndex = 11;
            this.btnStergeImprumut.Text = "Sterge Imprumut";
            this.btnStergeImprumut.UseVisualStyleBackColor = true;
            this.btnStergeImprumut.Click += new System.EventHandler(this.btnStergeImprumut_Click);
            // 
            // btnModificaImprumut
            // 
            this.btnModificaImprumut.Location = new System.Drawing.Point(535, 151);
            this.btnModificaImprumut.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificaImprumut.Name = "btnModificaImprumut";
            this.btnModificaImprumut.Size = new System.Drawing.Size(111, 22);
            this.btnModificaImprumut.TabIndex = 10;
            this.btnModificaImprumut.Text = "Modifica Imprumut";
            this.btnModificaImprumut.UseVisualStyleBackColor = true;
            this.btnModificaImprumut.Click += new System.EventHandler(this.btnModificaImprumut_Click);
            // 
            // btnImprumutNou
            // 
            this.btnImprumutNou.Location = new System.Drawing.Point(535, 109);
            this.btnImprumutNou.Margin = new System.Windows.Forms.Padding(2);
            this.btnImprumutNou.Name = "btnImprumutNou";
            this.btnImprumutNou.Size = new System.Drawing.Size(111, 22);
            this.btnImprumutNou.TabIndex = 9;
            this.btnImprumutNou.Text = "Imprumut Nou";
            this.btnImprumutNou.UseVisualStyleBackColor = true;
            this.btnImprumutNou.Click += new System.EventHandler(this.btnImprumutNou_Click);
            // 
            // imprumuturiBindingSource
            // 
            this.imprumuturiBindingSource.DataMember = "Imprumuturi";
            this.imprumuturiBindingSource.DataSource = this.dBProiectDataSet;
            this.imprumuturiBindingSource.PositionChanged += new System.EventHandler(this.imprumuturiBindingSource_PositionChanged);
            // 
            // dBProiectDataSet
            // 
            this.dBProiectDataSet.DataSetName = "DBProiectDataSet";
            this.dBProiectDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idImprumutDataGridViewTextBoxColumn1,
            this.nrcDataGridViewTextBoxColumn,
            this.titluDataGridViewTextBoxColumn,
            this.autorDataGridViewTextBoxColumn,
            this.nrInventarDataGridViewTextBoxColumn,
            this.idCarteDataGridViewTextBoxColumn,
            this.tarifZiDataGridViewTextBoxColumn,
            this.nrZileDataGridViewTextBoxColumn,
            this.valoareDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.imprumuturiContinutBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(8, 270);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 28;
            this.dataGridView2.Size = new System.Drawing.Size(735, 160);
            this.dataGridView2.TabIndex = 7;
            // 
            // idImprumutDataGridViewTextBoxColumn1
            // 
            this.idImprumutDataGridViewTextBoxColumn1.DataPropertyName = "IdImprumut";
            this.idImprumutDataGridViewTextBoxColumn1.HeaderText = "IdImprumut";
            this.idImprumutDataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.idImprumutDataGridViewTextBoxColumn1.Name = "idImprumutDataGridViewTextBoxColumn1";
            this.idImprumutDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idImprumutDataGridViewTextBoxColumn1.Visible = false;
            this.idImprumutDataGridViewTextBoxColumn1.Width = 127;
            // 
            // nrcDataGridViewTextBoxColumn
            // 
            this.nrcDataGridViewTextBoxColumn.DataPropertyName = "Nrc";
            this.nrcDataGridViewTextBoxColumn.HeaderText = "Nrc";
            this.nrcDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrcDataGridViewTextBoxColumn.Name = "nrcDataGridViewTextBoxColumn";
            this.nrcDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrcDataGridViewTextBoxColumn.Width = 49;
            // 
            // titluDataGridViewTextBoxColumn
            // 
            this.titluDataGridViewTextBoxColumn.DataPropertyName = "Titlu";
            this.titluDataGridViewTextBoxColumn.HeaderText = "Titlu";
            this.titluDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.titluDataGridViewTextBoxColumn.Name = "titluDataGridViewTextBoxColumn";
            this.titluDataGridViewTextBoxColumn.ReadOnly = true;
            this.titluDataGridViewTextBoxColumn.Width = 52;
            // 
            // autorDataGridViewTextBoxColumn
            // 
            this.autorDataGridViewTextBoxColumn.DataPropertyName = "Autor";
            this.autorDataGridViewTextBoxColumn.HeaderText = "Autor";
            this.autorDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.autorDataGridViewTextBoxColumn.Name = "autorDataGridViewTextBoxColumn";
            this.autorDataGridViewTextBoxColumn.ReadOnly = true;
            this.autorDataGridViewTextBoxColumn.Width = 57;
            // 
            // nrInventarDataGridViewTextBoxColumn
            // 
            this.nrInventarDataGridViewTextBoxColumn.DataPropertyName = "NrInventar";
            this.nrInventarDataGridViewTextBoxColumn.HeaderText = "NrInventar";
            this.nrInventarDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrInventarDataGridViewTextBoxColumn.Name = "nrInventarDataGridViewTextBoxColumn";
            this.nrInventarDataGridViewTextBoxColumn.ReadOnly = true;
            this.nrInventarDataGridViewTextBoxColumn.Width = 82;
            // 
            // idCarteDataGridViewTextBoxColumn
            // 
            this.idCarteDataGridViewTextBoxColumn.DataPropertyName = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.HeaderText = "IdCarte";
            this.idCarteDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idCarteDataGridViewTextBoxColumn.Name = "idCarteDataGridViewTextBoxColumn";
            this.idCarteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idCarteDataGridViewTextBoxColumn.Visible = false;
            this.idCarteDataGridViewTextBoxColumn.Width = 98;
            // 
            // tarifZiDataGridViewTextBoxColumn
            // 
            this.tarifZiDataGridViewTextBoxColumn.DataPropertyName = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.HeaderText = "TarifZi";
            this.tarifZiDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.tarifZiDataGridViewTextBoxColumn.Name = "tarifZiDataGridViewTextBoxColumn";
            this.tarifZiDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarifZiDataGridViewTextBoxColumn.Width = 62;
            // 
            // nrZileDataGridViewTextBoxColumn
            // 
            this.nrZileDataGridViewTextBoxColumn.DataPropertyName = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.HeaderText = "NrZile";
            this.nrZileDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nrZileDataGridViewTextBoxColumn.Name = "nrZileDataGridViewTextBoxColumn";
            this.nrZileDataGridViewTextBoxColumn.ReadOnly = true;
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
            // imprumuturiContinutBindingSource
            // 
            this.imprumuturiContinutBindingSource.DataMember = "ImprumuturiContinut";
            this.imprumuturiContinutBindingSource.DataSource = this.dBProiectDataSet;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idImprumutDataGridViewTextBoxColumn,
            this.dataImprumutDataGridViewTextBoxColumn,
            this.numeDataGridViewTextBoxColumn,
            this.idPersoanaDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.imprumuturiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(8, 44);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(494, 215);
            this.dataGridView1.TabIndex = 6;
            // 
            // idImprumutDataGridViewTextBoxColumn
            // 
            this.idImprumutDataGridViewTextBoxColumn.DataPropertyName = "IdImprumut";
            this.idImprumutDataGridViewTextBoxColumn.HeaderText = "IdImprumut";
            this.idImprumutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idImprumutDataGridViewTextBoxColumn.Name = "idImprumutDataGridViewTextBoxColumn";
            this.idImprumutDataGridViewTextBoxColumn.ReadOnly = true;
            this.idImprumutDataGridViewTextBoxColumn.Visible = false;
            this.idImprumutDataGridViewTextBoxColumn.Width = 127;
            // 
            // dataImprumutDataGridViewTextBoxColumn
            // 
            this.dataImprumutDataGridViewTextBoxColumn.DataPropertyName = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.HeaderText = "DataImprumut";
            this.dataImprumutDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dataImprumutDataGridViewTextBoxColumn.Name = "dataImprumutDataGridViewTextBoxColumn";
            this.dataImprumutDataGridViewTextBoxColumn.ReadOnly = true;
            this.dataImprumutDataGridViewTextBoxColumn.Width = 98;
            // 
            // numeDataGridViewTextBoxColumn
            // 
            this.numeDataGridViewTextBoxColumn.DataPropertyName = "Nume";
            this.numeDataGridViewTextBoxColumn.HeaderText = "Nume";
            this.numeDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.numeDataGridViewTextBoxColumn.Name = "numeDataGridViewTextBoxColumn";
            this.numeDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeDataGridViewTextBoxColumn.Width = 60;
            // 
            // idPersoanaDataGridViewTextBoxColumn
            // 
            this.idPersoanaDataGridViewTextBoxColumn.DataPropertyName = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.HeaderText = "IdPersoana";
            this.idPersoanaDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idPersoanaDataGridViewTextBoxColumn.Name = "idPersoanaDataGridViewTextBoxColumn";
            this.idPersoanaDataGridViewTextBoxColumn.ReadOnly = true;
            this.idPersoanaDataGridViewTextBoxColumn.Visible = false;
            this.idPersoanaDataGridViewTextBoxColumn.Width = 127;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 56;
            // 
            // imprumuturiTableAdapter
            // 
            this.imprumuturiTableAdapter.ClearBeforeFill = true;
            // 
            // imprumuturiContinutTableAdapter
            // 
            this.imprumuturiContinutTableAdapter.ClearBeforeFill = true;
            // 
            // FImprumuturi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(785, 452);
            this.Controls.Add(this.btnStergeImprumut);
            this.Controls.Add(this.btnModificaImprumut);
            this.Controls.Add(this.btnImprumutNou);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FImprumuturi";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FImprumuturi";
            this.Load += new System.EventHandler(this.FImprumuturi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProiectDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imprumuturiContinutBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnStergeImprumut;
        private System.Windows.Forms.Button btnModificaImprumut;
        private System.Windows.Forms.Button btnImprumutNou;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DBProiectDataSet dBProiectDataSet;
        private System.Windows.Forms.BindingSource imprumuturiBindingSource;
        private DBProiectDataSetTableAdapters.ImprumuturiTableAdapter imprumuturiTableAdapter;
        private System.Windows.Forms.BindingSource imprumuturiContinutBindingSource;
        private DBProiectDataSetTableAdapters.ImprumuturiContinutTableAdapter imprumuturiContinutTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImprumutDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn titluDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn autorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrInventarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCarteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarifZiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nrZileDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn valoareDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idImprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataImprumutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idPersoanaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
    }
}