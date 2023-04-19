namespace EazyQuiz.Admin.Desktop;

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
        usersQuestionsList = new ListBox();
        questionTextLabel = new RichTextBox();
        answerTextLabel = new RichTextBox();
        acceptButton = new Button();
        denyDutton = new Button();
        refreshButton = new Button();
        exitButton = new Button();
        SuspendLayout();
        // 
        // usersQuestionsList
        // 
        usersQuestionsList.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        usersQuestionsList.FormattingEnabled = true;
        usersQuestionsList.ItemHeight = 18;
        usersQuestionsList.Location = new Point(12, 35);
        usersQuestionsList.Name = "usersQuestionsList";
        usersQuestionsList.Size = new Size(372, 400);
        usersQuestionsList.TabIndex = 0;
        usersQuestionsList.SelectedValueChanged += SelectUserQuestion;
        // 
        // questionTextLabel
        // 
        questionTextLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        questionTextLabel.Location = new Point(419, 35);
        questionTextLabel.Name = "questionTextLabel";
        questionTextLabel.ReadOnly = true;
        questionTextLabel.Size = new Size(283, 145);
        questionTextLabel.TabIndex = 1;
        questionTextLabel.Text = "";
        // 
        // answerTextLabel
        // 
        answerTextLabel.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        answerTextLabel.Location = new Point(419, 196);
        answerTextLabel.Name = "answerTextLabel";
        answerTextLabel.ReadOnly = true;
        answerTextLabel.Size = new Size(283, 81);
        answerTextLabel.TabIndex = 2;
        answerTextLabel.Text = "";
        // 
        // acceptButton
        // 
        acceptButton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        acceptButton.Location = new Point(419, 318);
        acceptButton.Name = "acceptButton";
        acceptButton.Size = new Size(283, 50);
        acceptButton.TabIndex = 4;
        acceptButton.Text = "Принять";
        acceptButton.UseVisualStyleBackColor = true;
        acceptButton.Click += AcceptQuestionClick;
        // 
        // denyDutton
        // 
        denyDutton.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        denyDutton.Location = new Point(419, 390);
        denyDutton.Name = "denyDutton";
        denyDutton.Size = new Size(283, 50);
        denyDutton.TabIndex = 5;
        denyDutton.Text = "Отклонить";
        denyDutton.UseVisualStyleBackColor = true;
        denyDutton.Click += DenyQuestionClick;
        // 
        // refreshButton
        // 
        refreshButton.Location = new Point(627, 6);
        refreshButton.Name = "refreshButton";
        refreshButton.Size = new Size(75, 23);
        refreshButton.TabIndex = 6;
        refreshButton.Text = "Обновить";
        refreshButton.UseVisualStyleBackColor = true;
        refreshButton.Click += RefreshListClick;
        // 
        // exitButton
        // 
        exitButton.Location = new Point(12, 6);
        exitButton.Name = "exitButton";
        exitButton.Size = new Size(75, 23);
        exitButton.TabIndex = 7;
        exitButton.Text = "Выйти";
        exitButton.UseVisualStyleBackColor = true;
        exitButton.Click += ExitButtonClick;
        // 
        // ManageUsersQuestionPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(721, 450);
        Controls.Add(exitButton);
        Controls.Add(refreshButton);
        Controls.Add(denyDutton);
        Controls.Add(acceptButton);
        Controls.Add(answerTextLabel);
        Controls.Add(questionTextLabel);
        Controls.Add(usersQuestionsList);
        Name = "ManageUsersQuestionPanel";
        Text = "Предложенные вопросы от пользователей";
        Load += FormLoadEvent;
        ResumeLayout(false);
    }

    #endregion

    private ListBox usersQuestionsList;
    private RichTextBox questionTextLabel;
    private RichTextBox answerTextLabel;
    private Button acceptButton;
    private Button denyDutton;
    private Button refreshButton;
    private Button exitButton;
}
