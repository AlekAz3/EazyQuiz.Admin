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
            this.usersQuestionsList = new System.Windows.Forms.ListBox();
            this.questionTextLabel = new System.Windows.Forms.RichTextBox();
            this.answerTextLabel = new System.Windows.Forms.RichTextBox();
            this.acceptButton = new System.Windows.Forms.Button();
            this.denyDutton = new System.Windows.Forms.Button();
            this.refreshButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersQuestionsList
            // 
            this.usersQuestionsList.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usersQuestionsList.FormattingEnabled = true;
            this.usersQuestionsList.ItemHeight = 18;
            this.usersQuestionsList.Location = new System.Drawing.Point(12, 35);
            this.usersQuestionsList.Name = "usersQuestionsList";
            this.usersQuestionsList.Size = new System.Drawing.Size(372, 400);
            this.usersQuestionsList.TabIndex = 0;
            this.usersQuestionsList.SelectedValueChanged += new System.EventHandler(this.SelectUserQuestion);
            // 
            // questionTextLabel
            // 
            this.questionTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.questionTextLabel.Location = new System.Drawing.Point(419, 35);
            this.questionTextLabel.Name = "questionTextLabel";
            this.questionTextLabel.ReadOnly = true;
            this.questionTextLabel.Size = new System.Drawing.Size(283, 145);
            this.questionTextLabel.TabIndex = 1;
            this.questionTextLabel.Text = "";
            // 
            // answerTextLabel
            // 
            this.answerTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.answerTextLabel.Location = new System.Drawing.Point(419, 196);
            this.answerTextLabel.Name = "answerTextLabel";
            this.answerTextLabel.ReadOnly = true;
            this.answerTextLabel.Size = new System.Drawing.Size(283, 81);
            this.answerTextLabel.TabIndex = 2;
            this.answerTextLabel.Text = "";
            // 
            // acceptButton
            // 
            this.acceptButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.acceptButton.Location = new System.Drawing.Point(419, 318);
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size(283, 50);
            this.acceptButton.TabIndex = 4;
            this.acceptButton.Text = "Принять";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler(this.AcceptQuestionClick);
            // 
            // denyDutton
            // 
            this.denyDutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.denyDutton.Location = new System.Drawing.Point(419, 390);
            this.denyDutton.Name = "denyDutton";
            this.denyDutton.Size = new System.Drawing.Size(283, 50);
            this.denyDutton.TabIndex = 5;
            this.denyDutton.Text = "Отклонить";
            this.denyDutton.UseVisualStyleBackColor = true;
            this.denyDutton.Click += new System.EventHandler(this.DenyQuestionClick);
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(627, 6);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 6;
            this.refreshButton.Text = "Обновить";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.RefreshListClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(12, 6);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 7;
            this.exitButton.Text = "Выйти";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButtonClick);
            // 
            // ManageUsersQuestionPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 450);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.refreshButton);
            this.Controls.Add(this.denyDutton);
            this.Controls.Add(this.acceptButton);
            this.Controls.Add(this.answerTextLabel);
            this.Controls.Add(this.questionTextLabel);
            this.Controls.Add(this.usersQuestionsList);
            this.Name = "ManageUsersQuestionPanel";
            this.Text = "Предложенные вопросы от пользователей";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormClosingEvent);
            this.Load += new System.EventHandler(this.FormLoadEvent);
            this.ResumeLayout(false);

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
