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

namespace Lab_3
{
    public partial class Form1 : Form
    {
        public List<Allergens> ListAllergens = new List<Allergens>();
        public List<Recipe> recipeCollection = new List<Recipe>();
        public string allergensCurFile = "allergens.txt";
        public string recipeCurFile = "recipe.txt";

        public Form1()
        {
           
            InitializeComponent();
           
        }

        public void SetupData()
        {
            Allergens a1 = new Allergens("A01", "Fish");
            Allergens a2 = new Allergens("A02", "Soy");
            Allergens a3 = new Allergens("A03", "Peanuts");
            Allergens a4 = new Allergens("A04", "Eggs");
            Allergens a5 = new Allergens("A05", "Gluten");

            ListAllergens.Add(a1); ListAllergens.Add(a2); ListAllergens.Add(a3);
            ListAllergens.Add(a4); ListAllergens.Add(a5);
            SetupDataForAllergensTab();

            List<string> ra1 = new List<string>() { "Eggs", "Gluten" };
            List<string> ra2 = new List<string>() { "Eggs", "Gluten", "Fish", "Soy" };
            List<string> ra3 = new List<string>() { "Eggs" };
            List<string> ra4 = new List<string>() { "Peanuts", "Fish" };
            List<string> ra5 = new List<string>() { "Fish" };
            List<string> ra6 = new List<string>() { "Gluten" };
            List<string> ra7 = new List<string>() { "Soy", "Fish" };

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
        }

        

        
        private void Form1_Load(object sender, EventArgs e)
        {
            SetupData();
        
        }

        private void SetupDataForAllergensTab()
        {
            
            foreach (Allergens a in ListAllergens)
            {
                listView1.Items.Add(new ListViewItem(new string[] { a.Code, a.Name }));
            }
        }

