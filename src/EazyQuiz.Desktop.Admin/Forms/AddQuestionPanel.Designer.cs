namespace EazyQuiz.Admin.Desktop;

partial class AddQuestionPanel
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
        QuestionInput = new RichTextBox();
        IsFirstAnswerCorrect = new RadioButton();
        FirstAnswerInput = new RichTextBox();
        SecondAnswerInput = new RichTextBox();
        IsSecondAnswerCorrect = new RadioButton();
        ThirdAnswerInput = new RichTextBox();
        IsThirdAnswerCorrect = new RadioButton();
        ForthAnswerInput = new RichTextBox();
        IsForthAnswerCorrect = new RadioButton();
        Send = new Button();
        label1 = new Label();
        label2 = new Label();
        label3 = new Label();
        label4 = new Label();
        label5 = new Label();
        UsersQuestionButton = new Button();
        themesList = new ComboBox();
        label6 = new Label();
        SuspendLayout();
        // 
        // QuestionInput
        // 
        QuestionInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        QuestionInput.Location = new Point(50, 152);
        QuestionInput.Name = "QuestionInput";
        QuestionInput.Size = new Size(400, 100);
        QuestionInput.TabIndex = 0;
        QuestionInput.Text = "";
        // 
        // IsFirstAnswerCorrect
        // 
        IsFirstAnswerCorrect.AutoSize = true;
        IsFirstAnswerCorrect.Checked = true;
        IsFirstAnswerCorrect.Location = new Point(30, 299);
        IsFirstAnswerCorrect.Name = "IsFirstAnswerCorrect";
        IsFirstAnswerCorrect.Size = new Size(14, 13);
        IsFirstAnswerCorrect.TabIndex = 1;
        IsFirstAnswerCorrect.TabStop = true;
        IsFirstAnswerCorrect.UseVisualStyleBackColor = true;
        // 
        // FirstAnswerInput
        // 
        FirstAnswerInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        FirstAnswerInput.Location = new Point(50, 292);
        FirstAnswerInput.Name = "FirstAnswerInput";
        FirstAnswerInput.Size = new Size(400, 50);
        FirstAnswerInput.TabIndex = 5;
        FirstAnswerInput.Text = "";
        // 
        // SecondAnswerInput
        // 
        SecondAnswerInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        SecondAnswerInput.Location = new Point(50, 375);
        SecondAnswerInput.Name = "SecondAnswerInput";
        SecondAnswerInput.Size = new Size(400, 50);
        SecondAnswerInput.TabIndex = 7;
        SecondAnswerInput.Text = "";
        // 
        // IsSecondAnswerCorrect
        // 
        IsSecondAnswerCorrect.AutoSize = true;
        IsSecondAnswerCorrect.Location = new Point(30, 382);
        IsSecondAnswerCorrect.Name = "IsSecondAnswerCorrect";
        IsSecondAnswerCorrect.Size = new Size(14, 13);
        IsSecondAnswerCorrect.TabIndex = 6;
        IsSecondAnswerCorrect.UseVisualStyleBackColor = true;
        // 
        // ThirdAnswerInput
        // 
        ThirdAnswerInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        ThirdAnswerInput.Location = new Point(50, 473);
        ThirdAnswerInput.Name = "ThirdAnswerInput";
        ThirdAnswerInput.Size = new Size(400, 50);
        ThirdAnswerInput.TabIndex = 9;
        ThirdAnswerInput.Text = "";
        // 
        // IsThirdAnswerCorrect
        // 
        IsThirdAnswerCorrect.AutoSize = true;
        IsThirdAnswerCorrect.Location = new Point(30, 480);
        IsThirdAnswerCorrect.Name = "IsThirdAnswerCorrect";
        IsThirdAnswerCorrect.Size = new Size(14, 13);
        IsThirdAnswerCorrect.TabIndex = 8;
        IsThirdAnswerCorrect.UseVisualStyleBackColor = true;
        // 
        // ForthAnswerInput
        // 
        ForthAnswerInput.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        ForthAnswerInput.Location = new Point(50, 564);
        ForthAnswerInput.Name = "ForthAnswerInput";
        ForthAnswerInput.Size = new Size(400, 50);
        ForthAnswerInput.TabIndex = 11;
        ForthAnswerInput.Text = "";
        // 
        // IsForthAnswerCorrect
        // 
        IsForthAnswerCorrect.AutoSize = true;
        IsForthAnswerCorrect.Location = new Point(30, 571);
        IsForthAnswerCorrect.Name = "IsForthAnswerCorrect";
        IsForthAnswerCorrect.Size = new Size(14, 13);
        IsForthAnswerCorrect.TabIndex = 10;
        IsForthAnswerCorrect.UseVisualStyleBackColor = true;
        // 
        // Send
        // 
        Send.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        Send.Location = new Point(50, 623);
        Send.Name = "Send";
        Send.Size = new Size(400, 50);
        Send.TabIndex = 12;
        Send.Text = "Отправить";
        Send.UseVisualStyleBackColor = true;
        Send.Click += SendQuestionToServer;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(50, 129);
        label1.Name = "label1";
        label1.Size = new Size(120, 20);
        label1.TabIndex = 13;
        label1.Text = "Введите вопрос";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(50, 265);
        label2.Name = "label2";
        label2.Size = new Size(164, 20);
        label2.TabIndex = 14;
        label2.Text = "Введите первый ответ";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(50, 351);
        label3.Name = "label3";
        label3.Size = new Size(160, 20);
        label3.TabIndex = 14;
        label3.Text = "Введите второй ответ";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(50, 450);
        label4.Name = "label4";
        label4.Size = new Size(157, 20);
        label4.TabIndex = 14;
        label4.Text = "Введите третий ответ";
        // 
        // label5
        // 
        label5.AutoSize = true;
        label5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label5.Location = new Point(50, 541);
        label5.Name = "label5";
        label5.Size = new Size(186, 20);
        label5.TabIndex = 14;
        label5.Text = "Введите четверный ответ";
        // 
        // UsersQuestionButton
        // 
        UsersQuestionButton.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
        UsersQuestionButton.Location = new Point(50, 12);
        UsersQuestionButton.Name = "UsersQuestionButton";
        UsersQuestionButton.Size = new Size(400, 25);
        UsersQuestionButton.TabIndex = 15;
        UsersQuestionButton.Text = "Предложенные вопросы от пользотвателей";
        UsersQuestionButton.UseVisualStyleBackColor = true;
        UsersQuestionButton.Click += ShowManageUserQuestion;
        // 
        // themesList
        // 
        themesList.DropDownStyle = ComboBoxStyle.DropDownList;
        themesList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        themesList.FormattingEnabled = true;
        themesList.Location = new Point(50, 86);
        themesList.Name = "themesList";
        themesList.Size = new Size(400, 28);
        themesList.TabIndex = 16;
        // 
        // label6
        // 
        label6.AutoSize = true;
        label6.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label6.Location = new Point(50, 51);
        label6.Name = "label6";
        label6.Size = new Size(176, 20);
        label6.TabIndex = 17;
        label6.Text = "Выберете тему вопроса";
        // 
        // AddQuestionPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(488, 689);
        Controls.Add(label6);
        Controls.Add(themesList);
        Controls.Add(UsersQuestionButton);
        Controls.Add(label5);
        Controls.Add(label4);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(Send);
        Controls.Add(ForthAnswerInput);
        Controls.Add(IsForthAnswerCorrect);
        Controls.Add(ThirdAnswerInput);
        Controls.Add(IsThirdAnswerCorrect);
        Controls.Add(SecondAnswerInput);
        Controls.Add(IsSecondAnswerCorrect);
        Controls.Add(FirstAnswerInput);
        Controls.Add(IsFirstAnswerCorrect);
        Controls.Add(QuestionInput);
        Name = "AddQuestionPanel";
        Text = "Добавление вопроса";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private RichTextBox QuestionInput;
    private RadioButton IsFirstAnswerCorrect;
    private RichTextBox FirstAnswerInput;
    private RichTextBox SecondAnswerInput;
    private RadioButton IsSecondAnswerCorrect;
    private RichTextBox ThirdAnswerInput;
    private RadioButton IsThirdAnswerCorrect;
    private RichTextBox ForthAnswerInput;
    private RadioButton IsForthAnswerCorrect;
    private Button Send;
    private Label label1;
    private Label label2;
    private Label label3;
    private Label label4;
    private Label label5;
    private Button UsersQuestionButton;
    private ComboBox themesList;
    private Label label6;
}
