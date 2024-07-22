
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
            if (disposing && (components != null))
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
            this.btnRecipeDelete = new System.Windows.Forms.Button();
            this.btnRecipeEdit = new System.Windows.Forms.Button();
            this.btnRecipeAdd = new System.Windows.Forms.Button();
            this.lblRecipeAllergens = new System.Windows.Forms.Label();
            this.lblRecipeName = new System.Windows.Forms.Label();
            this.txtRecipeAllergens = new System.Windows.Forms.TextBox();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.txtRecipeCode = new System.Windows.Forms.TextBox();
            this.lblRecipeCode = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.recipeCode = new System.Windows.Forms.ColumnHeader();
            this.recipeName = new System.Windows.Forms.ColumnHeader();
            this.recipeAllergens = new System.Windows.Forms.ColumnHeader();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCalculateAverage = new System.Windows.Forms.Button();
            this.lblFindAllergen = new System.Windows.Forms.Label();
            this.btnFindAllergen = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSearchRecipes = new System.Windows.Forms.Button();
            this.txtAverageAllergen = new System.Windows.Forms.TextBox();
            this.txtFoundAllergen = new System.Windows.Forms.TextBox();
            this.txtSearchAllergens = new System.Windows.Forms.TextBox();
            this.listView3 = new System.Windows.Forms.ListView();
            this.lvsearchRecipes = new System.Windows.Forms.ColumnHeader();
            this.lblAllergensCode = new System.Windows.Forms.Label();
            this.lblAlergensName = new System.Windows.Forms.Label();
            this.txtAllergensCode = new System.Windows.Forms.TextBox();
            this.txtAllergensName = new System.Windows.Forms.TextBox();
            this.btnAllergensAdd = new System.Windows.Forms.Button();
            this.btnAllergensEdit = new System.Windows.Forms.Button();
            this.btnAllergensDelete = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnOne = new System.Windows.Forms.ColumnHeader();
            this.columnTwo = new System.Windows.Forms.ColumnHeader();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecipeDelete
            // 
            this.btnRecipeDelete.Location = new System.Drawing.Point(457, 230);
            this.btnRecipeDelete.Name = "btnRecipeDelete";
            this.btnRecipeDelete.Size = new System.Drawing.Size(83, 28);
            this.btnRecipeDelete.TabIndex = 9;
            this.btnRecipeDelete.Text = "Delete";
            this.btnRecipeDelete.UseVisualStyleBackColor = true;
            this.btnRecipeDelete.Click += new System.EventHandler(this.btnRecipeDelete_Click);
            // 
            // btnRecipeEdit
            // 
            this.btnRecipeEdit.Location = new System.Drawing.Point(580, 179);
            this.btnRecipeEdit.Name = "btnRecipeEdit";
            this.btnRecipeEdit.Size = new System.Drawing.Size(83, 28);
            this.btnRecipeEdit.TabIndex = 8;
            this.btnRecipeEdit.Text = "Edit";
            this.btnRecipeEdit.UseVisualStyleBackColor = true;
            this.btnRecipeEdit.Click += new System.EventHandler(this.btnRecipeEdit_Click);
            // 
            // btnRecipeAdd
            // 
            this.btnRecipeAdd.Location = new System.Drawing.Point(457, 179);
            this.btnRecipeAdd.Name = "btnRecipeAdd";
            this.btnRecipeAdd.Size = new System.Drawing.Size(83, 28);
            this.btnRecipeAdd.TabIndex = 7;
            this.btnRecipeAdd.Text = "Add";
            this.btnRecipeAdd.UseVisualStyleBackColor = true;
            this.btnRecipeAdd.Click += new System.EventHandler(this.btnRecipeAdd_Click);
            // 
            // lblRecipeAllergens
            // 
            this.lblRecipeAllergens.AutoSize = true;
            this.lblRecipeAllergens.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeAllergens.Location = new System.Drawing.Point(404, 122);
            this.lblRecipeAllergens.Name = "lblRecipeAllergens";
            this.lblRecipeAllergens.Size = new System.Drawing.Size(78, 20);
            this.lblRecipeAllergens.TabIndex = 6;
            this.lblRecipeAllergens.Text = "Allergens :";
            // 
            // lblRecipeName
            // 
            this.lblRecipeName.AutoSize = true;
            this.lblRecipeName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeName.Location = new System.Drawing.Point(426, 68);
            this.lblRecipeName.Name = "lblRecipeName";
            this.lblRecipeName.Size = new System.Drawing.Size(56, 20);
            this.lblRecipeName.TabIndex = 5;
            this.lblRecipeName.Text = "Name :";
            // 
            // txtRecipeAllergens
            // 
            this.txtRecipeAllergens.Enabled = false;
            this.txtRecipeAllergens.Location = new System.Drawing.Point(488, 119);
            this.txtRecipeAllergens.Name = "txtRecipeAllergens";
            this.txtRecipeAllergens.Size = new System.Drawing.Size(206, 23);
            this.txtRecipeAllergens.TabIndex = 4;
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Enabled = false;
            this.txtRecipeName.Location = new System.Drawing.Point(488, 65);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(206, 23);
            this.txtRecipeName.TabIndex = 3;
            // 
            // txtRecipeCode
            // 
            this.txtRecipeCode.Enabled = false;
            this.txtRecipeCode.Location = new System.Drawing.Point(488, 19);
            this.txtRecipeCode.Name = "txtRecipeCode";
            this.txtRecipeCode.Size = new System.Drawing.Size(206, 23);
            this.txtRecipeCode.TabIndex = 1;
            // 
            // lblRecipeCode
            // 
            this.lblRecipeCode.AutoSize = true;
            this.lblRecipeCode.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRecipeCode.Location = new System.Drawing.Point(431, 22);
            this.lblRecipeCode.Name = "lblRecipeCode";
            this.lblRecipeCode.Size = new System.Drawing.Size(51, 20);
            this.lblRecipeCode.TabIndex = 2;
            this.lblRecipeCode.Text = "Code :";
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.recipeCode,
            this.recipeName,
            this.recipeAllergens});
            this.listView2.GridLines = true;
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(17, 22);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(332, 265);
            this.listView2.TabIndex = 0;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.Details;
            this.listView2.SelectedIndexChanged += new System.EventHandler(this.listView2_SelectedIndexChanged);
            // 
            // recipeCode
            // 
            this.recipeCode.Text = "Code";
            // 
            // recipeName
            // 
            this.recipeName.Text = "Name";
            this.recipeName.Width = 120;
            // 
            // recipeAllergens
            // 
            this.recipeAllergens.Text = "Allergens";
            this.recipeAllergens.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Average number of allergens in recipes:\r\n";
            // 
            // btnCalculateAverage
            // 
            this.btnCalculateAverage.Location = new System.Drawing.Point(415, 22);
            this.btnCalculateAverage.Name = "btnCalculateAverage";
            this.btnCalculateAverage.Size = new System.Drawing.Size(75, 23);
            this.btnCalculateAverage.TabIndex = 3;
            this.btnCalculateAverage.Text = "Calculate";
            this.btnCalculateAverage.UseVisualStyleBackColor = true;
            this.btnCalculateAverage.Click += new System.EventHandler(this.btnCalculateAverage_Click);
            // 
            // lblFindAllergen
            // 
            this.lblFindAllergen.AutoSize = true;
            this.lblFindAllergen.Location = new System.Drawing.Point(58, 68);
            this.lblFindAllergen.Name = "lblFindAllergen";
            this.lblFindAllergen.Size = new System.Drawing.Size(163, 15);
            this.lblFindAllergen.TabIndex = 5;
            this.lblFindAllergen.Text = "Find most common allergen: ";
            // 
            // btnFindAllergen
            // 
            this.btnFindAllergen.Location = new System.Drawing.Point(415, 64);
            this.btnFindAllergen.Name = "btnFindAllergen";
            this.btnFindAllergen.Size = new System.Drawing.Size(75, 23);
            this.btnFindAllergen.TabIndex = 7;
            this.btnFindAllergen.Text = "Find";
            this.btnFindAllergen.UseVisualStyleBackColor = true;
            this.btnFindAllergen.Click += new System.EventHandler(this.btnFindAllergen_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(118, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search for recipes:";
            // 
            // btnSearchRecipes
            // 
            this.btnSearchRecipes.Location = new System.Drawing.Point(415, 107);
            this.btnSearchRecipes.Name = "btnSearchRecipes";
            this.btnSearchRecipes.Size = new System.Drawing.Size(75, 23);
            this.btnSearchRecipes.TabIndex = 10;
            this.btnSearchRecipes.Text = "Search";
            this.btnSearchRecipes.UseVisualStyleBackColor = true;
            this.btnSearchRecipes.Click += new System.EventHandler(this.btnSearchRecipes_Click);
            // 
            // txtAverageAllergen
            // 
            this.txtAverageAllergen.Location = new System.Drawing.Point(228, 22);
            this.txtAverageAllergen.Name = "txtAverageAllergen";
            this.txtAverageAllergen.ReadOnly = true;
            this.txtAverageAllergen.Size = new System.Drawing.Size(181, 23);
            this.txtAverageAllergen.TabIndex = 4;
            // 
            // txtFoundAllergen
            // 
            this.txtFoundAllergen.Location = new System.Drawing.Point(228, 64);
            this.txtFoundAllergen.Name = "txtFoundAllergen";
            this.txtFoundAllergen.ReadOnly = true;
            this.txtFoundAllergen.Size = new System.Drawing.Size(181, 23);
            this.txtFoundAllergen.TabIndex = 6;
            // 
            // txtSearchAllergens
            // 
            this.txtSearchAllergens.Location = new System.Drawing.Point(228, 107);
            this.txtSearchAllergens.Name = "txtSearchAllergens";
            this.txtSearchAllergens.Size = new System.Drawing.Size(181, 23);
            this.txtSearchAllergens.TabIndex = 9;
            // 
            // listView3
            // 
            this.listView3.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lvsearchRecipes});
            this.listView3.GridLines = true;
            this.listView3.HideSelection = false;
            this.listView3.Location = new System.Drawing.Point(523, 22);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(283, 232);
            this.listView3.TabIndex = 11;
            this.listView3.UseCompatibleStateImageBehavior = false;
            this.listView3.View = System.Windows.Forms.View.Details;
            // 
            // lvsearchRecipes
            // 
            this.lvsearchRecipes.Text = "Recipes";
            this.lvsearchRecipes.Width = 179;
            // 
            // lblAllergensCode
            // 
            this.lblAllergensCode.AutoSize = true;
            this.lblAllergensCode.Location = new System.Drawing.Point(211, 22);
            this.lblAllergensCode.Name = "lblAllergensCode";
            this.lblAllergensCode.Size = new System.Drawing.Size(44, 15);
            this.lblAllergensCode.TabIndex = 1;
            this.lblAllergensCode.Text = " Code :";
            // 
            // lblAlergensName
            // 
            this.lblAlergensName.AutoSize = true;
            this.lblAlergensName.Location = new System.Drawing.Point(211, 62);
            this.lblAlergensName.Name = "lblAlergensName";
            this.lblAlergensName.Size = new System.Drawing.Size(45, 15);
            this.lblAlergensName.TabIndex = 2;
            this.lblAlergensName.Text = "Name :";
            // 
            // txtAllergensCode
            // 
            this.txtAllergensCode.Enabled = false;
            this.txtAllergensCode.Location = new System.Drawing.Point(273, 14);
            this.txtAllergensCode.Name = "txtAllergensCode";
            this.txtAllergensCode.Size = new System.Drawing.Size(132, 23);
            this.txtAllergensCode.TabIndex = 3;
            // 
            // txtAllergensName
            // 
            this.txtAllergensName.Enabled = false;
            this.txtAllergensName.Location = new System.Drawing.Point(273, 54);
            this.txtAllergensName.Name = "txtAllergensName";
            this.txtAllergensName.Size = new System.Drawing.Size(132, 23);
            this.txtAllergensName.TabIndex = 4;
            // 
            // btnAllergensAdd
            // 
            this.btnAllergensAdd.Location = new System.Drawing.Point(223, 110);
            this.btnAllergensAdd.Name = "btnAllergensAdd";
            this.btnAllergensAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAllergensAdd.TabIndex = 5;
            this.btnAllergensAdd.Text = "Add";
            this.btnAllergensAdd.UseVisualStyleBackColor = true;
            this.btnAllergensAdd.Click += new System.EventHandler(this.btnAllergensAdd_Click);
            // 
            // btnAllergensEdit
            // 
            this.btnAllergensEdit.Location = new System.Drawing.Point(330, 109);
            this.btnAllergensEdit.Name = "btnAllergensEdit";
            this.btnAllergensEdit.Size = new System.Drawing.Size(75, 23);
            this.btnAllergensEdit.TabIndex = 6;
            this.btnAllergensEdit.Text = "Edit";
            this.btnAllergensEdit.UseVisualStyleBackColor = true;
            this.btnAllergensEdit.Click += new System.EventHandler(this.btnAllergensEdit_Click);
            // 
            // btnAllergensDelete
            // 
            this.btnAllergensDelete.Location = new System.Drawing.Point(222, 157);
            this.btnAllergensDelete.Name = "btnAllergensDelete";
            this.btnAllergensDelete.Size = new System.Drawing.Size(75, 23);
            this.btnAllergensDelete.TabIndex = 7;
            this.btnAllergensDelete.Text = "Delete";
            this.btnAllergensDelete.UseVisualStyleBackColor = true;
            this.btnAllergensDelete.Click += new System.EventHandler(this.btnAllergensDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnOne,
            this.columnTwo});
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 22);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(185, 234);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnOne
            // 
            this.columnOne.Text = "Code";
            // 
            // columnTwo
            // 
            this.columnTwo.Text = "Name";
            this.columnTwo.Width = 120;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.txtAllergensCode);
            this.groupBox1.Controls.Add(this.txtAllergensName);
            this.groupBox1.Controls.Add(this.btnAllergensAdd);
            this.groupBox1.Controls.Add(this.lblAlergensName);
            this.groupBox1.Controls.Add(this.btnAllergensEdit);
            this.groupBox1.Controls.Add(this.btnAllergensDelete);
            this.groupBox1.Controls.Add(this.lblAllergensCode);
            this.groupBox1.Location = new System.Drawing.Point(717, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(427, 310);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allergens";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listView2);
            this.groupBox2.Controls.Add(this.lblRecipeCode);
            this.groupBox2.Controls.Add(this.lblRecipeName);
            this.groupBox2.Controls.Add(this.txtRecipeAllergens);
            this.groupBox2.Controls.Add(this.lblRecipeAllergens);
            this.groupBox2.Controls.Add(this.txtRecipeName);
            this.groupBox2.Controls.Add(this.btnRecipeAdd);
            this.groupBox2.Controls.Add(this.txtRecipeCode);
            this.groupBox2.Controls.Add(this.btnRecipeEdit);
            this.groupBox2.Controls.Add(this.btnRecipeDelete);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(699, 314);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recipes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtAverageAllergen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnCalculateAverage);
            this.groupBox3.Controls.Add(this.listView3);
            this.groupBox3.Controls.Add(this.lblFindAllergen);
            this.groupBox3.Controls.Add(this.txtSearchAllergens);
            this.groupBox3.Controls.Add(this.btnFindAllergen);
            this.groupBox3.Controls.Add(this.txtFoundAllergen);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.btnSearchRecipes);
            this.groupBox3.Location = new System.Drawing.Point(19, 342);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1125, 332);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistics";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 661);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button btnRecipeDelete;
        private System.Windows.Forms.Button btnRecipeEdit;
        private System.Windows.Forms.Button btnRecipeAdd;
        private System.Windows.Forms.Label lblRecipeAllergens;
        private System.Windows.Forms.Label lblRecipeName;
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
        private System.Windows.Forms.Label lblAllergensCode;
        private System.Windows.Forms.Label lblAlergensName;
        private System.Windows.Forms.TextBox txtAllergensCode;
        private System.Windows.Forms.TextBox txtAllergensName;
        private System.Windows.Forms.Button btnAllergensAdd;
        private System.Windows.Forms.Button btnAllergensEdit;
        private System.Windows.Forms.Button btnAllergensDelete;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnOne;
        private System.Windows.Forms.ColumnHeader columnTwo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

