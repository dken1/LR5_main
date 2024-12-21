using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LR5.DBContent;
using LR5.BuilderBurger;
using LR5.BuilderBurger.BuilderBurger;

namespace LR5
{
    public partial class Form1 : Form
    {
        Model1 model = new Model1();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void btAdd_Click(object sender, EventArgs e)
        {
            BurgerBuilder burgerBuilder = new BurgerBuilder();
            BurgerDirector burgerDirector = new BurgerDirector(burgerBuilder);

            if (cbBurger.SelectedItem.ToString() == "Бургер стандартный")
            {
                burgerDirector.BuildDefault();
            }
            else
            {
                burgerDirector.BuildWithBacon();
            }
            try
            {
                model.Burgers.Add(burgerBuilder.GetBurgers());
                model.SaveChanges();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            LoadData();
        }
        private void LoadData()
        {
            cbBurger.SelectedIndex = 0;
            dataGridView1.DataSource = model.Burgers.ToList();
        }
    }
}
