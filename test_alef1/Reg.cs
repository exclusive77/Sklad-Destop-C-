using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
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
    public partial class Reg : Form
    {
        public Reg()
        {
            InitializeComponent();
        }

        private void Reg_Load(object sender, EventArgs e)
        {

        }

        private void bt_reg_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TB_FIO.Text) && (!String.IsNullOrEmpty(TB_IIN.Text))
               && !String.IsNullOrEmpty(TB_Login.Text) && !String.IsNullOrEmpty(TB_pass.Text))
            {
                using (MyDbContext ctx = new MyDbContext())
                {
                    var account = ctx.Users.Include(u => u.Emps).ToList();

                    if (!account.Exists(u => u.UserName == TB_Login.Text))
                    {
                        singliton_user _User = singliton_user.GetInstance();
                        var employees = ctx.Employees.ToList();
                        if (!employees.Exists(r => r.TaxCode == TB_IIN.Text))
                            {
                            Emps employee = new Emps { EmpName = TB_FIO.Text, TaxCode = TB_IIN.Text };
                            ctx.Employees.Add(employee);
                            ctx.SaveChanges();
                            Users user_1 = new Users { UserName = TB_Login.Text, Password = TB_pass.Text,EmpsId=employee.Id };
                        _User.Create(user_1);
                            //  db.Companies.AddRange(c1, c2);

                            /*   Account ac1 = new Account { Login = TB_login1.Text, Password = TB_pass1.Text };
                               singliton_account _Account = singliton_account.GetInstance();
                               _Account.Create(ac1);

                                   */
                            ;
                        ctx.SaveChanges();
                        this.DialogResult = DialogResult.OK;
                            MessageBox.Show("Вы зарегистрированы ,повторите авторизацию!");
                            this.Close();
                    }
                    else {
                            MessageBox.Show("Проверти ИИН, занят!");
                        }
                    }

                    else
                    {
                        MessageBox.Show("Логин занят!");
                    }
                }
            }
            else
            {
                MessageBox.Show("Поля не заполнены!");
            }
        }
    }
}

