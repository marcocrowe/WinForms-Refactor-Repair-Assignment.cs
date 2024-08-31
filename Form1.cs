using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using AllergyInfoApp;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public List<Allergens> ListAllergens = [];
        public List<Recipe> recipeCollection = [];
        public string allergensCurFile = "allergens.txt";
        public string recipeCurFile = "recipe.txt";

        public Form1()
        {
            InitializeComponent();
        }

        public void SetupData()
        {
            ListAllergens =
            [
                new Allergens("A01", "Fish"),
                new Allergens("A02", "Soy"),
                new Allergens("A03", "Peanuts"),
                new Allergens("A04", "Eggs"),
                new Allergens("A05", "Gluten")
            ];


            List<string> ra1 = ["Eggs", "Gluten"];
            List<string> ra2 = ["Eggs", "Gluten", "Fish", "Soy"];
            List<string> ra3 = ["Eggs"];
            List<string> ra4 = ["Peanuts", "Fish"];
            List<string> ra5 = ["Fish"];
            List<string> ra6 = ["Gluten"];
            List<string> ra7 = ["Soy", "Fish"];

            Recipe r1 = new Recipe("R001", "Chicken pata bake", ra1);
            Recipe r2 = new Recipe("R002", "Chicken Casserole", ra2);
            Recipe r3 = new Recipe("R003", "Burgers", ra3);
            Recipe r4 = new Recipe("R101", "Pork Tacos", ra4);
            Recipe r5 = new Recipe("R099", "Prawn Titka Masala", ra5);
            Recipe r6 = new Recipe("R011", "Lasagne", ra6);
            Recipe r7 = new Recipe("R012", "Puttanesca", ra7);

            recipeCollection.Add(r1); recipeCollection.Add(r2); recipeCollection.Add(r3);
            recipeCollection.Add(r4); recipeCollection.Add(r5); recipeCollection.Add(r6);
            recipeCollection.Add(r7);
            SetupDataForRecipeTab();
            PopulateAllergenComboBox();
        }

        private void PopulateAllergenComboBox()
        {
            recipeAllergensComboBox.Items.Clear();
            foreach(var allergen in ListAllergens)
            {
                recipeAllergensComboBox.Items.Add(allergen.Name);
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            SetupData();

        }

        private void SetupDataForRecipeTab()
        {

            foreach(Recipe r in recipeCollection)
            {
                string allergies = string.Join(",", r.recipeBookAllergens);
                listView2.Items.Add(new ListViewItem([r.recipeBookCode, r.recipeBookName, allergies]));
            }
        }





        private static readonly bool Debug = false;

        public static int Login(String username, String password)
        {
            if(Debug)
                return 1; // Return the admin user

            if(username == "admin" && password == "admin")
                return 1;
            return 0; // Return the normal user
        }



        private void btnRecipeEdit_Click(object sender, EventArgs e)
        {
            if(btnRecipeEdit.Text == "Edit")
            {
                btnRecipeEdit.Text = "Save";
                txtRecipeCode.Enabled = true;
                txtRecipeName.Enabled = true;
                recipeAllergensComboBox.Enabled = true;
            }
            else
            {
                foreach(ListViewItem x in listView2.SelectedItems)
                {
                    recipeCollection.RemoveAt(x.Index);
                    List<string> allergies = new List<string>();
                    foreach(var item in recipeAllergensComboBox.Items)
                    {
                        allergies.Add(item.ToString());
                    }
                    recipeCollection.Add(new Recipe(this.txtRecipeCode.Text, this.txtRecipeName.Text, allergies));

                    x.SubItems[0].Text = this.txtRecipeCode.Text;
                    x.SubItems[1].Text = this.txtRecipeName.Text;
                    x.SubItems[2].Text = string.Join(",", allergies);
                }
                btnRecipeEdit.Text = "Edit";
                txtRecipeCode.Enabled = false;
                txtRecipeName.Enabled = false;
                recipeAllergensComboBox.Enabled = false;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach(ListViewItem x in listView2.SelectedItems)
            {
                txtRecipeCode.Text = x.SubItems[0].Text;
                txtRecipeName.Text = x.SubItems[1].Text;
                recipeAllergensComboBox.SelectedItem = x.SubItems[2].Text;
            }
        }

        private void btnRecipeDelete_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem x in listView2.SelectedItems)
            {
                recipeCollection.RemoveAt(x.Index);
                listView2.Items.RemoveAt(x.Index);
            }

            txtRecipeCode.Text = "";
            txtRecipeName.Text = "";
            recipeAllergensComboBox.SelectedIndex = -1;
        }

        private void btnRecipeAdd_Click(object sender, EventArgs e)
        {
            if(btnRecipeAdd.Text == "Add")
            {
                btnRecipeAdd.Text = "Save";
                this.txtRecipeCode.Text = "";
                this.txtRecipeName.Text = "";
                //Task 5 : Replace with DropDownList
                this.recipeAllergensComboBox.Text = "";
                this.txtRecipeCode.Enabled = true;
                this.txtRecipeName.Enabled = true;
                this.recipeAllergensComboBox.Enabled = true;
            }
            else
            {
                List<string> allergies = this.recipeAllergensComboBox.Text.Split([',']).ToList();
                recipeCollection.Add(new Recipe(this.txtRecipeCode.Text, this.txtRecipeName.Text, allergies));

                string[] row = [txtRecipeCode.Text, this.txtRecipeName.Text, this.recipeAllergensComboBox.Text];
                var listViewItem = new ListViewItem(row);

                listView2.Items.Add(listViewItem);

                btnRecipeAdd.Text = "Add";
                txtRecipeCode.Enabled = false;
                txtRecipeName.Enabled = false;
                recipeAllergensComboBox.Enabled = false;
            }
        }


        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            txtAverageAllergen.Text = "";
            int recipeCount = 0, allergenCount = 0;

            foreach(Recipe r in recipeCollection)
            {
                recipeCount++;
                foreach(string s in r.recipeBookAllergens)
                {
                    allergenCount++;
                }
            }

            int averageAllergens = allergenCount / recipeCount;
            txtAverageAllergen.Text = averageAllergens.ToString();
        }

        private void btnFindAllergen_Click(object sender, EventArgs e)
        {
            Dictionary<string, int> CountAllergies = new Dictionary<string, int>();

            foreach(Recipe r in recipeCollection)
            {
                foreach(string s in r.recipeBookAllergens)
                {
                    if(!CountAllergies.ContainsKey(s))
                    {
                        CountAllergies.Add(s, 0);
                    }
                }
            }

            foreach(Recipe r in recipeCollection)
            {
                foreach(string s in r.recipeBookAllergens)
                {
                    if(r.recipeBookAllergens.Contains(s))
                    {
                        CountAllergies[s] += 1;
                    }
                }
            }

            var keyOfMaxValue = CountAllergies.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            txtFoundAllergen.Text = keyOfMaxValue;
            CountAllergies.Clear();
        }

        private void btnSearchRecipes_Click(object sender, EventArgs e)
        {
            foreach(ListViewItem l in listView3.Items)
            {
                listView3.Items.RemoveAt(l.Index);
            }

            List<string> searchAllergies = txtSearchAllergens.Text.Split([',']).ToList();
            List<string> foundRecipes = [];

            int counter = searchAllergies.Count;
            int x = 0;

            foreach(Recipe r in recipeCollection)
            {
                foreach(string s in searchAllergies)
                {
                    if(r.recipeBookAllergens.Contains(s))
                        x++;
                }

                if(x == 0)
                    foundRecipes.Add(r.recipeBookName);
                x = 0;
            }

            foreach(string f in foundRecipes)
            {
                listView3.Items.Add(new ListViewItem([f]));
            }
            searchAllergies.Clear();
            foundRecipes.Clear();
        }


        private void openAllergensPanelButton_Click(object sender, EventArgs e)
        {
            AllergenGroupForm allergenGroupForm = new AllergenGroupForm(this);
            allergenGroupForm.Show();
        }

        private void txtRecipeAllergens_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
