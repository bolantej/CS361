using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace RecipeProject_CSharp
{
    public partial class AddIngredForm : Form
    {
        public Ingredient[] ingredients { get; set; }
        public int currIngreds { get; set; }
        public AddIngredForm()
        {
            InitializeComponent();
            ingredients = new Ingredient[3];
        }

        public void setIngredRows(int newIngreds)
        {
            for (int i = 0; i < currIngreds; i++)
            {
                Console.WriteLine("Printing: " + ingredients[i].ToString());
                DataGridViewRow row = (DataGridViewRow)dgr_ai_currIngreds.Rows[0].Clone();
                row.Cells[0].Value = ingredients[i].quantity;
                row.Cells[1].Value = ingredients[i].unit;
                row.Cells[2].Value = ingredients[i].name;

                dgr_ai_currIngreds.Rows.Add(row);
            }
        }

        private void btn_ai_quit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_ai_addingred_Click(object sender, EventArgs e)
        {
            string newItem = tb_ai_ingred.Text;
            string unit = cb_ai_unit.Text;

            int quan;
            if (Int32.TryParse(tb_ai_quan.Text, out int result))
            {
                quan = result;
                Ingredient newIngred = new Ingredient(quan, unit, newItem);
                currIngreds++;
                addIngredient(newIngred);

                tb_ai_ingred.Text = "";
                tb_ai_quan.Text = "";
                cb_ai_unit.Text = "";
            }
            else
            {
                lbl_ai_quan.Text = "womp womp";
            }
                //throw error for invalid entry
        }


        private void addIngredient(Ingredient ingred)
        {
            if(ingredients.Length < currIngreds)
            {
                Ingredient[] newIngreds = new Ingredient[ingredients.Length + 1];
                for(int i = 0; i < ingredients.Length; i++)
                    newIngreds[i] = ingredients[i];
                ingredients = newIngreds;
            }
            ingredients[currIngreds - 1] = ingred;

            DataGridViewRow row = (DataGridViewRow)dgr_ai_currIngreds.Rows[0].Clone();
            row.Cells[0].Value = ingred.quantity;
            row.Cells[1].Value = ingred.unit;
            row.Cells[2].Value = ingred.name;

            dgr_ai_currIngreds.Rows.Add(row);
        }

        private void dgr_ai_currIngreds_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var senderGrid = (DataGridView)sender;

            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0)
            {
                if(e.ColumnIndex == 3) //edit
                {
                    EditItemForm editItemForm = new EditItemForm(ingredients[e.RowIndex]);
                    editItemForm.ShowDialog();
                    ingredients[e.RowIndex] = editItemForm.ingred;
                    Console.WriteLine(editItemForm.ingred.quantity + " " + editItemForm.ingred.name);
                    dgr_ai_currIngreds.Rows[e.RowIndex].Cells[0].Value = editItemForm.ingred.quantity;
                    dgr_ai_currIngreds.Rows[e.RowIndex].Cells[1].Value = editItemForm.ingred.unit;
                    dgr_ai_currIngreds.Rows[e.RowIndex].Cells[2].Value = editItemForm.ingred.name;
                }
                else if (e.ColumnIndex == 4) //delete
                {
                    dgr_ai_currIngreds.Rows.RemoveAt(e.RowIndex);
                    for (int i = e.RowIndex; i < currIngreds; i++)
                        ingredients[i] = ingredients[i + 1];
                    currIngreds--;
                }
                else { //error
                       }
            }
        }
    }
}
