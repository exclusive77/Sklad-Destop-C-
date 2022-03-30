using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_alef1.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace test_alef1
{
    public partial class Form1 : Form
    {
        static string login;
        public Form1()
        {
            InitializeComponent();
             this.passField.AutoSize = false;
            this.passField.Size = new Size(this.passField.Size.Width, 55);
        }

       

        private void CloseButon_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CloseButon_MouseEnter(object sender, EventArgs e)
        {
            CloseButon.ForeColor = Color.Red;
        }

        private void CloseButon_MouseLeave(object sender, EventArgs e)
        {
            CloseButon.ForeColor = Color.White;
        }
        Point lastPoint;
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(LoginField.Text) && (!String.IsNullOrEmpty(passField.Text)))
            {
                using (MyDbContext ctx = new MyDbContext())
                {
                    var account = ctx.Users.Include(q => q.Emps).ToList();

                    if (account.Exists(u => u.UserName == LoginField.Text) && (account.Exists(u => u.Password == passField.Text)))
                    {
                        
                        login = LoginField.Text;
                        Order dlgM = new Order(login);
                        ;

                        dlgM.ShowDialog();

                    }

                    else
                        MessageBox.Show(  "Неверный логин или пароль! " , "Внимание!");

                }
            }


            else
                MessageBox.Show(  "Не все поля заполнены! ", "Внимание!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reg registration = new Reg();
            registration.ShowDialog();

        }
    }
    }

