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
using System.Collections.ObjectModel;

namespace test_alef1
{
    public partial class Order : Form
    {
        static List<OrderDet> prods = new List<OrderDet>();
        OrderDet modelProd = new OrderDet();
        static string EmpLogin;
        public Order(string login)
        {
            EmpLogin = login;


            InitializeComponent();
            authorizedUserLabel.Text = login;
            CBoxList();
            L_Data.Text = DateTime.Now.Date.ToShortDateString();
        }
        public void CBoxList()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                var prod = ctx.Product.ToList();

                if (prod.Count > 0)
                {
                    CBoxProd.DataSource = prod;
                    CBoxProd.DisplayMember = "ProdName";
                    CBoxProd.ValueMember = "Id";


                }
               ;
            }
        }
        private void BT_CreateProduct_Click(object sender, EventArgs e)
        {
            CreateProd createProd = new CreateProd();

            if (createProd.ShowDialog() == DialogResult.OK)
            {
                CBoxList();



            }
        }


        private void Order_Load(object sender, EventArgs e)
        {

            DG_proList.DataSource = prods.ToList();
            DG_proList.AllowUserToAddRows = false;
        }
        void listDG()
        {
            DG_proList.DataSource = prods.ToList();
        }


        private void BT_AddProd_Click(object sender, EventArgs e)
        {
            Prods selectProd = (Prods)CBoxProd.SelectedItem;
            if (selectProd != null && QtyProd.Value != 0 && NM_Price.Value != 0)
            {
                int Qtysel = (int)QtyProd.Value;
                var productInbasket = prods.FirstOrDefault(s => s.ProdId == selectProd.Id);
                ;
                if (productInbasket == null)
                {
                    prods.Add(new OrderDet()
                    {
                        ProdId = selectProd.Id,
                        ProdName = selectProd.ProdName,
                        Qty = (int)QtyProd.Value,
                        Price = (decimal)NM_Price.Value,

                    })
                        ; ; ;
                    listDG();
                }
                else
                {

                    productInbasket.Qty = productInbasket.Qty + Qtysel;
                    listDG();
                }
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");

            }
            ;
        }

        private void BT_CreateOrder_Click(object sender, EventArgs e)
        {
            Exp order = new Exp();
            using (MyDbContext ctx = new MyDbContext())
            {
                var emplID = ctx.Users.Include(n => n.Emps).FirstOrDefault(s => s.UserName == EmpLogin);
                order.EmpsId = emplID.EmpsId;
                var emp = ctx.Employees.FirstOrDefault(v => v.Id == order.EmpsId);
                order.Emps = emp;
                order.DocData = DateTime.Now;

                ;
                ctx.ExpOrder.Add(order);

                ctx.SaveChanges();
                ;
                ExpD orderDetails = new ExpD();
                ;
                foreach (var item in prods)
                {
                    orderDetails.ExpId = order.Id;

                    orderDetails.ProdId = item.ProdId;
                    orderDetails.Qty = item.Qty;

                    orderDetails.Price = item.Price;
                    orderDetails.Sum = item.Sum;

                    ctx.ExpDetalsOrder.Add(orderDetails);
                    ctx.SaveChanges();
                }
            }
            prods.Clear();
            QtyProd.Value = 1;
            NM_Price.Value = 0;


            MessageBox.Show("Заказ сохранен!");


        }

        private void BT_ArcivOrders_Click(object sender, EventArgs e)
        {
            archiveOrder archiveOrder = new archiveOrder();
            archiveOrder.Show();
        }

        private void DG_proList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DG_proList.Columns[e.ColumnIndex].Name == "Delete")
            {
                if (MessageBox.Show("Вы хотите удалить эту запись?", "Сообщение", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (DG_proList.CurrentRow.Index != -1)
                    {
                        ;
                        var modelDel = Convert.ToInt32(DG_proList.CurrentRow.Cells["ProdId"].Value);
                        var del = prods.FirstOrDefault(v => v.ProdId == modelDel);
                        prods.Remove(del);
                        listDG();
                    }
                }
            }
        }
    }
}