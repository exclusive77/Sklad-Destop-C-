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
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using test_alef1.Model;
namespace test_alef1
{
    public partial class ReadOrder : Form
    {
        List<ExpD> modelExpDs = new List<ExpD>();
        public ReadOrder(int modelReadID)
        {
            InitializeComponent();
            if (modelReadID != 0)
            {
                ;
                Exp modelExp = new Exp();
                using (MyDbContext ctx = new MyDbContext())
                {
                    modelExp = ctx.ExpOrder.Include(s => s.Emps).FirstOrDefault(z => z.Id == modelReadID);
                    modelExpDs = ctx.ExpDetalsOrder.Include(d => d.Prod).Where(n => n.ExpId == modelReadID).ToList();

                    TB_UserRead.Text = modelExp.Emps.EmpName;
                    TB_DataRead.Text = modelExp.DocData.ToString();
                    TB_NOrder.Text = modelExp.Id.ToString();
                    DG_ReadOrder.DataSource = modelExpDs;
                }
            }

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Название товара", typeof(string));
            dataTable.Columns.Add("Единица измерения", typeof(string));
            dataTable.Columns.Add("Цена", typeof(decimal));
            dataTable.Columns.Add("Количество", typeof(int));
            dataTable.Columns.Add("Cумма", typeof(decimal));
            using (MyDbContext ctx = new MyDbContext())
            {

            
                ;
                foreach (ExpD item in modelExpDs)
                {
                    dataTable.Rows.Add( item.Prod.ProdName, item.Prod.Um,item.Price,item.Qty,item.Sum);

                }
            }
            DG_ReadOrder.DataSource = dataTable;
         TB_Total.Text=   modelExpDs.Sum(x => x.Sum).ToString();
            DG_ReadOrder.AllowUserToAddRows = false;
        }
       
    }
}