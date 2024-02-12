using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace RecipeProject_CSharp
{
    public partial class Form1 : Form
    {
        public Ingredient[] ingredients { get; set; }
        public int currIngreds { get; set; }
        private SaveFileDialog save;
        private OpenFileDialog ofd;
        public Form1()
        {
            InitializeComponent();
            ingredients = new Ingredient[3];
            save = new SaveFileDialog();
            ofd = new OpenFileDialog();
        }

        private void btn_mf_add_Click(object sender, EventArgs e)
        {
            AddIngredForm addIngredForm = new AddIngredForm();
            addIngredForm.ingredients = this.ingredients;
            addIngredForm.currIngreds = this.currIngreds;
            addIngredForm.setIngredRows(currIngreds);
            addIngredForm.ShowDialog();
            ingredients = addIngredForm.ingredients;
            currIngreds = addIngredForm.currIngreds;
            for (int i = 0; i < currIngreds; i++)
                Console.WriteLine(ingredients[i].ToString());
        }

        private void btn_mf_save_Click(object sender, EventArgs e)
        {
            if (save.ShowDialog() == DialogResult.OK)
            {
                string fileName = save.FileName;

                StreamWriter file = new StreamWriter(fileName);
                file.WriteLine(currIngreds);
                for (int i = 0; i < currIngreds; i++)
                    file.WriteLine(ingredients[i].ToSaveString());
                file.Close();
            }
        }

        private void btn_mf_load_Click(object sender, EventArgs e)
        {
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string fileName = ofd.FileName;
                Console.WriteLine(fileName);

                StreamReader file = new StreamReader(fileName);

                string temp = file.ReadLine();
                currIngreds = Int32.Parse(temp);
                ingredients = new Ingredient[currIngreds];
                for(int i = 0; i < currIngreds; i++)
                {
                    string[] currLine = file.ReadLine().Split(',');
                    Console.WriteLine(currLine[0] + " " + currLine[1] + " " + currLine[2]);
                    int quan = Int32.Parse(currLine[0]);
                    string unit = currLine[1];
                    string name = currLine[2];
                    Ingredient newIngred = new Ingredient(quan, unit, name);
                    ingredients[i] = newIngred;
                    Console.WriteLine(ingredients[i].ToString());
                    Console.WriteLine(ingredients.Length);
                }
                Console.WriteLine(ingredients[0].ToString());

            }
            else { Console.WriteLine("oops"); }

            Console.WriteLine(ingredients[0].ToString());
        }
    }
}
