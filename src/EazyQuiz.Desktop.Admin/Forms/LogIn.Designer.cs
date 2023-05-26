namespace EazyQuiz.Admin.Desktop;

partial class LogIn
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
        UsernameInput = new TextBox();
        UsernameLabel = new Label();
        PasswordInput = new TextBox();
        PasswordLabel = new Label();
        EnterButton = new Button();
        Register = new Button();
        SuspendLayout();
        // 
        // UsernameInput
        // 
        UsernameInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsernameInput.Location = new Point(12, 33);
        UsernameInput.Name = "UsernameInput";
        UsernameInput.Size = new Size(251, 29);
        UsernameInput.TabIndex = 0;
        // 
        // UsernameLabel
        // 
        UsernameLabel.AutoSize = true;
        UsernameLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        UsernameLabel.Location = new Point(12, 9);
        UsernameLabel.Name = "UsernameLabel";
        UsernameLabel.Size = new Size(98, 21);
        UsernameLabel.TabIndex = 1;
        UsernameLabel.Text = "Введите ник";
        // 
        // PasswordInput
        // 
        PasswordInput.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PasswordInput.Location = new Point(12, 101);
        PasswordInput.Name = "PasswordInput";
        PasswordInput.Size = new Size(251, 29);
        PasswordInput.TabIndex = 1;
        // 
        // PasswordLabel
        // 
        PasswordLabel.AutoSize = true;
        PasswordLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        PasswordLabel.Location = new Point(12, 77);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(123, 21);
        PasswordLabel.TabIndex = 1;
        PasswordLabel.Text = "Введите пароль";
        // 
        // EnterButton
        // 
        EnterButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        EnterButton.Location = new Point(12, 144);
        EnterButton.Name = "EnterButton";
        EnterButton.Size = new Size(251, 31);
        EnterButton.TabIndex = 2;
        EnterButton.Text = "Войти";
        EnterButton.UseVisualStyleBackColor = true;
        EnterButton.Click += EnterButtonClick;
        // 
        // Register
        // 
        Register.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Register.Location = new Point(12, 181);
        Register.Name = "Register";
        Register.Size = new Size(251, 31);
        Register.TabIndex = 2;
        Register.Text = "Регистрация";
        Register.UseVisualStyleBackColor = true;
        Register.Click += RegistrationButtonClick;
        // 
        // LogIn
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(273, 221);
        Controls.Add(Register);
        Controls.Add(EnterButton);
        Controls.Add(PasswordLabel);
        Controls.Add(PasswordInput);
        Controls.Add(UsernameLabel);
        Controls.Add(UsernameInput);
        Name = "LogIn";
        Text = "Вход";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox UsernameInput;
    private Label UsernameLabel;
    private TextBox PasswordInput;
    private Label PasswordLabel;
    private Button EnterButton;
    private Button Register;
}
