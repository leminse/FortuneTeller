namespace FortuneTeller
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.b = new System.Windows.Forms.Button();
            this.tb = new System.Windows.Forms.TextBox();
            this.t = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.d = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t);
            this.groupBox1.Controls.Add(this.tb);
            this.groupBox1.Controls.Add(this.b);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "사용자 정보 입력";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.d);
            this.groupBox2.Location = new System.Drawing.Point(392, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(396, 426);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "결과 보기";
            // 
            // b
            // 
            this.b.Location = new System.Drawing.Point(42, 336);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(286, 43);
            this.b.TabIndex = 0;
            this.b.Text = "결과보기";
            this.b.UseVisualStyleBackColor = true;
            // 
            // tb
            // 
            this.tb.Location = new System.Drawing.Point(64, 208);
            this.tb.Name = "tb";
            this.tb.Size = new System.Drawing.Size(231, 21);
            this.tb.TabIndex = 1;
            // 
            // t
            // 
            this.t.Location = new System.Drawing.Point(64, 133);
            this.t.Name = "t";
            this.t.Size = new System.Drawing.Size(231, 21);
            this.t.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "생년월일입력(예:20070526)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "태어난 시각(예:3시15분 -> 03)";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // d
            // 
            this.d.Location = new System.Drawing.Point(20, 31);
            this.d.Multiline = true;
            this.d.Name = "d";
            this.d.Size = new System.Drawing.Size(354, 374);
            this.d.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "포춘텔러";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t;
        private System.Windows.Forms.TextBox tb;
        private System.Windows.Forms.Button b;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox d;
    }
}

