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
        button1 = new Button();
        button2 = new Button();
        button3 = new Button();
        SuspendLayout();
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(12, 12);
        button1.Name = "button1";
        button1.Size = new Size(436, 48);
        button1.TabIndex = 0;
        button1.Text = "Просмотр предложенных вопросов от пользователей";
        button1.UseVisualStyleBackColor = true;
        button1.Click += button1_Click;
        // 
        // button2
        // 
        button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button2.Location = new Point(12, 66);
        button2.Name = "button2";
        button2.Size = new Size(436, 48);
        button2.TabIndex = 1;
        button2.Text = "Добавление вопросов";
        button2.UseVisualStyleBackColor = true;
        button2.Click += button2_Click;
        // 
        // button3
        // 
        button3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button3.Location = new Point(12, 120);
        button3.Name = "button3";
        button3.Size = new Size(436, 48);
        button3.TabIndex = 2;
        button3.Text = "Добавление темы для вопросов";
        button3.UseVisualStyleBackColor = true;
        button3.Click += button3_Click;
        // 
        // MainPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(467, 184);
        Controls.Add(button3);
        Controls.Add(button2);
        Controls.Add(button1);
        Name = "MainPanel";
        Text = "Панель";
        FormClosed += MainPanel_FormClosed;
        ResumeLayout(false);
    }

    #endregion

    private Button button1;
    private Button button2;
    private Button button3;
}
