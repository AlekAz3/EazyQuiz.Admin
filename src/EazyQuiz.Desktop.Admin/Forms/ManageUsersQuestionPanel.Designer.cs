namespace EazyQuiz.Desktop.Admin;

partial class ManageUsersQuestionPanel
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
        if (disposing && (components != null))
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
        listBox1 = new ListBox();
        richTextBox1 = new RichTextBox();
        richTextBox2 = new RichTextBox();
        comboBox1 = new ComboBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.ItemHeight = 15;
        listBox1.Location = new Point(12, 12);
        listBox1.Name = "listBox1";
        listBox1.Size = new Size(372, 409);
        listBox1.TabIndex = 0;
        listBox1.SelectedValueChanged += listBox1_SelectedValueChanged;
        // 
        // richTextBox1
        // 
        richTextBox1.Location = new Point(452, 33);
        richTextBox1.Name = "richTextBox1";
        richTextBox1.Size = new Size(283, 64);
        richTextBox1.TabIndex = 1;
        richTextBox1.Text = "";
        // 
        // richTextBox2
        // 
        richTextBox2.Location = new Point(452, 129);
        richTextBox2.Name = "richTextBox2";
        richTextBox2.Size = new Size(283, 64);
        richTextBox2.TabIndex = 2;
        richTextBox2.Text = "";
        // 
        // comboBox1
        // 
        comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        comboBox1.FormattingEnabled = true;
        comboBox1.Items.AddRange(new object[] { "Новый", "Принят", "Отклонён" });
        comboBox1.Location = new Point(452, 209);
        comboBox1.Name = "comboBox1";
        comboBox1.Size = new Size(283, 23);
        comboBox1.TabIndex = 3;
        // 
        // button1
        // 
        button1.Location = new Point(452, 267);
        button1.Name = "button1";
        button1.Size = new Size(290, 50);
        button1.TabIndex = 4;
        button1.Text = "button1";
        button1.UseVisualStyleBackColor = true;
        // 
        // ManageUsersQuestionPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(747, 450);
        Controls.Add(button1);
        Controls.Add(comboBox1);
        Controls.Add(richTextBox2);
        Controls.Add(richTextBox1);
        Controls.Add(listBox1);
        Name = "ManageUsersQuestionPanel";
        Text = "ManageUsersQuestion";
        Load += ManageUsersQuestionPanelLoad;
        ResumeLayout(false);
    }

    #endregion

    private ListBox listBox1;
    private RichTextBox richTextBox1;
    private RichTextBox richTextBox2;
    private ComboBox comboBox1;
    private Button button1;
}
