namespace EazyQuiz.Admin.Desktop;

partial class Registration
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
        UsernameInput = new TextBox();
        PasswordInput = new TextBox();
        PasswordVerifyInput = new TextBox();
        CountryInput = new ComboBox();
        label1 = new Label();
        label3 = new Label();
        label4 = new Label();
        label7 = new Label();
        RegisterButton = new Button();
        EnterButton = new Button();
        SuspendLayout();
        // 
        // UsernameInput
        // 
        UsernameInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        UsernameInput.Location = new Point(163, 12);
        UsernameInput.Name = "UsernameInput";
        UsernameInput.Size = new Size(194, 27);
        UsernameInput.TabIndex = 0;
        // 
        // PasswordInput
        // 
        PasswordInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        PasswordInput.Location = new Point(163, 45);
        PasswordInput.Name = "PasswordInput";
        PasswordInput.Size = new Size(194, 27);
        PasswordInput.TabIndex = 1;
        // 
        // PasswordVerifyInput
        // 
        PasswordVerifyInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        PasswordVerifyInput.Location = new Point(163, 78);
        PasswordVerifyInput.Name = "PasswordVerifyInput";
        PasswordVerifyInput.Size = new Size(194, 27);
        PasswordVerifyInput.TabIndex = 2;
        // 
        // CountryInput
        // 
        CountryInput.DropDownStyle = ComboBoxStyle.DropDownList;
        CountryInput.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        CountryInput.FormattingEnabled = true;
        CountryInput.Items.AddRange(new object[] { "Россия", "Украина", "Беларусь" });
        CountryInput.Location = new Point(163, 126);
        CountryInput.Name = "CountryInput";
        CountryInput.Size = new Size(194, 28);
        CountryInput.TabIndex = 5;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(18, 15);
        label1.Name = "label1";
        label1.Size = new Size(36, 20);
        label1.TabIndex = 7;
        label1.Text = "Ник";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(18, 48);
        label3.Name = "label3";
        label3.Size = new Size(62, 20);
        label3.TabIndex = 8;
        label3.Text = "Пароль";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(18, 81);
        label4.Name = "label4";
        label4.Size = new Size(139, 20);
        label4.TabIndex = 8;
        label4.Text = "Повторите пароль";
        // 
        // label7
        // 
        label7.AutoSize = true;
        label7.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label7.Location = new Point(18, 129);
        label7.Name = "label7";
        label7.Size = new Size(58, 20);
        label7.TabIndex = 10;
        label7.Text = "Страна";
        // 
        // RegisterButton
        // 
        RegisterButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        RegisterButton.Location = new Point(18, 169);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new Size(339, 41);
        RegisterButton.TabIndex = 6;
        RegisterButton.Text = "Зарегестрироваться ";
        RegisterButton.UseVisualStyleBackColor = true;
        RegisterButton.Click += RegisterButtonClick;
        // 
        // EnterButton
        // 
        EnterButton.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        EnterButton.Location = new Point(18, 216);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new Size(339, 41);
        EnterButton.TabIndex = 7;
        EnterButton.Text = "Вход";
        EnterButton.UseVisualStyleBackColor = true;
        EnterButton.Click += EnterButtonClick;
        // 
        // Registration
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(373, 321);
        Controls.Add(EnterButton);
        Controls.Add(RegisterButton);
        Controls.Add(label7);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label1);
        Controls.Add(CountryInput);
        Controls.Add(PasswordVerifyInput);
        Controls.Add(PasswordInput);
        Controls.Add(UsernameInput);
        Name = "Registration";
        Text = "Регистрация";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox UsernameInput;
    private TextBox PasswordInput;
    private TextBox PasswordVerifyInput;
    private ComboBox CountryInput;
    private Label label1;
    private Label label3;
    private Label label4;
    private Label label7;
    private Button RegisterButton;
    private Button EnterButton;
}
