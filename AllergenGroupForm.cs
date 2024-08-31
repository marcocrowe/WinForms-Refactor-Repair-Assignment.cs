using Lab_3;
using System;
using System.Windows.Forms;
using System.Linq;

namespace AllergyInfoApp;
public partial class AllergenGroupForm : Form
{
    private readonly Form1 form1;
    public AllergenGroupForm(Form1 form1)
    {
        this.form1 = form1;
        InitializeComponent();
    }
    private void SetupDataForAllergensTab()
    {
        foreach (Allergens a in form1.ListAllergens)
        {
            listView1.Items.Add(new ListViewItem([a.Code, a.Name]));
        }
    }
    #region Event Handlers
    #endregion
    private void AllergenGroupForm_Load(object sender, EventArgs e) => SetupDataForAllergensTab();
    private void btnAllergensDelete_Click(object sender, EventArgs e)
    {
        foreach (ListViewItem x in listView1.SelectedItems)
        {
            int allergenNameColumnIndex = 1; // Assuming the allergen name is in the second column
            string allergenName = x.SubItems[allergenNameColumnIndex].Text; // Assuming the allergen name is in the second column
            string boxText = $"Are you sure you want to delete the allergen '{allergenName}'?";
            DialogResult result = MessageBox.Show(boxText, "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result != DialogResult.Yes)
                break;

            form1.ListAllergens.RemoveAt(x.Index);
            listView1.Items.RemoveAt(x.Index);
        }

        allergensCodeTextBox.Text = "";
        allergensNameTextBox.Text = "";
    }
    private void btnAllergensAdd_Click(object sender, EventArgs e)
    {
        if (btnAllergensAdd.Text == "Add")
        {
            btnAllergensAdd.Text = "Save";
            allergensCodeTextBox.Text = "";
            allergensNameTextBox.Text = "";
            allergensCodeTextBox.Enabled = true;
            allergensNameTextBox.Enabled = true;
        }
        else
        {
            if (String.IsNullOrWhiteSpace(allergensCodeTextBox.Text))
            {
                allergensCodeTextBox.Text = $"000{form1.ListAllergens.Count}";
                allergensNameTextBox.Text = $"Test Allergen {form1.ListAllergens.Count}";
            }

            bool codeExists = form1.ListAllergens.Exists(allergen => allergen.Code == allergensCodeTextBox.Text);
            if (codeExists)
            {
                MessageBox.Show("The allergen code already exists. Please enter a unique code.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            form1.ListAllergens.Add(new Allergens(allergensCodeTextBox.Text, allergensNameTextBox.Text));

            string[] row = [allergensCodeTextBox.Text, allergensNameTextBox.Text];
            var listViewItem = new ListViewItem(row);

            listView1.Items.Add(listViewItem);

            btnAllergensAdd.Text = "Add";
            allergensCodeTextBox.Enabled = false;
            allergensNameTextBox.Enabled = false;
        }
    }
    private void listView1_SelectedIndexChanged(object sender, EventArgs e)
    {
        foreach (ListViewItem x in listView1.SelectedItems)
        {
            allergensCodeTextBox.Text = x.SubItems[0].Text;
            allergensNameTextBox.Text = x.SubItems[1].Text;
        }
    }
    private void btnAllergensEdit_Click(object sender, EventArgs e)
    {
        if (btnAllergensEdit.Text == "Edit")
        {
            btnAllergensEdit.Text = "Save";
            allergensCodeTextBox.Enabled = true;
            allergensNameTextBox.Enabled = true;
        }
        else
        {
            foreach (ListViewItem x in listView1.SelectedItems)
            {
                form1.ListAllergens.RemoveAt(x.Index);
                form1.ListAllergens.Add(new Allergens(this.allergensCodeTextBox.Text, this.allergensCodeTextBox.Text));

                x.SubItems[0].Text = this.allergensCodeTextBox.Text;
                x.SubItems[1].Text = this.allergensNameTextBox.Text;
            }
            btnAllergensEdit.Text = "Edit";
            allergensCodeTextBox.Enabled = false;
            allergensNameTextBox.Enabled = false;
        }
    }
}
