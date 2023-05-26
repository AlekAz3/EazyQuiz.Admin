namespace EazyQuiz.Admin.Desktop;

partial class MainPanel
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
        OpenUsersQuestion = new Button();
        OpenAddQuestion = new Button();
        OpenAddTheme = new Button();
        button1 = new Button();
        SuspendLayout();
        // 
        // OpenUsersQuestion
        // 
        OpenUsersQuestion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        OpenUsersQuestion.Location = new Point(12, 12);
        OpenUsersQuestion.Name = "OpenUsersQuestion";
        OpenUsersQuestion.Size = new Size(436, 48);
        OpenUsersQuestion.TabIndex = 0;
        OpenUsersQuestion.Text = "Просмотр предложенных вопросов от пользователей";
        OpenUsersQuestion.UseVisualStyleBackColor = true;
        OpenUsersQuestion.Click += OpenUsersQuestionsPanel;
        // 
        // OpenAddQuestion
        // 
        OpenAddQuestion.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        OpenAddQuestion.Location = new Point(12, 66);
        OpenAddQuestion.Name = "OpenAddQuestion";
        OpenAddQuestion.Size = new Size(436, 48);
        OpenAddQuestion.TabIndex = 1;
        OpenAddQuestion.Text = "Добавление вопросов";
        OpenAddQuestion.UseVisualStyleBackColor = true;
        OpenAddQuestion.Click += OpenAddQuestionsPanel;
        // 
        // OpenAddTheme
        // 
        OpenAddTheme.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        OpenAddTheme.Location = new Point(12, 120);
        OpenAddTheme.Name = "OpenAddTheme";
        OpenAddTheme.Size = new Size(436, 48);
        OpenAddTheme.TabIndex = 2;
        OpenAddTheme.Text = "Добавление темы для вопросов";
        OpenAddTheme.UseVisualStyleBackColor = true;
        OpenAddTheme.Click += OpenAddThemePanel;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(12, 174);
        button1.Name = "button1";
        button1.Size = new Size(436, 48);
        button1.TabIndex = 3;
        button1.Text = "Управление темами вопросов";
        button1.UseVisualStyleBackColor = true;
        button1.Click += UpdateThemesButton;
        // 
        // MainPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(467, 242);
        Controls.Add(button1);
        Controls.Add(OpenAddTheme);
        Controls.Add(OpenAddQuestion);
        Controls.Add(OpenUsersQuestion);
        Name = "MainPanel";
        Text = "Панель";
        FormClosed += FormClosingAction;
        ResumeLayout(false);
    }

    #endregion

    private Button OpenUsersQuestion;
    private Button OpenAddQuestion;
    private Button OpenAddTheme;
    private Button button1;
}
