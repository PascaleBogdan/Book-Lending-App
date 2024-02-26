namespace Biblioteca
{
    partial class Meniu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cartiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.persoaneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imprumuturiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cartiToolStripMenuItem,
            this.persoaneToolStripMenuItem,
            this.imprumuturiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cartiToolStripMenuItem
            // 
            this.cartiToolStripMenuItem.Name = "cartiToolStripMenuItem";
            this.cartiToolStripMenuItem.Size = new System.Drawing.Size(44, 22);
            this.cartiToolStripMenuItem.Text = "Carti";
            this.cartiToolStripMenuItem.Click += new System.EventHandler(this.cartiToolStripMenuItem_Click);
            // 
            // persoaneToolStripMenuItem
            // 
            this.persoaneToolStripMenuItem.Name = "persoaneToolStripMenuItem";
            this.persoaneToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.persoaneToolStripMenuItem.Text = "Persoane";
            this.persoaneToolStripMenuItem.Click += new System.EventHandler(this.persoaneToolStripMenuItem_Click);
            // 
            // imprumuturiToolStripMenuItem
            // 
            this.imprumuturiToolStripMenuItem.Name = "imprumuturiToolStripMenuItem";
            this.imprumuturiToolStripMenuItem.Size = new System.Drawing.Size(87, 22);
            this.imprumuturiToolStripMenuItem.Text = "Imprumuturi";
            this.imprumuturiToolStripMenuItem.Click += new System.EventHandler(this.imprumuturiToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(72, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(663, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Aplicatie pt. imprumutul cartilor dintr-o biblioteca";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.label1.Location = new System.Drawing.Point(260, 154);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Autor:Pascale Bogdan-Dumitru";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnLogout.Location = new System.Drawing.Point(383, 261);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(72, 29);
            this.btnLogout.TabIndex = 9;
            this.btnLogout.Text = "LogOut";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Meniu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(808, 355);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Meniu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Meniu";
            this.Load += new System.EventHandler(this.Meniu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem persoaneToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cartiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imprumuturiToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLogout;
    }
}