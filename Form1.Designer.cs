
namespace Lab_3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if(disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnRecipeDelete = new System.Windows.Forms.Button();
            btnRecipeEdit = new System.Windows.Forms.Button();
            btnRecipeAdd = new System.Windows.Forms.Button();
            lblRecipeAllergens = new System.Windows.Forms.Label();
            lblRecipeName = new System.Windows.Forms.Label();
            txtRecipeAllergens = new System.Windows.Forms.TextBox();
            txtRecipeName = new System.Windows.Forms.TextBox();
            txtRecipeCode = new System.Windows.Forms.TextBox();
            lblRecipeCode = new System.Windows.Forms.Label();
            listView2 = new System.Windows.Forms.ListView();
            recipeCode = new System.Windows.Forms.ColumnHeader();
            recipeName = new System.Windows.Forms.ColumnHeader();
            recipeAllergens = new System.Windows.Forms.ColumnHeader();
            label1 = new System.Windows.Forms.Label();
            btnCalculateAverage = new System.Windows.Forms.Button();
            lblFindAllergen = new System.Windows.Forms.Label();
            btnFindAllergen = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            btnSearchRecipes = new System.Windows.Forms.Button();
            txtAverageAllergen = new System.Windows.Forms.TextBox();
            txtFoundAllergen = new System.Windows.Forms.TextBox();
            txtSearchAllergens = new System.Windows.Forms.TextBox();
            listView3 = new System.Windows.Forms.ListView();
            lvsearchRecipes = new System.Windows.Forms.ColumnHeader();
            groupBox2 = new System.Windows.Forms.GroupBox();
            groupBox3 = new System.Windows.Forms.GroupBox();
            openAllergensPanelButton = new System.Windows.Forms.Button();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // btnRecipeDelete
            // 
            btnRecipeDelete.Location = new System.Drawing.Point(653, 383);
            btnRecipeDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRecipeDelete.Name = "btnRecipeDelete";
            btnRecipeDelete.Size = new System.Drawing.Size(119, 47);
            btnRecipeDelete.TabIndex = 9;
            btnRecipeDelete.Text = "Delete";
            btnRecipeDelete.UseVisualStyleBackColor = true;
            btnRecipeDelete.Click += btnRecipeDelete_Click;
            // 
            // btnRecipeEdit
            // 
            btnRecipeEdit.Location = new System.Drawing.Point(829, 298);
            btnRecipeEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRecipeEdit.Name = "btnRecipeEdit";
            btnRecipeEdit.Size = new System.Drawing.Size(119, 47);
            btnRecipeEdit.TabIndex = 8;
            btnRecipeEdit.Text = "Edit";
            btnRecipeEdit.UseVisualStyleBackColor = true;
            btnRecipeEdit.Click += btnRecipeEdit_Click;
            // 
            // btnRecipeAdd
            // 
            btnRecipeAdd.Location = new System.Drawing.Point(653, 298);
            btnRecipeAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnRecipeAdd.Name = "btnRecipeAdd";
            btnRecipeAdd.Size = new System.Drawing.Size(119, 47);
            btnRecipeAdd.TabIndex = 7;
            btnRecipeAdd.Text = "Add";
            btnRecipeAdd.UseVisualStyleBackColor = true;
            btnRecipeAdd.Click += btnRecipeAdd_Click;
            // 
            // lblRecipeAllergens
            // 
            lblRecipeAllergens.AutoSize = true;
            lblRecipeAllergens.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblRecipeAllergens.Location = new System.Drawing.Point(577, 203);
            lblRecipeAllergens.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecipeAllergens.Name = "lblRecipeAllergens";
            lblRecipeAllergens.Size = new System.Drawing.Size(100, 25);
            lblRecipeAllergens.TabIndex = 6;
            lblRecipeAllergens.Text = "Allergens :";
            // 
            // lblRecipeName
            // 
            lblRecipeName.AutoSize = true;
            lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblRecipeName.Location = new System.Drawing.Point(609, 113);
            lblRecipeName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecipeName.Name = "lblRecipeName";
            lblRecipeName.Size = new System.Drawing.Size(71, 25);
            lblRecipeName.TabIndex = 5;
            lblRecipeName.Text = "Name :";
            // 
            // txtRecipeAllergens
            // 
            txtRecipeAllergens.Enabled = false;
            txtRecipeAllergens.Location = new System.Drawing.Point(697, 198);
            txtRecipeAllergens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtRecipeAllergens.Name = "txtRecipeAllergens";
            txtRecipeAllergens.Size = new System.Drawing.Size(293, 31);
            txtRecipeAllergens.TabIndex = 4;
            // 
            // txtRecipeName
            // 
            txtRecipeName.Enabled = false;
            txtRecipeName.Location = new System.Drawing.Point(697, 108);
            txtRecipeName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtRecipeName.Name = "txtRecipeName";
            txtRecipeName.Size = new System.Drawing.Size(293, 31);
            txtRecipeName.TabIndex = 3;
            // 
            // txtRecipeCode
            // 
            txtRecipeCode.Enabled = false;
            txtRecipeCode.Location = new System.Drawing.Point(697, 32);
            txtRecipeCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtRecipeCode.Name = "txtRecipeCode";
            txtRecipeCode.Size = new System.Drawing.Size(293, 31);
            txtRecipeCode.TabIndex = 1;
            // 
            // lblRecipeCode
            // 
            lblRecipeCode.AutoSize = true;
            lblRecipeCode.Font = new System.Drawing.Font("Segoe UI", 11F);
            lblRecipeCode.Location = new System.Drawing.Point(616, 37);
            lblRecipeCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRecipeCode.Name = "lblRecipeCode";
            lblRecipeCode.Size = new System.Drawing.Size(65, 25);
            lblRecipeCode.TabIndex = 2;
            lblRecipeCode.Text = "Code :";
            // 
            // listView2
            // 
            listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { recipeCode, recipeName, recipeAllergens });
            listView2.GridLines = true;
            listView2.Location = new System.Drawing.Point(24, 37);
            listView2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listView2.Name = "listView2";
            listView2.Size = new System.Drawing.Size(473, 439);
            listView2.TabIndex = 0;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = System.Windows.Forms.View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // recipeCode
            // 
            recipeCode.Text = "Code";
            // 
            // recipeName
            // 
            recipeName.Text = "Name";
            recipeName.Width = 120;
            // 
            // recipeAllergens
            // 
            recipeAllergens.Text = "Allergens";
            recipeAllergens.Width = 150;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(9, 43);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(324, 25);
            label1.TabIndex = 0;
            label1.Text = "Average number of allergens in recipes:\r\n";
            // 
            // btnCalculateAverage
            // 
            btnCalculateAverage.Location = new System.Drawing.Point(593, 37);
            btnCalculateAverage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnCalculateAverage.Name = "btnCalculateAverage";
            btnCalculateAverage.Size = new System.Drawing.Size(107, 38);
            btnCalculateAverage.TabIndex = 3;
            btnCalculateAverage.Text = "Calculate";
            btnCalculateAverage.UseVisualStyleBackColor = true;
            btnCalculateAverage.Click += btnCalculateAverage_Click;
            // 
            // lblFindAllergen
            // 
            lblFindAllergen.AutoSize = true;
            lblFindAllergen.Location = new System.Drawing.Point(83, 113);
            lblFindAllergen.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblFindAllergen.Name = "lblFindAllergen";
            lblFindAllergen.Size = new System.Drawing.Size(245, 25);
            lblFindAllergen.TabIndex = 5;
            lblFindAllergen.Text = "Find most common allergen: ";
            // 
            // btnFindAllergen
            // 
            btnFindAllergen.Location = new System.Drawing.Point(593, 107);
            btnFindAllergen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnFindAllergen.Name = "btnFindAllergen";
            btnFindAllergen.Size = new System.Drawing.Size(107, 38);
            btnFindAllergen.TabIndex = 7;
            btnFindAllergen.Text = "Find";
            btnFindAllergen.UseVisualStyleBackColor = true;
            btnFindAllergen.Click += btnFindAllergen_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(169, 183);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(156, 25);
            label3.TabIndex = 8;
            label3.Text = "Search for recipes:";
            // 
            // btnSearchRecipes
            // 
            btnSearchRecipes.Location = new System.Drawing.Point(593, 178);
            btnSearchRecipes.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            btnSearchRecipes.Name = "btnSearchRecipes";
            btnSearchRecipes.Size = new System.Drawing.Size(107, 38);
            btnSearchRecipes.TabIndex = 10;
            btnSearchRecipes.Text = "Search";
            btnSearchRecipes.UseVisualStyleBackColor = true;
            btnSearchRecipes.Click += btnSearchRecipes_Click;
            // 
            // txtAverageAllergen
            // 
            txtAverageAllergen.Location = new System.Drawing.Point(326, 37);
            txtAverageAllergen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtAverageAllergen.Name = "txtAverageAllergen";
            txtAverageAllergen.ReadOnly = true;
            txtAverageAllergen.Size = new System.Drawing.Size(257, 31);
            txtAverageAllergen.TabIndex = 4;
            // 
            // txtFoundAllergen
            // 
            txtFoundAllergen.Location = new System.Drawing.Point(326, 107);
            txtFoundAllergen.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtFoundAllergen.Name = "txtFoundAllergen";
            txtFoundAllergen.ReadOnly = true;
            txtFoundAllergen.Size = new System.Drawing.Size(257, 31);
            txtFoundAllergen.TabIndex = 6;
            // 
            // txtSearchAllergens
            // 
            txtSearchAllergens.Location = new System.Drawing.Point(326, 178);
            txtSearchAllergens.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            txtSearchAllergens.Name = "txtSearchAllergens";
            txtSearchAllergens.Size = new System.Drawing.Size(257, 31);
            txtSearchAllergens.TabIndex = 9;
            // 
            // listView3
            // 
            listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { lvsearchRecipes });
            listView3.GridLines = true;
            listView3.Location = new System.Drawing.Point(747, 37);
            listView3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            listView3.Name = "listView3";
            listView3.Size = new System.Drawing.Size(403, 384);
            listView3.TabIndex = 11;
            listView3.UseCompatibleStateImageBehavior = false;
            listView3.View = System.Windows.Forms.View.Details;
            // 
            // lvsearchRecipes
            // 
            lvsearchRecipes.Text = "Recipes";
            lvsearchRecipes.Width = 179;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(listView2);
            groupBox2.Controls.Add(lblRecipeCode);
            groupBox2.Controls.Add(lblRecipeName);
            groupBox2.Controls.Add(txtRecipeAllergens);
            groupBox2.Controls.Add(lblRecipeAllergens);
            groupBox2.Controls.Add(txtRecipeName);
            groupBox2.Controls.Add(btnRecipeAdd);
            groupBox2.Controls.Add(txtRecipeCode);
            groupBox2.Controls.Add(btnRecipeEdit);
            groupBox2.Controls.Add(btnRecipeDelete);
            groupBox2.Location = new System.Drawing.Point(17, 20);
            groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox2.Size = new System.Drawing.Size(999, 523);
            groupBox2.TabIndex = 13;
            groupBox2.TabStop = false;
            groupBox2.Text = "Recipes";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(txtAverageAllergen);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(btnCalculateAverage);
            groupBox3.Controls.Add(listView3);
            groupBox3.Controls.Add(lblFindAllergen);
            groupBox3.Controls.Add(txtSearchAllergens);
            groupBox3.Controls.Add(btnFindAllergen);
            groupBox3.Controls.Add(txtFoundAllergen);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(btnSearchRecipes);
            groupBox3.Location = new System.Drawing.Point(27, 570);
            groupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            groupBox3.Size = new System.Drawing.Size(1310, 553);
            groupBox3.TabIndex = 14;
            groupBox3.TabStop = false;
            groupBox3.Text = "Statistics";
            // 
            // openAllergensPanelButton
            // 
            openAllergensPanelButton.Location = new System.Drawing.Point(1105, 68);
            openAllergensPanelButton.Name = "openAllergensPanelButton";
            openAllergensPanelButton.Size = new System.Drawing.Size(94, 29);
            openAllergensPanelButton.TabIndex = 15;
            openAllergensPanelButton.Text = "Open Allergens Panel";
            openAllergensPanelButton.UseVisualStyleBackColor = true;
            openAllergensPanelButton.Click += openAllergensPanelButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(1259, 1102);
            Controls.Add(openAllergensPanelButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRecipeDelete;
        private System.Windows.Forms.Button btnRecipeEdit;
        private System.Windows.Forms.Button btnRecipeAdd;
        private System.Windows.Forms.Label lblRecipeAllergens;
        private System.Windows.Forms.Label lblRecipeName;
        //TODO: Task 5 Change to a drop-down list control containing the allergens names to the allergens field
        private System.Windows.Forms.TextBox txtRecipeAllergens;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.TextBox txtRecipeCode;
        private System.Windows.Forms.Label lblRecipeCode;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader recipeCode;
        private System.Windows.Forms.ColumnHeader recipeName;
        private System.Windows.Forms.ColumnHeader recipeAllergens;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCalculateAverage;
        private System.Windows.Forms.Label lblFindAllergen;
        private System.Windows.Forms.Button btnFindAllergen;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnSearchRecipes;
        private System.Windows.Forms.TextBox txtAverageAllergen;
        private System.Windows.Forms.TextBox txtFoundAllergen;
        private System.Windows.Forms.TextBox txtSearchAllergens;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.ColumnHeader lvsearchRecipes;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button openAllergensPanelButton;
    }
}

