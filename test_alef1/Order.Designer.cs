namespace test_alef1
{
    partial class Order
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
            this.authorizedUserLabel = new System.Windows.Forms.Label();
            this.DG_proList = new System.Windows.Forms.DataGridView();
            this.BT_CreateProduct = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.CBoxProd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.QtyProd = new System.Windows.Forms.NumericUpDown();
            this.BT_AddProd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.NM_Price = new System.Windows.Forms.NumericUpDown();
            this.BT_CreateOrder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.L_Data = new System.Windows.Forms.Label();
            this.BT_ArcivOrders = new System.Windows.Forms.Button();
            this.ProdId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProdName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DG_proList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyProd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(31, 30);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользователь :";
            // 
            // authorizedUserLabel
            // 
            this.authorizedUserLabel.AutoSize = true;
            this.authorizedUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.authorizedUserLabel.Location = new System.Drawing.Point(168, 30);
            this.authorizedUserLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.authorizedUserLabel.Name = "authorizedUserLabel";
            this.authorizedUserLabel.Size = new System.Drawing.Size(51, 20);
            this.authorizedUserLabel.TabIndex = 1;
            this.authorizedUserLabel.Text = "label2";
            // 
            // DG_proList
            // 
            this.DG_proList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_proList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProdId,
            this.ProdName,
            this.Qty,
            this.Price,
            this.Sum,
            this.Delete});
            this.DG_proList.Location = new System.Drawing.Point(35, 251);
            this.DG_proList.Margin = new System.Windows.Forms.Padding(4);
            this.DG_proList.Name = "DG_proList";
            this.DG_proList.ReadOnly = true;
            this.DG_proList.Size = new System.Drawing.Size(959, 232);
            this.DG_proList.TabIndex = 2;
            this.DG_proList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DG_proList_CellContentClick);
            // 
            // BT_CreateProduct
            // 
            this.BT_CreateProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(245)))), ((int)(((byte)(96)))));
            this.BT_CreateProduct.Location = new System.Drawing.Point(736, 23);
            this.BT_CreateProduct.Margin = new System.Windows.Forms.Padding(4);
            this.BT_CreateProduct.Name = "BT_CreateProduct";
            this.BT_CreateProduct.Size = new System.Drawing.Size(177, 36);
            this.BT_CreateProduct.TabIndex = 3;
            this.BT_CreateProduct.Text = "Товары";
            this.BT_CreateProduct.UseVisualStyleBackColor = false;
            this.BT_CreateProduct.Click += new System.EventHandler(this.BT_CreateProduct_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(31, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название товара :";
            // 
            // CBoxProd
            // 
            this.CBoxProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CBoxProd.FormattingEnabled = true;
            this.CBoxProd.Location = new System.Drawing.Point(190, 63);
            this.CBoxProd.Name = "CBoxProd";
            this.CBoxProd.Size = new System.Drawing.Size(498, 28);
            this.CBoxProd.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(31, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Количество :";
            // 
            // QtyProd
            // 
            this.QtyProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QtyProd.Location = new System.Drawing.Point(153, 107);
            this.QtyProd.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.QtyProd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.QtyProd.Name = "QtyProd";
            this.QtyProd.Size = new System.Drawing.Size(180, 26);
            this.QtyProd.TabIndex = 7;
            this.QtyProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // BT_AddProd
            // 
            this.BT_AddProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_AddProd.Location = new System.Drawing.Point(35, 191);
            this.BT_AddProd.Name = "BT_AddProd";
            this.BT_AddProd.Size = new System.Drawing.Size(112, 34);
            this.BT_AddProd.TabIndex = 8;
            this.BT_AddProd.Text = "Добавить";
            this.BT_AddProd.UseVisualStyleBackColor = true;
            this.BT_AddProd.Click += new System.EventHandler(this.BT_AddProd_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(31, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Цена :";
            // 
            // NM_Price
            // 
            this.NM_Price.DecimalPlaces = 2;
            this.NM_Price.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NM_Price.Location = new System.Drawing.Point(153, 146);
            this.NM_Price.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.NM_Price.Name = "NM_Price";
            this.NM_Price.Size = new System.Drawing.Size(180, 26);
            this.NM_Price.TabIndex = 10;
            this.NM_Price.ThousandsSeparator = true;
            // 
            // BT_CreateOrder
            // 
            this.BT_CreateOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_CreateOrder.Location = new System.Drawing.Point(736, 191);
            this.BT_CreateOrder.Name = "BT_CreateOrder";
            this.BT_CreateOrder.Size = new System.Drawing.Size(177, 34);
            this.BT_CreateOrder.TabIndex = 11;
            this.BT_CreateOrder.Text = "Сохранить заказ";
            this.BT_CreateOrder.UseVisualStyleBackColor = true;
            this.BT_CreateOrder.Click += new System.EventHandler(this.BT_CreateOrder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(423, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Дата :";
            // 
            // L_Data
            // 
            this.L_Data.AutoSize = true;
            this.L_Data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.L_Data.Location = new System.Drawing.Point(485, 30);
            this.L_Data.Name = "L_Data";
            this.L_Data.Size = new System.Drawing.Size(51, 20);
            this.L_Data.TabIndex = 13;
            this.L_Data.Text = "label6";
            // 
            // BT_ArcivOrders
            // 
            this.BT_ArcivOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_ArcivOrders.Location = new System.Drawing.Point(736, 75);
            this.BT_ArcivOrders.Name = "BT_ArcivOrders";
            this.BT_ArcivOrders.Size = new System.Drawing.Size(177, 34);
            this.BT_ArcivOrders.TabIndex = 14;
            this.BT_ArcivOrders.Text = "Архив Заказов";
            this.BT_ArcivOrders.UseVisualStyleBackColor = true;
            this.BT_ArcivOrders.Click += new System.EventHandler(this.BT_ArcivOrders_Click);
            // 
            // ProdId
            // 
            this.ProdId.DataPropertyName = "ProdId";
            this.ProdId.HeaderText = "ProdId";
            this.ProdId.Name = "ProdId";
            this.ProdId.ReadOnly = true;
            this.ProdId.Visible = false;
            // 
            // ProdName
            // 
            this.ProdName.DataPropertyName = "ProdName";
            this.ProdName.HeaderText = "Название товара";
            this.ProdName.Name = "ProdName";
            this.ProdName.ReadOnly = true;
            this.ProdName.Width = 300;
            // 
            // Qty
            // 
            this.Qty.DataPropertyName = "Qty";
            this.Qty.HeaderText = "Количество";
            this.Qty.Name = "Qty";
            this.Qty.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Цена";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Sum
            // 
            this.Sum.DataPropertyName = "Sum";
            this.Sum.HeaderText = "Всего за товар";
            this.Sum.Name = "Sum";
            this.Sum.ReadOnly = true;
            // 
            // Delete
            // 
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.HeaderText = "Delete";
            this.Delete.Name = "Delete";
            this.Delete.ReadOnly = true;
            this.Delete.Text = "Delete";
            this.Delete.UseColumnTextForButtonValue = true;
            // 
            // Order
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.BT_ArcivOrders);
            this.Controls.Add(this.L_Data);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BT_CreateOrder);
            this.Controls.Add(this.NM_Price);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BT_AddProd);
            this.Controls.Add(this.QtyProd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CBoxProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BT_CreateProduct);
            this.Controls.Add(this.DG_proList);
            this.Controls.Add(this.authorizedUserLabel);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Order";
            this.Text = "Заказ";
            this.Load += new System.EventHandler(this.Order_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_proList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QtyProd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NM_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label authorizedUserLabel;
        private System.Windows.Forms.DataGridView DG_proList;
        private System.Windows.Forms.Button BT_CreateProduct;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox CBoxProd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown QtyProd;
        private System.Windows.Forms.Button BT_AddProd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown NM_Price;
        private System.Windows.Forms.Button BT_CreateOrder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label L_Data;
        private System.Windows.Forms.Button BT_ArcivOrders;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProdName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sum;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}