namespace AllergyInfoApp;

partial class AllergenGroupForm
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        groupBox1 = new System.Windows.Forms.GroupBox();
        listView1 = new System.Windows.Forms.ListView();
        columnOne = new System.Windows.Forms.ColumnHeader();
        columnTwo = new System.Windows.Forms.ColumnHeader();
        allergensCodeTextBox = new System.Windows.Forms.TextBox();
        allergensNameTextBox = new System.Windows.Forms.TextBox();
        btnAllergensAdd = new System.Windows.Forms.Button();
        lblAlergensName = new System.Windows.Forms.Label();
        btnAllergensEdit = new System.Windows.Forms.Button();
        btnAllergensDelete = new System.Windows.Forms.Button();
        lblAllergensCode = new System.Windows.Forms.Label();
        groupBox1.SuspendLayout();
        SuspendLayout();
        // 
        // groupBox1
        // 
        groupBox1.Controls.Add(listView1);
        groupBox1.Controls.Add(allergensCodeTextBox);
        groupBox1.Controls.Add(allergensNameTextBox);
        groupBox1.Controls.Add(btnAllergensAdd);
        groupBox1.Controls.Add(lblAlergensName);
        groupBox1.Controls.Add(btnAllergensEdit);
        groupBox1.Controls.Add(btnAllergensDelete);
        groupBox1.Controls.Add(lblAllergensCode);
        groupBox1.Location = new System.Drawing.Point(13, 14);
        groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        groupBox1.Name = "groupBox1";
        groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
        groupBox1.Size = new System.Drawing.Size(610, 517);
        groupBox1.TabIndex = 13;
        groupBox1.TabStop = false;
        groupBox1.Text = "Allergens";
        // 
        // listView1
        // 
        listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { columnOne, columnTwo });
        listView1.GridLines = true;
        listView1.Location = new System.Drawing.Point(29, 37);
        listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        listView1.MultiSelect = false;
        listView1.Name = "listView1";
        listView1.Size = new System.Drawing.Size(263, 387);
        listView1.TabIndex = 0;
        listView1.UseCompatibleStateImageBehavior = false;
        listView1.View = System.Windows.Forms.View.Details;
        listView1.SelectedIndexChanged += listView1_SelectedIndexChanged;
        // 
        // columnOne
        // 
        columnOne.Text = "Code";
        // 
        // columnTwo
        // 
        columnTwo.Text = "Name";
        columnTwo.Width = 120;
        // 
        // allergensCodeTextBox
        // 
        allergensCodeTextBox.Enabled = false;
        allergensCodeTextBox.Location = new System.Drawing.Point(390, 23);
        allergensCodeTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        allergensCodeTextBox.Name = "allergensCodeTextBox";
        allergensCodeTextBox.Size = new System.Drawing.Size(187, 31);
        allergensCodeTextBox.TabIndex = 3;
        // 
        // allergensNameTextBox
        // 
        allergensNameTextBox.Enabled = false;
        allergensNameTextBox.Location = new System.Drawing.Point(390, 90);
        allergensNameTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        allergensNameTextBox.Name = "allergensNameTextBox";
        allergensNameTextBox.Size = new System.Drawing.Size(187, 31);
        allergensNameTextBox.TabIndex = 4;
        // 
        // btnAllergensAdd
        // 
        btnAllergensAdd.Location = new System.Drawing.Point(319, 183);
        btnAllergensAdd.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnAllergensAdd.Name = "btnAllergensAdd";
        btnAllergensAdd.Size = new System.Drawing.Size(107, 38);
        btnAllergensAdd.TabIndex = 5;
        btnAllergensAdd.Text = "Add";
        btnAllergensAdd.UseVisualStyleBackColor = true;
        btnAllergensAdd.Click += btnAllergensAdd_Click;
        // 
        // lblAlergensName
        // 
        lblAlergensName.AutoSize = true;
        lblAlergensName.Location = new System.Drawing.Point(302, 105);
        lblAlergensName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        lblAlergensName.Name = "lblAlergensName";
        lblAlergensName.Size = new System.Drawing.Size(68, 25);
        lblAlergensName.TabIndex = 2;
        lblAlergensName.Text = "Name :";
        // 
        // btnAllergensEdit
        // 
        btnAllergensEdit.Location = new System.Drawing.Point(471, 182);
        btnAllergensEdit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnAllergensEdit.Name = "btnAllergensEdit";
        btnAllergensEdit.Size = new System.Drawing.Size(107, 38);
        btnAllergensEdit.TabIndex = 6;
        btnAllergensEdit.Text = "Edit";
        btnAllergensEdit.UseVisualStyleBackColor = true;
        btnAllergensEdit.Click += btnAllergensEdit_Click;
        // 
        // btnAllergensDelete
        // 
        btnAllergensDelete.Location = new System.Drawing.Point(317, 262);
        btnAllergensDelete.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
        btnAllergensDelete.Name = "btnAllergensDelete";
        btnAllergensDelete.Size = new System.Drawing.Size(107, 38);
        btnAllergensDelete.TabIndex = 7;
        btnAllergensDelete.Text = "Delete";
        btnAllergensDelete.UseVisualStyleBackColor = true;
        btnAllergensDelete.Click += btnAllergensDelete_Click;
        // 
        // lblAllergensCode
        // 
        lblAllergensCode.AutoSize = true;
        lblAllergensCode.Location = new System.Drawing.Point(302, 39);
        lblAllergensCode.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
        lblAllergensCode.Name = "lblAllergensCode";
        lblAllergensCode.Size = new System.Drawing.Size(68, 25);
        lblAllergensCode.TabIndex = 1;
        lblAllergensCode.Text = " Code :";
        // 
        // AllergenGroupForm
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(649, 556);
        Controls.Add(groupBox1);
        Name = "AllergenGroupForm";
        Text = "AllergenGroupForm";
        Load += AllergenGroupForm_Load;
        groupBox1.ResumeLayout(false);
        groupBox1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.ListView listView1;
    private System.Windows.Forms.ColumnHeader columnOne;
    private System.Windows.Forms.ColumnHeader columnTwo;
    private System.Windows.Forms.TextBox allergensCodeTextBox;
    private System.Windows.Forms.TextBox allergensNameTextBox;
    private System.Windows.Forms.Button btnAllergensAdd;
    private System.Windows.Forms.Label lblAlergensName;
    private System.Windows.Forms.Button btnAllergensEdit;
    private System.Windows.Forms.Button btnAllergensDelete;
    private System.Windows.Forms.Label lblAllergensCode;
}