namespace test_alef1
{
    partial class ReadOrder
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
            this.TB_UserRead = new System.Windows.Forms.TextBox();
            this.TB_DataRead = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.DG_ReadOrder = new System.Windows.Forms.DataGridView();
            this.TB_NOrder = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_Total = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DG_ReadOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(23, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Пользаватель :";
            // 
            // TB_UserRead
            // 
            this.TB_UserRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_UserRead.Location = new System.Drawing.Point(159, 28);
            this.TB_UserRead.Name = "TB_UserRead";
            this.TB_UserRead.ReadOnly = true;
            this.TB_UserRead.Size = new System.Drawing.Size(179, 26);
            this.TB_UserRead.TabIndex = 1;
            // 
            // TB_DataRead
            // 
            this.TB_DataRead.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_DataRead.Location = new System.Drawing.Point(490, 30);
            this.TB_DataRead.Name = "TB_DataRead";
            this.TB_DataRead.ReadOnly = true;
            this.TB_DataRead.Size = new System.Drawing.Size(179, 26);
            this.TB_DataRead.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(396, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Дата :";
            // 
            // DG_ReadOrder
            // 
            this.DG_ReadOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_ReadOrder.Location = new System.Drawing.Point(27, 119);
            this.DG_ReadOrder.Name = "DG_ReadOrder";
            this.DG_ReadOrder.Size = new System.Drawing.Size(738, 262);
            this.DG_ReadOrder.TabIndex = 4;
            // 
            // TB_NOrder
            // 
            this.TB_NOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_NOrder.Location = new System.Drawing.Point(159, 75);
            this.TB_NOrder.Name = "TB_NOrder";
            this.TB_NOrder.ReadOnly = true;
            this.TB_NOrder.Size = new System.Drawing.Size(179, 26);
            this.TB_NOrder.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(23, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "  Заказ № ";
            // 
            // TB_Total
            // 
            this.TB_Total.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TB_Total.Location = new System.Drawing.Point(179, 400);
            this.TB_Total.Name = "TB_Total";
            this.TB_Total.ReadOnly = true;
            this.TB_Total.Size = new System.Drawing.Size(179, 26);
            this.TB_Total.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(43, 401);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Итого :";
            // 
            // ReadOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TB_Total);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TB_NOrder);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DG_ReadOrder);
            this.Controls.Add(this.TB_DataRead);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TB_UserRead);
            this.Controls.Add(this.label1);
            this.Name = "ReadOrder";
            this.Text = "Заказ ";
            ((System.ComponentModel.ISupportInitialize)(this.DG_ReadOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_UserRead;
        private System.Windows.Forms.TextBox TB_DataRead;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView DG_ReadOrder;
        private System.Windows.Forms.TextBox TB_NOrder;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_Total;
        private System.Windows.Forms.Label label4;
    }
}