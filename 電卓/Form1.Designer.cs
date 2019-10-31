namespace 電卓
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button和 = new System.Windows.Forms.Button();
            this.button差 = new System.Windows.Forms.Button();
            this.button積 = new System.Windows.Forms.Button();
            this.button商 = new System.Windows.Forms.Button();
            this.buttonC = new System.Windows.Forms.Button();
            this.button求 = new System.Windows.Forms.Button();
            this.buttonBS = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(12)));
            this.textBox1.Location = new System.Drawing.Point(12, 12);
            this.textBox1.MaxLength = 16;
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(330, 84);
            this.textBox1.TabIndex = 0;
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.SystemColors.Window;
            this.button0.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button0.ForeColor = System.Drawing.Color.Black;
            this.button0.Location = new System.Drawing.Point(96, 394);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(78, 49);
            this.button0.TabIndex = 1;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button0_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button1.Location = new System.Drawing.Point(12, 339);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(78, 49);
            this.button1.TabIndex = 2;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button2.Location = new System.Drawing.Point(96, 339);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(78, 49);
            this.button2.TabIndex = 3;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.Window;
            this.button3.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button3.Location = new System.Drawing.Point(180, 339);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(78, 49);
            this.button3.TabIndex = 4;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.Window;
            this.button4.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button4.Location = new System.Drawing.Point(12, 284);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 49);
            this.button4.TabIndex = 5;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Window;
            this.button5.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button5.Location = new System.Drawing.Point(96, 284);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(78, 49);
            this.button5.TabIndex = 6;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.Window;
            this.button6.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button6.Location = new System.Drawing.Point(180, 284);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(78, 49);
            this.button6.TabIndex = 7;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.Window;
            this.button7.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button7.Location = new System.Drawing.Point(12, 229);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(78, 49);
            this.button7.TabIndex = 8;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.Window;
            this.button8.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button8.Location = new System.Drawing.Point(96, 229);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(78, 49);
            this.button8.TabIndex = 9;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Window;
            this.button9.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button9.Location = new System.Drawing.Point(180, 229);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(78, 49);
            this.button9.TabIndex = 10;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button和
            // 
            this.button和.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button和.Location = new System.Drawing.Point(264, 339);
            this.button和.Name = "button和";
            this.button和.Size = new System.Drawing.Size(78, 49);
            this.button和.TabIndex = 11;
            this.button和.Text = "+";
            this.button和.UseVisualStyleBackColor = true;
            this.button和.Click += new System.EventHandler(this.button和_Click);
            // 
            // button差
            // 
            this.button差.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button差.Location = new System.Drawing.Point(264, 284);
            this.button差.Name = "button差";
            this.button差.Size = new System.Drawing.Size(78, 49);
            this.button差.TabIndex = 12;
            this.button差.Text = "-";
            this.button差.UseVisualStyleBackColor = true;
            this.button差.Click += new System.EventHandler(this.button差_Click);
            // 
            // button積
            // 
            this.button積.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button積.Location = new System.Drawing.Point(264, 229);
            this.button積.Name = "button積";
            this.button積.Size = new System.Drawing.Size(78, 49);
            this.button積.TabIndex = 13;
            this.button積.Text = "×";
            this.button積.UseVisualStyleBackColor = true;
            this.button積.Click += new System.EventHandler(this.button積_Click);
            // 
            // button商
            // 
            this.button商.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button商.Location = new System.Drawing.Point(264, 174);
            this.button商.Name = "button商";
            this.button商.Size = new System.Drawing.Size(78, 49);
            this.button商.TabIndex = 14;
            this.button商.Text = "÷";
            this.button商.UseVisualStyleBackColor = true;
            this.button商.Click += new System.EventHandler(this.button商_Click);
            // 
            // buttonC
            // 
            this.buttonC.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonC.Location = new System.Drawing.Point(12, 174);
            this.buttonC.Name = "buttonC";
            this.buttonC.Size = new System.Drawing.Size(78, 49);
            this.buttonC.TabIndex = 15;
            this.buttonC.Text = "C";
            this.buttonC.UseVisualStyleBackColor = true;
            this.buttonC.Click += new System.EventHandler(this.buttonC_Click);
            // 
            // button求
            // 
            this.button求.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.button求.Location = new System.Drawing.Point(262, 394);
            this.button求.Name = "button求";
            this.button求.Size = new System.Drawing.Size(78, 49);
            this.button求.TabIndex = 16;
            this.button求.Text = "=";
            this.button求.UseVisualStyleBackColor = true;
            this.button求.Click += new System.EventHandler(this.button求_Click);
            // 
            // buttonBS
            // 
            this.buttonBS.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonBS.Location = new System.Drawing.Point(180, 174);
            this.buttonBS.Name = "buttonBS";
            this.buttonBS.Size = new System.Drawing.Size(78, 49);
            this.buttonBS.TabIndex = 17;
            this.buttonBS.Text = "⌫";
            this.buttonBS.UseVisualStyleBackColor = true;
            this.buttonBS.Click += new System.EventHandler(this.buttonBS_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(259, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 27);
            this.label1.TabIndex = 18;
            // 
            // buttonCE
            // 
            this.buttonCE.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.buttonCE.Location = new System.Drawing.Point(96, 174);
            this.buttonCE.Name = "buttonCE";
            this.buttonCE.Size = new System.Drawing.Size(78, 49);
            this.buttonCE.TabIndex = 19;
            this.buttonCE.Text = "CE";
            this.buttonCE.UseVisualStyleBackColor = true;
            this.buttonCE.Click += new System.EventHandler(this.buttonCE_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 455);
            this.Controls.Add(this.buttonCE);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBS);
            this.Controls.Add(this.button求);
            this.Controls.Add(this.buttonC);
            this.Controls.Add(this.button商);
            this.Controls.Add(this.button積);
            this.Controls.Add(this.button差);
            this.Controls.Add(this.button和);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "電卓";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button和;
        private System.Windows.Forms.Button button差;
        private System.Windows.Forms.Button button積;
        private System.Windows.Forms.Button button商;
        private System.Windows.Forms.Button buttonC;
        private System.Windows.Forms.Button button求;
        private System.Windows.Forms.Button buttonBS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCE;
    }
}

