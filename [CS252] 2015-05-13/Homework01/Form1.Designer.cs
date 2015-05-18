namespace Homework01
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.longLabel = new System.Windows.Forms.Label();
            this.widthLabel = new System.Windows.Forms.Label();
            this.widthTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.RetanglePictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.RetanglePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(50, 34);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(79, 22);
            this.lengthTextBox.TabIndex = 0;
            this.lengthTextBox.Text = "100";
            // 
            // longLabel
            // 
            this.longLabel.AutoSize = true;
            this.longLabel.Location = new System.Drawing.Point(12, 34);
            this.longLabel.Name = "longLabel";
            this.longLabel.Size = new System.Drawing.Size(17, 12);
            this.longLabel.TabIndex = 1;
            this.longLabel.Text = "長";
            // 
            // widthLabel
            // 
            this.widthLabel.AutoSize = true;
            this.widthLabel.Location = new System.Drawing.Point(12, 71);
            this.widthLabel.Name = "widthLabel";
            this.widthLabel.Size = new System.Drawing.Size(17, 12);
            this.widthLabel.TabIndex = 2;
            this.widthLabel.Text = "寬";
            // 
            // widthTextBox
            // 
            this.widthTextBox.Location = new System.Drawing.Point(50, 71);
            this.widthTextBox.Name = "widthTextBox";
            this.widthTextBox.Size = new System.Drawing.Size(79, 22);
            this.widthTextBox.TabIndex = 3;
            this.widthTextBox.Text = "100";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.button1.Location = new System.Drawing.Point(175, 34);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 59);
            this.button1.TabIndex = 4;
            this.button1.Text = "繪制矩形";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // RetanglePictureBox
            // 
            this.RetanglePictureBox.Location = new System.Drawing.Point(25, 123);
            this.RetanglePictureBox.Name = "RetanglePictureBox";
            this.RetanglePictureBox.Size = new System.Drawing.Size(527, 318);
            this.RetanglePictureBox.TabIndex = 5;
            this.RetanglePictureBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 453);
            this.Controls.Add(this.RetanglePictureBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.widthTextBox);
            this.Controls.Add(this.widthLabel);
            this.Controls.Add(this.longLabel);
            this.Controls.Add(this.lengthTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.RetanglePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.Label longLabel;
        private System.Windows.Forms.Label widthLabel;
        private System.Windows.Forms.TextBox widthTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox RetanglePictureBox;
    }
}

