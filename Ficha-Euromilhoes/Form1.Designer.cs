﻿namespace Ficha_Euromilhoes
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNChaves = new System.Windows.Forms.TextBox();
            this.btnGerar = new System.Windows.Forms.Button();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChaves = new System.Windows.Forms.ComboBox();
            this.dgvChaves = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaves)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.RoyalBlue;
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(781, 82);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Impact", 40F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(716, 82);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gerador de Euromilhões";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel5);
            this.flowLayoutPanel2.Controls.Add(this.dgvChaves);
            this.flowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 82);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(781, 781);
            this.flowLayoutPanel2.TabIndex = 1;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.AutoSize = true;
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel5.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(676, 156);
            this.flowLayoutPanel5.TabIndex = 2;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.AutoSize = true;
            this.flowLayoutPanel3.Controls.Add(this.label2);
            this.flowLayoutPanel3.Controls.Add(this.txtNChaves);
            this.flowLayoutPanel3.Controls.Add(this.btnGerar);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel3.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 2);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(269, 152);
            this.flowLayoutPanel3.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(263, 36);
            this.label2.TabIndex = 0;
            this.label2.Text = "Número de chaves";
            // 
            // txtNChaves
            // 
            this.txtNChaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNChaves.Location = new System.Drawing.Point(3, 38);
            this.txtNChaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNChaves.Name = "txtNChaves";
            this.txtNChaves.Size = new System.Drawing.Size(263, 41);
            this.txtNChaves.TabIndex = 1;
            // 
            // btnGerar
            // 
            this.btnGerar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnGerar.Location = new System.Drawing.Point(3, 83);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(263, 66);
            this.btnGerar.TabIndex = 2;
            this.btnGerar.Text = "Gerar Chaves";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.AutoSize = true;
            this.flowLayoutPanel4.Controls.Add(this.label3);
            this.flowLayoutPanel4.Controls.Add(this.cmbChaves);
            this.flowLayoutPanel4.Controls.Add(this.btnShowAll);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.flowLayoutPanel4.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flowLayoutPanel4.Location = new System.Drawing.Point(278, 2);
            this.flowLayoutPanel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(395, 152);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(389, 36);
            this.label3.TabIndex = 0;
            this.label3.Text = "Selecione a data a consultar";
            // 
            // cmbChaves
            // 
            this.cmbChaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbChaves.FormattingEnabled = true;
            this.cmbChaves.Location = new System.Drawing.Point(3, 38);
            this.cmbChaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbChaves.Name = "cmbChaves";
            this.cmbChaves.Size = new System.Drawing.Size(389, 44);
            this.cmbChaves.Sorted = true;
            this.cmbChaves.TabIndex = 1;
            this.cmbChaves.SelectedIndexChanged += new System.EventHandler(this.cmbChaves_SelectedIndexChanged);
            // 
            // dgvChaves
            // 
            this.dgvChaves.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvChaves.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvChaves.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvChaves.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvChaves.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChaves.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dgvChaves.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvChaves.Location = new System.Drawing.Point(3, 162);
            this.dgvChaves.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvChaves.MaximumSize = new System.Drawing.Size(795, 250);
            this.dgvChaves.Name = "dgvChaves";
            this.dgvChaves.RowHeadersVisible = false;
            this.dgvChaves.RowHeadersWidth = 51;
            this.dgvChaves.RowTemplate.Height = 24;
            this.dgvChaves.Size = new System.Drawing.Size(676, 250);
            this.dgvChaves.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Numeros";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Estrelas";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            // 
            // btnShowAll
            // 
            this.btnShowAll.AutoSize = true;
            this.btnShowAll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShowAll.Location = new System.Drawing.Point(3, 87);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(389, 62);
            this.btnShowAll.TabIndex = 2;
            this.btnShowAll.Text = "Atualizar";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 863);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximumSize = new System.Drawing.Size(919, 1000);
            this.MinimumSize = new System.Drawing.Size(600, 900);
            this.Name = "Form1";
            this.Text = "Euromilhões";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChaves)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNChaves;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.DataGridView dgvChaves;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.ComboBox cmbChaves;
        private System.Windows.Forms.Button btnShowAll;
    }
}

