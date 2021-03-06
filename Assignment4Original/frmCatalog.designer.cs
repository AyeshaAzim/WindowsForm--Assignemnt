
using System;
using System.Windows.Forms;

namespace Assignment4Original
{
    partial class frmCatalog
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gbDataStore = new System.Windows.Forms.GroupBox();
            this.numAutoSave = new System.Windows.Forms.NumericUpDown();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.lblFilePath = new System.Windows.Forms.Label();
            this.txtCatalog = new System.Windows.Forms.TextBox();
            this.btnCreateProduct = new System.Windows.Forms.Button();
            this.lblFilter = new System.Windows.Forms.Label();
            this.txtFilter = new System.Windows.Forms.TextBox();
            this.dgvCatalog = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDepartment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tmrAutoSave = new System.Windows.Forms.Timer(this.components);
            this.gbDataStore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).BeginInit();
            this.SuspendLayout();
            // 
            // gbDataStore
            // 
            this.gbDataStore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDataStore.Controls.Add(this.numAutoSave);
            this.gbDataStore.Controls.Add(this.chkAutoSave);
            this.gbDataStore.Controls.Add(this.btnLoad);
            this.gbDataStore.Controls.Add(this.lblFilePath);
            this.gbDataStore.Controls.Add(this.txtCatalog);
            this.gbDataStore.Location = new System.Drawing.Point(52, 30);
            this.gbDataStore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDataStore.Name = "gbDataStore";
            this.gbDataStore.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDataStore.Size = new System.Drawing.Size(493, 90);
            this.gbDataStore.TabIndex = 0;
            this.gbDataStore.TabStop = false;
            this.gbDataStore.Text = "Data Store";
            // 
            // numAutoSave
            // 
            this.numAutoSave.Location = new System.Drawing.Point(254, 53);
            this.numAutoSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numAutoSave.Maximum = new decimal(new int[] {
            60000,
            0,
            0,
            0});
            this.numAutoSave.Name = "numAutoSave";
            this.numAutoSave.Size = new System.Drawing.Size(98, 22);
            this.numAutoSave.TabIndex = 4;
            this.numAutoSave.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.Location = new System.Drawing.Point(111, 55);
            this.chkAutoSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(135, 21);
            this.chkAutoSave.TabIndex = 3;
            this.chkAutoSave.Text = "Auto Save Every";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.chkAutoSave.CheckedChanged += new System.EventHandler(this.chkAutoSave_CheckedChanged);
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(358, 21);
            this.btnLoad.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(94, 23);
            this.btnLoad.TabIndex = 2;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // lblFilePath
            // 
            this.lblFilePath.AutoSize = true;
            this.lblFilePath.Location = new System.Drawing.Point(22, 23);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(63, 17);
            this.lblFilePath.TabIndex = 1;
            this.lblFilePath.Text = "File Path";
            // 
            // txtCatalog
            // 
            this.txtCatalog.Location = new System.Drawing.Point(111, 21);
            this.txtCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCatalog.Name = "txtCatalog";
            this.txtCatalog.Size = new System.Drawing.Size(241, 22);
            this.txtCatalog.TabIndex = 0;
            this.txtCatalog.Text = "Catalog.txt";
            // 
            // btnCreateProduct
            // 
            this.btnCreateProduct.Location = new System.Drawing.Point(52, 137);
            this.btnCreateProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCreateProduct.Name = "btnCreateProduct";
            this.btnCreateProduct.Size = new System.Drawing.Size(152, 33);
            this.btnCreateProduct.TabIndex = 1;
            this.btnCreateProduct.Text = "Create Product";
            this.btnCreateProduct.UseVisualStyleBackColor = true;
            this.btnCreateProduct.Click += new System.EventHandler(this.btnCreateProduct_Click);
            // 
            // lblFilter
            // 
            this.lblFilter.AutoSize = true;
            this.lblFilter.Location = new System.Drawing.Point(601, 141);
            this.lblFilter.Name = "lblFilter";
            this.lblFilter.Size = new System.Drawing.Size(39, 17);
            this.lblFilter.TabIndex = 2;
            this.lblFilter.Text = "Filter";
            // 
            // txtFilter
            // 
            this.txtFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFilter.Location = new System.Drawing.Point(649, 138);
            this.txtFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtFilter.Name = "txtFilter";
            this.txtFilter.Size = new System.Drawing.Size(125, 22);
            this.txtFilter.TabIndex = 3;
            // 
            // dgvCatalog
            // 
            this.dgvCatalog.AllowUserToAddRows = false;
            this.dgvCatalog.AllowUserToDeleteRows = false;
            this.dgvCatalog.AllowUserToOrderColumns = true;
            this.dgvCatalog.AllowUserToResizeRows = false;
            this.dgvCatalog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvCatalog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCatalog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCatalog.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colDepartment,
            this.colPrice});
            this.dgvCatalog.Location = new System.Drawing.Point(52, 174);
            this.dgvCatalog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCatalog.Name = "dgvCatalog";
            this.dgvCatalog.ReadOnly = true;
            this.dgvCatalog.RowHeadersVisible = false;
            this.dgvCatalog.RowHeadersWidth = 51;
            this.dgvCatalog.RowTemplate.Height = 29;
            this.dgvCatalog.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCatalog.Size = new System.Drawing.Size(722, 269);
            this.dgvCatalog.TabIndex = 4;
            this.dgvCatalog.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCatalog_CellContentClick);
            // 
            // colName
            // 
            this.colName.HeaderText = "Name";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            this.colName.ReadOnly = true;
            // 
            // colDepartment
            // 
            this.colDepartment.HeaderText = "Department";
            this.colDepartment.MinimumWidth = 6;
            this.colDepartment.Name = "colDepartment";
            this.colDepartment.ReadOnly = true;
            // 
            // colPrice
            // 
            this.colPrice.HeaderText = "Price";
            this.colPrice.MinimumWidth = 6;
            this.colPrice.Name = "colPrice";
            this.colPrice.ReadOnly = true;
            // 
            // tmrAutoSave
            // 
            this.tmrAutoSave.Interval = 1000;
            this.tmrAutoSave.Tick += new System.EventHandler(this.tmrAutoSave_Tick);
            // 
            // frmCatalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 466);
            this.Controls.Add(this.dgvCatalog);
            this.Controls.Add(this.txtFilter);
            this.Controls.Add(this.lblFilter);
            this.Controls.Add(this.btnCreateProduct);
            this.Controls.Add(this.gbDataStore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmCatalog";
            this.Text = "Catalog";
            this.Load += new System.EventHandler(this.frmCatalog_Load);
            this.gbDataStore.ResumeLayout(false);
            this.gbDataStore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAutoSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCatalog)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
       
        private void frmCatalog_Load(object sender, EventArgs e)
        {
            
        }

        private void dgvCatalog_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.GroupBox gbDataStore;
        private System.Windows.Forms.NumericUpDown numAutoSave;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox txtCatalog;
        private System.Windows.Forms.Button btnCreateProduct;
        private System.Windows.Forms.Label lblFilter;
        private System.Windows.Forms.TextBox txtFilter;
        private System.Windows.Forms.DataGridView dgvCatalog;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDepartment;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice;
        private System.Windows.Forms.Timer tmrAutoSave;
    }
}

