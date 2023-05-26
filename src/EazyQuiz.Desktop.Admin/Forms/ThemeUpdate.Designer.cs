namespace EazyQuiz.Admin.Desktop;

partial class ThemeUpdate
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
        ThemeList = new CheckedListBox();
        button1 = new Button();
        SuspendLayout();
        // 
        // ThemeList
        // 
        ThemeList.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        ThemeList.FormattingEnabled = true;
        ThemeList.Location = new Point(12, 12);
        ThemeList.Name = "ThemeList";
        ThemeList.Size = new Size(328, 378);
        ThemeList.TabIndex = 0;
        ThemeList.SelectedIndexChanged += ThemeList_SelectedIndexChanged;
        // 
        // button1
        // 
        button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
        button1.Location = new Point(12, 396);
        button1.Name = "button1";
        button1.Size = new Size(328, 33);
        button1.TabIndex = 1;
        button1.Text = "Сохранить";
        button1.UseVisualStyleBackColor = true;
        button1.Click += UpdateAllThemes;
        // 
        // ThemeUpdate
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(356, 450);
        Controls.Add(button1);
        Controls.Add(ThemeList);
        Name = "ThemeUpdate";
        Text = "Настройка тем";
        Load += LoadThemes;
        ResumeLayout(false);
    }

    #endregion

    private CheckedListBox ThemeList;
    private Button button1;
}
