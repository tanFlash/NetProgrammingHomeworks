namespace WindowsFormsApplication1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.IPAdd_txb1 = new System.Windows.Forms.TextBox();
            this.IPAdd_txb2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Set_btn = new System.Windows.Forms.Button();
            this.port1_txb = new System.Windows.Forms.TextBox();
            this.port2_txt = new System.Windows.Forms.TextBox();
            this.port = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 227);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(177, 227);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(16, 162);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(237, 59);
            this.textBox1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter message";
            // 
            // IPAdd_txb1
            // 
            this.IPAdd_txb1.Location = new System.Drawing.Point(15, 29);
            this.IPAdd_txb1.Name = "IPAdd_txb1";
            this.IPAdd_txb1.Size = new System.Drawing.Size(100, 20);
            this.IPAdd_txb1.TabIndex = 4;
            // 
            // IPAdd_txb2
            // 
            this.IPAdd_txb2.Location = new System.Drawing.Point(152, 29);
            this.IPAdd_txb2.Name = "IPAdd_txb2";
            this.IPAdd_txb2.Size = new System.Drawing.Size(100, 20);
            this.IPAdd_txb2.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "IPAddress 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(156, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "IPAddress 2";
            // 
            // Set_btn
            // 
            this.Set_btn.Location = new System.Drawing.Point(90, 110);
            this.Set_btn.Name = "Set_btn";
            this.Set_btn.Size = new System.Drawing.Size(75, 23);
            this.Set_btn.TabIndex = 8;
            this.Set_btn.Text = "Set";
            this.Set_btn.UseVisualStyleBackColor = true;
            this.Set_btn.Click += new System.EventHandler(this.Set_btn_Click);
            // 
            // port1_txb
            // 
            this.port1_txb.Location = new System.Drawing.Point(18, 79);
            this.port1_txb.Name = "port1_txb";
            this.port1_txb.Size = new System.Drawing.Size(100, 20);
            this.port1_txb.TabIndex = 9;
            // 
            // port2_txt
            // 
            this.port2_txt.Location = new System.Drawing.Point(159, 79);
            this.port2_txt.Name = "port2_txt";
            this.port2_txt.Size = new System.Drawing.Size(100, 20);
            this.port2_txt.TabIndex = 10;
            // 
            // port
            // 
            this.port.AutoSize = true;
            this.port.Location = new System.Drawing.Point(24, 60);
            this.port.Name = "port";
            this.port.Size = new System.Drawing.Size(34, 13);
            this.port.TabIndex = 11;
            this.port.Text = "port 1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(159, 60);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "port 2";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.port);
            this.Controls.Add(this.port2_txt);
            this.Controls.Add(this.port1_txb);
            this.Controls.Add(this.Set_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IPAdd_txb2);
            this.Controls.Add(this.IPAdd_txb1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox IPAdd_txb1;
        private System.Windows.Forms.TextBox IPAdd_txb2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Set_btn;
        private System.Windows.Forms.TextBox port1_txb;
        private System.Windows.Forms.TextBox port2_txt;
        private System.Windows.Forms.Label port;
        private System.Windows.Forms.Label label4;
    }
}

