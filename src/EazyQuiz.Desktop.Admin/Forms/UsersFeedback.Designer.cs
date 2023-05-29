namespace EazyQuiz.Admin.Desktop;

partial class UsersFeedback
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
        ListFeedbacks = new ListBox();
        FeedbackText = new RichTextBox();
        label1 = new Label();
        FeedbackEmail = new TextBox();
        label2 = new Label();
        label3 = new Label();
        FeedbackStatus = new ComboBox();
        StatusShow = new ComboBox();
        label4 = new Label();
        button1 = new Button();
        SuspendLayout();
        // 
        // ListFeedbacks
        // 
        ListFeedbacks.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        ListFeedbacks.FormattingEnabled = true;
        ListFeedbacks.ItemHeight = 21;
        ListFeedbacks.Location = new Point(12, 70);
        ListFeedbacks.Name = "ListFeedbacks";
        ListFeedbacks.Size = new Size(569, 466);
        ListFeedbacks.TabIndex = 0;
        ListFeedbacks.SelectedIndexChanged += ChangeSelectedIndex;
        // 
        // FeedbackText
        // 
        FeedbackText.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FeedbackText.Location = new Point(587, 92);
        FeedbackText.Name = "FeedbackText";
        FeedbackText.ReadOnly = true;
        FeedbackText.Size = new Size(290, 96);
        FeedbackText.TabIndex = 1;
        FeedbackText.Text = "";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(587, 70);
        label1.Name = "label1";
        label1.Size = new Size(45, 20);
        label1.TabIndex = 2;
        label1.Text = "Текст";
        // 
        // FeedbackEmail
        // 
        FeedbackEmail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FeedbackEmail.Location = new Point(587, 249);
        FeedbackEmail.Name = "FeedbackEmail";
        FeedbackEmail.ReadOnly = true;
        FeedbackEmail.Size = new Size(290, 29);
        FeedbackEmail.TabIndex = 3;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label2.Location = new Point(587, 226);
        label2.Name = "label2";
        label2.Size = new Size(51, 20);
        label2.TabIndex = 4;
        label2.Text = "Почта";
        // 
        // label3
        // 
        label3.AutoSize = true;
        label3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label3.Location = new Point(587, 305);
        label3.Name = "label3";
        label3.Size = new Size(52, 20);
        label3.TabIndex = 5;
        label3.Text = "Статус";
        // 
        // FeedbackStatus
        // 
        FeedbackStatus.DropDownStyle = ComboBoxStyle.DropDownList;
        FeedbackStatus.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        FeedbackStatus.FormattingEnabled = true;
        FeedbackStatus.Items.AddRange(new object[] { "Новый", "В работе", "Ответ отправлен на почту", "Закрыто" });
        FeedbackStatus.Location = new Point(587, 328);
        FeedbackStatus.Name = "FeedbackStatus";
        FeedbackStatus.Size = new Size(290, 29);
        FeedbackStatus.TabIndex = 6;
        // 
        // StatusShow
        // 
        StatusShow.DropDownStyle = ComboBoxStyle.DropDownList;
        StatusShow.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
        StatusShow.FormattingEnabled = true;
        StatusShow.Items.AddRange(new object[] { "Новый", "В работе", "Ответ отправлен на почту", "Закрыто" });
        StatusShow.Location = new Point(12, 32);
        StatusShow.Name = "StatusShow";
        StatusShow.Size = new Size(213, 29);
        StatusShow.TabIndex = 8;
        StatusShow.SelectedIndexChanged += ChangeList;
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        label4.Location = new Point(12, 9);
        label4.Name = "label4";
        label4.Size = new Size(52, 20);
        label4.TabIndex = 7;
        label4.Text = "Статус";
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(587, 373);
        button1.Name = "button1";
        button1.Size = new Size(290, 60);
        button1.TabIndex = 9;
        button1.Text = "Сохранить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += SaveStateButtonClick;
        // 
        // UsersFeedback
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(889, 552);
        Controls.Add(button1);
        Controls.Add(StatusShow);
        Controls.Add(label4);
        Controls.Add(FeedbackStatus);
        Controls.Add(label3);
        Controls.Add(label2);
        Controls.Add(FeedbackEmail);
        Controls.Add(label1);
        Controls.Add(FeedbackText);
        Controls.Add(ListFeedbacks);
        Name = "UsersFeedback";
        Text = "UsersFeedback";
        Load += LoadFeedbacks;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private ListBox ListFeedbacks;
    private RichTextBox FeedbackText;
    private Label label1;
    private TextBox FeedbackEmail;
    private Label label2;
    private Label label3;
    private ComboBox FeedbackStatus;
    private ComboBox StatusShow;
    private Label label4;
    private Button button1;
}
