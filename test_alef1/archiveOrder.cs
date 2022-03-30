using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using test_alef1.Model;
using System.Data.Entity;
namespace test_alef1
{
    public partial class archiveOrder : Form
    {
        DataTable dataTable = new DataTable();
        string dataS = " ";
        string selectUser;
        public static int modelReadID;
        Emps selectEmp = new Emps();
        List<Exp> exps = new List<Exp>();
        BindingList<Users> users = new BindingList<Users>();
        public archiveOrder()
        {
            InitializeComponent();

            CBoxListUser();
            DG_archivOrder.DataSource = dataTable;
            DG_archivOrder.AllowUserToAddRows = false;
        }

       

        private void DG_archivOrder_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            Exp modelRead = new Exp();
            if (DG_archivOrder.CurrentRow.Index != -1)
            {
                ;
                modelReadID = Convert.ToInt32(DG_archivOrder.CurrentRow.Cells["Номер заказа"].Value);
                using (MyDbContext ctx = new MyDbContext())
                {
                    modelRead = ctx.ExpOrder.FirstOrDefault(n => n.Id == modelRead.Id);

                    ReadOrder readOrder = new ReadOrder(modelReadID);
                    readOrder.Show();
                }

            }
        }
        public void CBoxListUser()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                var usersAR = ctx.Employees.ToList();

                if (usersAR.Count > 0)
                {
                    usersAR.Insert(0, new Emps { Id = 0, EmpName = "Все", TaxCode = "00000000" });
                    CB_UserS.DataSource = usersAR;
                    CB_UserS.DisplayMember = "EmpName";
                    CB_UserS.ValueMember = "Id";


                }
               ;
            }
        }
        private void archiveOrder_Load(object sender, EventArgs e)
        {

            dataTable.Columns.Add("Номер заказа", typeof(int));
            dataTable.Columns.Add("Дата заказа", typeof(string));
            dataTable.Columns.Add("Сотрудник", typeof(string));
          
            using (MyDbContext ctx = new MyDbContext())
            {

                exps = ctx.ExpOrder.Include(s => s.Emps).ToList();
                ;
                ShowOrders();
            }

        }
        void ShowOrders()
        {
            dataTable.Rows.Clear();
            foreach (Exp item in exps)
            {
                dataTable.Rows.Add(item.Id, item.DocData, item.Emps.EmpName);

            }
        }
        private void CB_UserS_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectEmp = (Emps)CB_UserS.SelectedItem;
            selectUser = selectEmp.EmpName;
         /*   using (MyDbContext ctx = new MyDbContext())
            {
                //dataS = dateTimePicker1.Value.ToShortDateString();
                exps = ctx.ExpOrder.Include(s => s.Emps).ToList();
                ;


                if (!String.IsNullOrEmpty(selectUser) && !selectUser.Equals("Все"))
                {
                    exps = exps.Where(p => p.Emps.EmpName == selectUser).ToList();
                    ;
                }
            }
            ;
            ShowOrders();*/
        } 
    
            private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
             dataS = dateTimePicker1.Value.ToShortDateString();
        }

        private void BTSearch_Click(object sender, EventArgs e)
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                //dataS = dateTimePicker1.Value.ToShortDateString();
                exps = ctx.ExpOrder.Include(s => s.Emps).ToList();
                ;


                if (!String.IsNullOrEmpty(selectUser) && !selectUser.Equals("Все"))
                {
                    exps = exps.Where(p => p.Emps.EmpName == selectUser).ToList();
                    ;
                }
              if (!String.IsNullOrEmpty(dataS) && !dataS.Equals(" "))
                {
               ;
                    exps = exps.Where(p => p.DocData.ToShortDateString() == dataS).ToList();
                    ;
                }
            ;
                ShowOrders();
                dataS = null;
            }
        }

        private void BT_All_Click(object sender, EventArgs e)
        {

            using (MyDbContext ctx = new MyDbContext())
            {

                exps = ctx.ExpOrder.Include(s => s.Emps).ToList();
                ;


            ;
                ShowOrders();
            }
        }
      
    }
}
