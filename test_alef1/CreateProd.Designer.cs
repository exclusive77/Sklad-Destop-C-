namespace test_alef1
{
    partial class CreateProd
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
            this.label1 = new System.Windows.Forms.Label();
            this.TB_ProdName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.BT_CreateProd = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataSet1 = new System.Data.DataSet();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.DG_Product = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Um = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BT_Edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(36, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название товара :";
            // 
            // TB_ProdName
            // 
            this.TB_ProdName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_ProdName.Location = new System.Drawing.Point(191, 41);
            this.TB_ProdName.Name = "TB_ProdName";
            this.TB_ProdName.Size = new System.Drawing.Size(333, 26);
            this.TB_ProdName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(36, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Единицы измерения :";
            // 
            // BT_CreateProd
            // 
            this.BT_CreateProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_CreateProd.Location = new System.Drawing.Point(40, 155);
            this.BT_CreateProd.Name = "BT_CreateProd";
            this.BT_CreateProd.Size = new System.Drawing.Size(128, 32);
            this.BT_CreateProd.TabIndex = 3;
            this.BT_CreateProd.Text = "Сохранить";
            this.BT_CreateProd.UseVisualStyleBackColor = true;
            this.BT_CreateProd.Click += new System.EventHandler(this.BT_CreateProd_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(218, 98);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(306, 28);
            this.comboBox1.TabIndex = 4;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            // 
            // BT_Delete
            // 
            this.BT_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Delete.Location = new System.Drawing.Point(405, 155);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(128, 32);
            this.BT_Delete.TabIndex = 6;
            this.BT_Delete.Text = "Удалить";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // DG_Product
            // 
            this.DG_Product.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_Product.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.ProdName,
            this.Um});
            this.DG_Product.Location = new System.Drawing.Point(40, 211);
            this.DG_Product.Name = "DG_Product";
            this.DG_Product.ReadOnly = true;
            this.DG_Product.Size = new System.Drawing.Size(493, 234);
            this.DG_Product.TabIndex = 7;
            this.DG_Product.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DG_Product_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Название товара";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 250;
            // 
            // Um
            // 
            this.Um.DataPropertyName = "Um";
            this.Um.HeaderText = "Единицы измерения";
            this.Um.Name = "Um";
            this.Um.ReadOnly = true;
            // 
            // BT_Edit
            // 
            this.BT_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_Edit.Location = new System.Drawing.Point(218, 155);
            this.BT_Edit.Name = "BT_Edit";
            this.BT_Edit.Size = new System.Drawing.Size(128, 32);
            this.BT_Edit.TabIndex = 8;
            this.BT_Edit.Text = "Изменить";
            this.BT_Edit.UseVisualStyleBackColor = true;
            this.BT_Edit.Click += new System.EventHandler(this.BT_Edit_Click);
            // 
            // CreateProd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 457);
            this.Controls.Add(this.BT_Edit);
            this.Controls.Add(this.DG_Product);
            this.Controls.Add(this.BT_Delete);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.BT_CreateProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_ProdName);
            this.Controls.Add(this.label1);
            this.Name = "CreateProd";
            this.Text = "Товары";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CreateProd_FormClosed);
            this.Load += new System.EventHandler(this.CreateProd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DG_Product)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_ProdName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BT_CreateProd;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Data.DataSet dataSet1;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.DataGridView DG_Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Um;
        private System.Windows.Forms.Button BT_Edit;
    }
}