        private void SetupDataForRecipeTab()
        {
           
            foreach (Recipe r in recipeCollection)
            {
                string allergies = string.Join(",", r.recipeBookAllergens);
                listView2.Items.Add(new ListViewItem(new string[] { r.recipeBookCode, r.recipeBookName, allergies }));
            }
        }

        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listView1.SelectedItems)
            {
                this.txtAllergensCode.Text = x.SubItems[0].Text;
                this.txtAllergensName.Text = x.SubItems[1].Text;
            }
        }

        private void btnAllergensEdit_Click(object sender, EventArgs e)
        {
            if (btnAllergensEdit.Text == "Edit")
            {
                btnAllergensEdit.Text = "Save";
                this.txtAllergensCode.Enabled = true;
                this.txtAllergensName.Enabled = true;
            }
            else
            {
                foreach (ListViewItem x in listView1.SelectedItems)
                {
                    ListAllergens.RemoveAt(x.Index);
                    ListAllergens.Add(new Allergens(this.txtAllergensCode.Text, this.txtAllergensCode.Text));

                    x.SubItems[0].Text = this.txtAllergensCode.Text;
                    x.SubItems[1].Text = this.txtAllergensCode.Text;
                }
                btnAllergensEdit.Text = "Edit";
                this.txtAllergensCode.Enabled = false;
                this.txtAllergensName.Enabled = false;
            }
        }

        private void btnAllergensDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listView1.SelectedItems)
            {
                ListAllergens.RemoveAt(x.Index);
                listView1.Items.RemoveAt(x.Index);
            }

            txtAllergensCode.Text = "";
            txtAllergensName.Text = "";
        }

        private void btnAllergensAdd_Click(object sender, EventArgs e)
        {
            if (btnAllergensAdd.Text == "Add")
            {
                btnAllergensAdd.Text = "Save";
                this.txtAllergensCode.Text = "";
                this.txtAllergensName.Text = "";
                this.txtAllergensCode.Enabled = true;
                this.txtAllergensName.Enabled = true;
            }
            else
            {
                ListAllergens.Add(new Allergens(this.txtAllergensCode.Text, this.txtAllergensName.Text));

                string[] row = { this.txtAllergensCode.Text, this.txtAllergensName.Text };
                var listViewItem = new ListViewItem(row);

                this.listView1.Items.Add(listViewItem);

                btnAllergensAdd.Text = "Add";
                this.txtAllergensCode.Enabled = false;
                this.txtAllergensName.Enabled = false;
            }
        }

       
        private void btnRecipeEdit_Click(object sender, EventArgs e)
        {
            if (btnRecipeEdit.Text == "Edit")
            {
                btnRecipeEdit.Text = "Save";
                this.txtRecipeCode.Enabled = true;
                this.txtRecipeName.Enabled = true;
                this.txtRecipeAllergens.Enabled = true;
            }
            else
            {
                foreach (ListViewItem x in listView2.SelectedItems)
                {
                    recipeCollection.RemoveAt(x.Index);
                    List<string> allergies = this.txtRecipeAllergens.Text.Split(',').ToList();
                    recipeCollection.Add(new Recipe(this.txtRecipeCode.Text, this.txtRecipeName.Text, allergies));

                    x.SubItems[0].Text = this.txtRecipeCode.Text;
                    x.SubItems[1].Text = this.txtRecipeName.Text;
                    x.SubItems[2].Text = this.txtRecipeAllergens.Text;

                }
                btnRecipeEdit.Text = "Edit";
                this.txtRecipeCode.Enabled = false;
                this.txtRecipeName.Enabled = false;
                this.txtRecipeAllergens.Enabled = false;
            }
        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listView2.SelectedItems)
            {
                this.txtRecipeCode.Text = x.SubItems[0].Text;
                this.txtRecipeName.Text = x.SubItems[1].Text;
                this.txtRecipeAllergens.Text = x.SubItems[2].Text;
            }
        }

        private void btnRecipeDelete_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem x in listView2.SelectedItems)
            {
                recipeCollection.RemoveAt(x.Index);
                listView2.Items.RemoveAt(x.Index);
            }

            txtRecipeCode.Text = "";
            txtRecipeName.Text = "";
            txtRecipeAllergens.Text = "";
        }

        private void btnRecipeAdd_Click(object sender, EventArgs e)
        {
            if (btnRecipeAdd.Text == "Add")
            {
                btnRecipeAdd.Text = "Save";
                this.txtRecipeCode.Text = "";
                this.txtRecipeName.Text = "";
                this.txtRecipeAllergens.Text = "";
                this.txtRecipeCode.Enabled = true;
                this.txtRecipeName.Enabled = true;
                this.txtRecipeAllergens.Enabled = true;
            }
            else
            {
                List<string> allergies = this.txtRecipeAllergens.Text.Split(new char[] { ',' }).ToList();
                recipeCollection.Add(new Recipe(this.txtRecipeCode.Text, this.txtRecipeName.Text, allergies));

                string[] row = { this.txtRecipeCode.Text, this.txtRecipeName.Text, this.txtRecipeAllergens.Text };
                var listViewItem = new ListViewItem(row);

                listView2.Items.Add(listViewItem);

                btnRecipeAdd.Text = "Add";
                this.txtRecipeCode.Enabled = false;
                this.txtRecipeName.Enabled = false;
                this.txtRecipeAllergens.Enabled = false;
            }
        }

        
        private void btnCalculateAverage_Click(object sender, EventArgs e)
        {
            txtAverageAllergen.Text = "";
            int recipeCount = 0, allergenCount = 0;

            foreach (Recipe r in recipeCollection)
            {
                recipeCount++;
                foreach (string s in r.recipeBookAllergens)
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

            foreach (Recipe r in recipeCollection)
            {
                foreach (string s in r.recipeBookAllergens)
                {
                    if (!CountAllergies.ContainsKey(s))
                    {
                        CountAllergies.Add(s, 0);
                    }
                }
            }

            foreach (Recipe r in recipeCollection)
            {
                foreach (string s in r.recipeBookAllergens)
                {
                    if (r.recipeBookAllergens.Contains(s))
                    {
                        CountAllergies[s] += 1;
                    }
                }
            }

            var keyOfMaxValue = CountAllergies.Aggregate((x, y) => x.Value > y.Value ? x : y).Key;

            this.txtFoundAllergen.Text = keyOfMaxValue.ToString();
            CountAllergies.Clear();
        }

        private void btnSearchRecipes_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem l in listView3.Items)
            {
                listView3.Items.RemoveAt(l.Index);
            }

            List<string> searchAllergies = this.txtSearchAllergens.Text.Split(new char[] { ',' }).ToList();
            List<string> foundRecipes = new List<string>();

            int counter = searchAllergies.Count;
            int x = 0;

            foreach (Recipe r in recipeCollection)
            {
                foreach (string s in searchAllergies)
                {
                    if (r.recipeBookAllergens.Contains(s))
                    {
                        x++;
                    }
                }

                if (x == 0)
                {
                    foundRecipes.Add(r.recipeBookName);
                    x = 0;
                }
                x = 0;
            }

            foreach (string f in foundRecipes)
            {
                listView3.Items.Add(new ListViewItem(new string[] { f }));
            }
            searchAllergies.Clear();
            foundRecipes.Clear();
        }

        
        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }
    }
}
