namespace Example02
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
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.Guy1Givebutton = new System.Windows.Forms.Button();
            this.Guy1Name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Guy2Givebutton = new System.Windows.Forms.Button();
            this.Guy2Name = new System.Windows.Forms.Label();
            this.Guy1Cash = new System.Windows.Forms.Label();
            this.Guy2Cash = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Guy1Givebutton
            // 
            this.Guy1Givebutton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy1Givebutton.Location = new System.Drawing.Point(53, 362);
            this.Guy1Givebutton.Name = "Guy1Givebutton";
            this.Guy1Givebutton.Size = new System.Drawing.Size(322, 88);
            this.Guy1Givebutton.TabIndex = 0;
            this.Guy1Givebutton.Text = "guy1 給 guy2";
            this.Guy1Givebutton.UseVisualStyleBackColor = true;
            this.Guy1Givebutton.Click += new System.EventHandler(this.Guy1Givebutton_Click);
            // 
            // Guy1Name
            // 
            this.Guy1Name.AutoSize = true;
            this.Guy1Name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy1Name.Location = new System.Drawing.Point(126, 73);
            this.Guy1Name.Name = "Guy1Name";
            this.Guy1Name.Size = new System.Drawing.Size(219, 45);
            this.Guy1Name.TabIndex = 1;
            this.Guy1Name.Text = "Guy1Name:";
            this.Guy1Name.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox1.Location = new System.Drawing.Point(53, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 51);
            this.textBox1.TabIndex = 2;
            // 
            // Guy2Givebutton
            // 
            this.Guy2Givebutton.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy2Givebutton.Location = new System.Drawing.Point(427, 362);
            this.Guy2Givebutton.Name = "Guy2Givebutton";
            this.Guy2Givebutton.Size = new System.Drawing.Size(315, 88);
            this.Guy2Givebutton.TabIndex = 3;
            this.Guy2Givebutton.Text = "guy2 給 guy1";
            this.Guy2Givebutton.UseVisualStyleBackColor = true;
            this.Guy2Givebutton.Click += new System.EventHandler(this.Guy2Givebutton_Click);
            // 
            // Guy2Name
            // 
            this.Guy2Name.AutoSize = true;
            this.Guy2Name.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy2Name.Location = new System.Drawing.Point(126, 164);
            this.Guy2Name.Name = "Guy2Name";
            this.Guy2Name.Size = new System.Drawing.Size(219, 45);
            this.Guy2Name.TabIndex = 4;
            this.Guy2Name.Text = "Guy2Name:";
            // 
            // Guy1Cash
            // 
            this.Guy1Cash.AutoSize = true;
            this.Guy1Cash.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy1Cash.Location = new System.Drawing.Point(459, 73);
            this.Guy1Cash.Name = "Guy1Cash";
            this.Guy1Cash.Size = new System.Drawing.Size(199, 45);
            this.Guy1Cash.TabIndex = 5;
            this.Guy1Cash.Text = "Guy1Cash:";
            // 
            // Guy2Cash
            // 
            this.Guy2Cash.AutoSize = true;
            this.Guy2Cash.Font = new System.Drawing.Font("微軟正黑體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Guy2Cash.Location = new System.Drawing.Point(459, 164);
            this.Guy2Cash.Name = "Guy2Cash";
            this.Guy2Cash.Size = new System.Drawing.Size(199, 45);
            this.Guy2Cash.TabIndex = 6;
            this.Guy2Cash.Text = "Guy2Cash:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("新細明體", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.textBox2.Location = new System.Drawing.Point(427, 291);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(246, 51);
            this.textBox2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(109, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(427, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(826, 506);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Guy2Cash);
            this.Controls.Add(this.Guy1Cash);
            this.Controls.Add(this.Guy2Name);
            this.Controls.Add(this.Guy2Givebutton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Guy1Name);
            this.Controls.Add(this.Guy1Givebutton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Guy1Givebutton;
        private System.Windows.Forms.Label Guy1Name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Guy2Givebutton;
        private System.Windows.Forms.Label Guy2Name;
        private System.Windows.Forms.Label Guy1Cash;
        private System.Windows.Forms.Label Guy2Cash;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

