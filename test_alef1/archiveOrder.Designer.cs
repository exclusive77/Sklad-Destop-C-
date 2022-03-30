namespace test_alef1
{
    partial class archiveOrder
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
            this.DG_archivOrder = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.CB_UserS = new System.Windows.Forms.ComboBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.BTSearch = new System.Windows.Forms.Button();
            this.BT_All = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DG_archivOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // DG_archivOrder
            // 
            this.DG_archivOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DG_archivOrder.Location = new System.Drawing.Point(12, 111);
            this.DG_archivOrder.Name = "DG_archivOrder";
            this.DG_archivOrder.ReadOnly = true;
            this.DG_archivOrder.Size = new System.Drawing.Size(798, 311);
            this.DG_archivOrder.TabIndex = 0;
            this.DG_archivOrder.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DG_archivOrder_MouseDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сотрудник :";
            // 
            // CB_UserS
            // 
            this.CB_UserS.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CB_UserS.FormattingEnabled = true;
            this.CB_UserS.Location = new System.Drawing.Point(119, 76);
            this.CB_UserS.Name = "CB_UserS";
            this.CB_UserS.Size = new System.Drawing.Size(253, 28);
            this.CB_UserS.TabIndex = 2;
            this.CB_UserS.SelectedIndexChanged += new System.EventHandler(this.CB_UserS_SelectedIndexChanged);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(446, 78);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(147, 20);
            this.dateTimePicker1.TabIndex = 3;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(384, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Дата :";
            // 
            // BTSearch
            // 
            this.BTSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BTSearch.Location = new System.Drawing.Point(609, 71);
            this.BTSearch.Name = "BTSearch";
            this.BTSearch.Size = new System.Drawing.Size(92, 34);
            this.BTSearch.TabIndex = 5;
            this.BTSearch.Text = "Поиск";
            this.BTSearch.UseVisualStyleBackColor = true;
            this.BTSearch.Click += new System.EventHandler(this.BTSearch_Click);
            // 
            // BT_All
            // 
            this.BT_All.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BT_All.Location = new System.Drawing.Point(718, 71);
            this.BT_All.Name = "BT_All";
            this.BT_All.Size = new System.Drawing.Size(92, 34);
            this.BT_All.TabIndex = 6;
            this.BT_All.Text = "Отмена";
            this.BT_All.UseVisualStyleBackColor = true;
            this.BT_All.Click += new System.EventHandler(this.BT_All_Click);
            // 
            // archiveOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.BT_All);
            this.Controls.Add(this.BTSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.CB_UserS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DG_archivOrder);
            this.Name = "archiveOrder";
            this.Text = "Архив заказав";
            this.Load += new System.EventHandler(this.archiveOrder_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DG_archivOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DG_archivOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox CB_UserS;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTSearch;
        private System.Windows.Forms.Button BT_All;
    }
}