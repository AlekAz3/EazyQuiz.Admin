namespace EazyQuiz.Admin.Desktop;

partial class AddNewTheme
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
        textBox1 = new TextBox();
        label1 = new Label();
        AddThemeButton = new Button();
        SuspendLayout();
        // 
        // textBox1
        // 
        textBox1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        textBox1.Location = new Point(12, 32);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(236, 27);
        textBox1.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(11, 9);
        label1.Name = "label1";
        label1.Size = new Size(175, 20);
        label1.TabIndex = 1;
        label1.Text = "Введите название темы";
        // 
        // AddThemeButton
        // 
        AddThemeButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        AddThemeButton.Location = new Point(12, 65);
        AddThemeButton.Name = "AddThemeButton";
        AddThemeButton.Size = new Size(236, 34);
        AddThemeButton.TabIndex = 2;
        AddThemeButton.Text = "Отправить";
        AddThemeButton.UseVisualStyleBackColor = true;
        AddThemeButton.Click += AddThemeButtonClick;
        // 
        // AddNewTheme
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(278, 111);
        Controls.Add(AddThemeButton);
        Controls.Add(label1);
        Controls.Add(textBox1);
        MaximizeBox = false;
        Name = "AddNewTheme";
        Text = "Добавление новой темы";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox textBox1;
    private Label label1;
    private Button AddThemeButton;
}
