namespace FortuneTeller
{
    partial class FormPstory
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
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(620, 12);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(168, 42);
            this.btnRefresh.TabIndex = 0;
            this.btnRefresh.Text = "새로고침";
            this.btnRefresh.UseVisualStyleBackColor = true;
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.ItemHeight = 12;
            this.lbHistory.Items.AddRange(new object[] {
            "2025-08-26 15: 01 C#을 배워봐요.",
            "2025-08-26 16: 01 프로젝트를 만들어봐요.",
            "2025-08-26 15: 01 C#을 배워봐요.",
            "2025-08-26 16: 01 프로젝트를 만들어봐요.",
            "2025-08-26 15: 01 C#을 배워봐요.",
            "2025-08-26 16: 01 프로젝트를 만들어봐요.",
            "2025-08-26 15: 01 C#을 배워봐요.",
            "2025-08-26 16: 01 프로젝트를 만들어봐요.",
            "2025-08-26 15: 01 C#을 배워봐요.",
            "2025-08-26 16: 01 프로젝트를 만들어봐요."});
            this.lbHistory.Location = new System.Drawing.Point(12, 68);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.Size = new System.Drawing.Size(776, 364);
            this.lbHistory.TabIndex = 1;
            // 
            // FormPstory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnRefresh);
            this.Name = "FormPstory";
            this.Text = "내역 불러오기";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.ListBox lbHistory;
    }
}