namespace RssHub
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.text_input = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.text_output = new System.Windows.Forms.TextBox();
            this.text_output2 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.text_input2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // text_input
            // 
            this.text_input.Font = new System.Drawing.Font("宋体", 9F);
            this.text_input.Location = new System.Drawing.Point(12, 32);
            this.text_input.Name = "text_input";
            this.text_input.Size = new System.Drawing.Size(425, 21);
            this.text_input.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 25F);
            this.button1.Location = new System.Drawing.Point(12, 79);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(425, 65);
            this.button1.TabIndex = 1;
            this.button1.Text = "转换";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // text_output
            // 
            this.text_output.Font = new System.Drawing.Font("宋体", 9F);
            this.text_output.Location = new System.Drawing.Point(12, 164);
            this.text_output.Name = "text_output";
            this.text_output.Size = new System.Drawing.Size(425, 21);
            this.text_output.TabIndex = 2;
            // 
            // text_output2
            // 
            this.text_output2.Font = new System.Drawing.Font("宋体", 9F);
            this.text_output2.Location = new System.Drawing.Point(12, 372);
            this.text_output2.Name = "text_output2";
            this.text_output2.Size = new System.Drawing.Size(425, 21);
            this.text_output2.TabIndex = 5;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 25F);
            this.button2.Location = new System.Drawing.Point(12, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(425, 65);
            this.button2.TabIndex = 4;
            this.button2.Text = "添加头部";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // text_input2
            // 
            this.text_input2.Font = new System.Drawing.Font("宋体", 9F);
            this.text_input2.Location = new System.Drawing.Point(12, 240);
            this.text_input2.Name = "text_input2";
            this.text_input2.Size = new System.Drawing.Size(425, 21);
            this.text_input2.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(449, 428);
            this.Controls.Add(this.text_output2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.text_input2);
            this.Controls.Add(this.text_output);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.text_input);
            this.Name = "Form1";
            this.Text = "RssHub链接转换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_input;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox text_output;
        private System.Windows.Forms.TextBox text_output2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox text_input2;
    }
}

