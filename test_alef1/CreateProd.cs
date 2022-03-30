using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class CreateProd : Form
    {
         Prods model = new Prods();
        Prods productSelect = new Prods();
        string selectedUM;
        public CreateProd()
        {
            InitializeComponent();
            comboBox1.Items.AddRange(new string[] { "ШТ.", "КВ М", "Погн.М", "КГ", "Грамм", "Тонн", "Куб М", "Литров", "Пар" });
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            listDV();
          
            BT_Delete.Enabled = false;
        }
        void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedUM = comboBox1.SelectedItem.ToString();

        }

        private void BT_CreateProd_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TB_ProdName.Text) && (!String.IsNullOrEmpty(selectedUM)))
            {
                using (MyDbContext ctx = new MyDbContext())
                {
                    var product = ctx.Product.ToList();
                   
                        if (!product.Exists(u => u.ProdName == TB_ProdName.Text))
                        {

                            model.ProdName = TB_ProdName.Text.Trim();
                            model.Um = selectedUM;

                            ctx.Product.Add(model);
                            ctx.SaveChanges();
                            MessageBox.Show("Продукт создан !");
                        }
                       
                        
                        else
                        {
                            MessageBox.Show("Продукт c таким названием существует !");
                        }
                   

                        
                        listDV();
                        Clear();
                    
                        // this.Close();
                    }
           
            }
            else
            {
                MessageBox.Show("Не все поля заполнены!");

            }
        }
       void Clear()
        { 
            TB_ProdName.Text = " ";
            comboBox1.Text = " ";
        }
        void listDV()
        {
            using (MyDbContext ctx = new MyDbContext())
            {
                var product = ctx.Product.ToList();

                DG_Product.DataSource = product.ToList();
            }
        }

       

        private void DG_Product_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (DG_Product.CurrentRow.Index != -1)
            {
                ;
                model.Id = Convert.ToInt32(DG_Product.CurrentRow.Cells["Id"].Value);
                using (MyDbContext ctx = new MyDbContext())
                {
                     model = ctx.Product.FirstOrDefault(n => n.Id == model.Id);

                    TB_ProdName.Text = model.ProdName;
                    comboBox1.Text = model.Um;
                   
                 
                    BT_Delete.Enabled = true;
                    ;
                }
            }
        }

        private void BT_Delete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Вы действительно хотите удалить товар?", "Внимание!", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (MyDbContext ctx = new MyDbContext())
                {
                   // productSelect = ctx.Product.FirstOrDefault(n => n.Id == model.Id);
                    var entry = ctx.Entry(productSelect);
                    ;
                    if (entry.State == EntityState.Detached)
                    {
                        ctx.Product.Attach(model);
                        ctx.Product.Remove(model);
                        ;
                       
                        ctx.SaveChanges();
                        model = null;
                    }
                  
                    BT_Delete.Enabled = false;
                    listDV();
                    Clear();
                    ;
                }
            }
        }

        private void BT_Cancel_Click(object sender, EventArgs e)
        {
            model.Id = 0;
            BT_CreateProd.Text = "Coxpанить";
            listDV();
            Clear();
            BT_Delete.Enabled = false;
          //  this.DialogResult = DialogResult.OK;
        }

        private void CreateProd_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.DialogResult = DialogResult.OK;
        }

        private void BT_Edit_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(TB_ProdName.Text) && (!String.IsNullOrEmpty(selectedUM)))
            {
                using (MyDbContext ctx = new MyDbContext())
                {

                    if (ctx.Product.Where(x => x.Id != model.Id).Any(d => d.ProdName == model.ProdName)==false)
                       
                        {
                            var edit = ctx.Product.FirstOrDefault(n => n.Id == model.Id);
                            edit.ProdName = TB_ProdName.Text.Trim();
                            edit.Um = selectedUM;
                            ;
                            ctx.SaveChanges();
                            BT_CreateProd.Enabled= true;
                            MessageBox.Show("Продукт изменен !");
                            ctx.SaveChanges();
                        }
                        else
                        {
                        ;
                            MessageBox.Show("Продукт c таким названием существует !");
                        }
                                       
                    ;

                                           // 
                        listDV();
                        Clear();
                                         
                    }
                               
            }
            else
            {
                MessageBox.Show("Выбирете продукт!");

            }
        }

        private void CreateProd_Load(object sender, EventArgs e)
        {
            DG_Product.AllowUserToAddRows = false;
        }
    }
    }

