using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RecipeProject_CSharp
{
    public partial class EditItemForm : Form
    {
        public Ingredient ingred;
        public EditItemForm(Ingredient ingred)
        {
            InitializeComponent();
            tb_ei_ingred.Text = ingred.name;
            cb_ei_unit.Text = ingred.unit;
            tb_ei_quan.Text = ingred.quantity + "";
        }

        private void btn_ei_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ei_ok_Click(object sender, EventArgs e)
        {
            string newItem = tb_ei_ingred.Text;
            string unit = cb_ei_unit.Text;
            int quan;
            if (Int32.TryParse(tb_ei_quan.Text, out int result))
            {
                quan = result;
                Ingredient newIngred = new Ingredient(quan, unit, newItem);

                tb_ei_ingred.Text = "";
                tb_ei_quan.Text = "";

                ingred = newIngred;
            }
            this.Close();
        }
    }
}
