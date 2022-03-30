namespace test_alef1
{
    partial class Reg
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
            this.TB_FIO = new System.Windows.Forms.TextBox();
            this.ИИН = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TB_Login = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TB_pass = new System.Windows.Forms.TextBox();
            this.bt_reg = new System.Windows.Forms.Button();
            this.TB_IIN = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ф.И.O :";
            // 
            // TB_FIO
            // 
            this.TB_FIO.Location = new System.Drawing.Point(147, 68);
            this.TB_FIO.Name = "TB_FIO";
            this.TB_FIO.Size = new System.Drawing.Size(432, 29);
            this.TB_FIO.TabIndex = 1;
            // 
            // ИИН
            // 
            this.ИИН.AutoSize = true;
            this.ИИН.Location = new System.Drawing.Point(55, 156);
            this.ИИН.Name = "ИИН";
            this.ИИН.Size = new System.Drawing.Size(59, 24);
            this.ИИН.TabIndex = 2;
            this.ИИН.Text = "ИИН :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Логин :";
            // 
            // TB_Login
            // 
            this.TB_Login.Location = new System.Drawing.Point(147, 218);
            this.TB_Login.Name = "TB_Login";
            this.TB_Login.Size = new System.Drawing.Size(432, 29);
            this.TB_Login.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Пароль :";
            // 
            // TB_pass
            // 
            this.TB_pass.Location = new System.Drawing.Point(147, 295);
            this.TB_pass.Name = "TB_pass";
            this.TB_pass.Size = new System.Drawing.Size(432, 29);
            this.TB_pass.TabIndex = 7;
            this.TB_pass.UseSystemPasswordChar = true;
            // 
            // bt_reg
            // 
            this.bt_reg.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.bt_reg.Location = new System.Drawing.Point(147, 391);
            this.bt_reg.Name = "bt_reg";
            this.bt_reg.Size = new System.Drawing.Size(432, 58);
            this.bt_reg.TabIndex = 8;
            this.bt_reg.Text = "Зарегистрировать";
            this.bt_reg.UseVisualStyleBackColor = false;
            this.bt_reg.Click += new System.EventHandler(this.bt_reg_Click);
            // 
            // TB_IIN
            // 
            this.TB_IIN.Location = new System.Drawing.Point(147, 156);
            this.TB_IIN.Mask = "00000000000";
            this.TB_IIN.Name = "TB_IIN";
            this.TB_IIN.Size = new System.Drawing.Size(432, 29);
            this.TB_IIN.TabIndex = 9;
            this.TB_IIN.ValidatingType = typeof(int);
            // 
            // Reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 461);
            this.Controls.Add(this.TB_IIN);
            this.Controls.Add(this.bt_reg);
            this.Controls.Add(this.TB_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TB_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ИИН);
            this.Controls.Add(this.TB_FIO);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Reg";
            this.Text = "Регистрация";
            this.Load += new System.EventHandler(this.Reg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TB_FIO;
        private System.Windows.Forms.Label ИИН;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TB_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TB_pass;
        private System.Windows.Forms.Button bt_reg;
        private System.Windows.Forms.MaskedTextBox TB_IIN;
    }
}