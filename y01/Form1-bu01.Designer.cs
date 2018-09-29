namespace y01
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.Start_Timer1box = new System.Windows.Forms.TextBox();
            this.Start_Timer2box = new System.Windows.Forms.TextBox();
            this.Start_Timer3box = new System.Windows.Forms.TextBox();
            this.timer = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Stop_Timer3box = new System.Windows.Forms.TextBox();
            this.Stop_Timer2box = new System.Windows.Forms.TextBox();
            this.Stop_Timer1box = new System.Windows.Forms.TextBox();
            this.folderpath = new System.Windows.Forms.TextBox();
            this.upload2 = new System.Windows.Forms.Button();
            this.run = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.window_name = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.Stop_Timer4box = new System.Windows.Forms.TextBox();
            this.Start_Timer4box = new System.Windows.Forms.TextBox();
            this.counter = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.acount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "وقت 1 ";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(76, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(260, 21);
            this.button3.TabIndex = 24;
            this.button3.Text = "اختر موقع التسجيل";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Start_Timer1box
            // 
            this.Start_Timer1box.Location = new System.Drawing.Point(258, 247);
            this.Start_Timer1box.Name = "Start_Timer1box";
            this.Start_Timer1box.Size = new System.Drawing.Size(100, 20);
            this.Start_Timer1box.TabIndex = 42;
            this.Start_Timer1box.Text = "00:00:00";
            // 
            // Start_Timer2box
            // 
            this.Start_Timer2box.Location = new System.Drawing.Point(258, 280);
            this.Start_Timer2box.Name = "Start_Timer2box";
            this.Start_Timer2box.Size = new System.Drawing.Size(100, 20);
            this.Start_Timer2box.TabIndex = 43;
            this.Start_Timer2box.Text = "00:00";
            // 
            // Start_Timer3box
            // 
            this.Start_Timer3box.Location = new System.Drawing.Point(258, 318);
            this.Start_Timer3box.Name = "Start_Timer3box";
            this.Start_Timer3box.Size = new System.Drawing.Size(100, 20);
            this.Start_Timer3box.TabIndex = 44;
            this.Start_Timer3box.Text = "00:00";
            // 
            // timer
            // 
            this.timer.Font = new System.Drawing.Font("Symbol", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.timer.Location = new System.Drawing.Point(76, 12);
            this.timer.Name = "timer";
            this.timer.Size = new System.Drawing.Size(260, 86);
            this.timer.TabIndex = 46;
            this.timer.TextChanged += new System.EventHandler(this.timer_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(234, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 30);
            this.label5.TabIndex = 48;
            this.label5.Text = "أوقات بدأ التسجيل";
            // 
            // Stop_Timer3box
            // 
            this.Stop_Timer3box.Location = new System.Drawing.Point(53, 318);
            this.Stop_Timer3box.Name = "Stop_Timer3box";
            this.Stop_Timer3box.Size = new System.Drawing.Size(100, 20);
            this.Stop_Timer3box.TabIndex = 54;
            this.Stop_Timer3box.Text = "00:00";
            this.Stop_Timer3box.TextChanged += new System.EventHandler(this.teisha_TextChanged);
            // 
            // Stop_Timer2box
            // 
            this.Stop_Timer2box.Location = new System.Drawing.Point(53, 285);
            this.Stop_Timer2box.Name = "Stop_Timer2box";
            this.Stop_Timer2box.Size = new System.Drawing.Size(100, 20);
            this.Stop_Timer2box.TabIndex = 53;
            this.Stop_Timer2box.Text = "00:00";
            // 
            // Stop_Timer1box
            // 
            this.Stop_Timer1box.Location = new System.Drawing.Point(53, 252);
            this.Stop_Timer1box.Name = "Stop_Timer1box";
            this.Stop_Timer1box.Size = new System.Drawing.Size(100, 20);
            this.Stop_Timer1box.TabIndex = 52;
            this.Stop_Timer1box.Text = "00:00:00";
            // 
            // folderpath
            // 
            this.folderpath.Enabled = false;
            this.folderpath.Location = new System.Drawing.Point(76, 153);
            this.folderpath.Name = "folderpath";
            this.folderpath.Size = new System.Drawing.Size(260, 20);
            this.folderpath.TabIndex = 57;
            this.folderpath.Text = "C:\\Users\\ibrah\\Videos";
            // 
            // upload2
            // 
            this.upload2.Enabled = false;
            this.upload2.Location = new System.Drawing.Point(322, 514);
            this.upload2.Name = "upload2";
            this.upload2.Size = new System.Drawing.Size(75, 23);
            this.upload2.TabIndex = 63;
            this.upload2.Text = "Upload to Youtube";
            this.upload2.UseVisualStyleBackColor = true;
            this.upload2.Visible = false;
            this.upload2.Click += new System.EventHandler(this.upload2_Click);
            // 
            // run
            // 
            this.run.Enabled = false;
            this.run.Location = new System.Drawing.Point(12, 513);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(304, 23);
            this.run.TabIndex = 64;
            this.run.Text = "تشغيــــــــــــــــــــــــــل";
            this.run.UseVisualStyleBackColor = true;
            this.run.Visible = false;
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 280);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 25);
            this.label3.TabIndex = 65;
            this.label3.Text = "وقت 2";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(364, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 66;
            this.label4.Text = "وقت 3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 209);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 30);
            this.label6.TabIndex = 67;
            this.label6.Text = "أوقات ايقاف التسجيل";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 318);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 25);
            this.label1.TabIndex = 70;
            this.label1.Text = "وقت 3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(168, 280);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 25);
            this.label7.TabIndex = 69;
            this.label7.Text = "وقت 2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(168, 244);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "وقت 1 ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(232, 395);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 21);
            this.label12.TabIndex = 76;
            this.label12.Text = "اسم نافذة برنامج التسجيل";
            // 
            // window_name
            // 
            this.window_name.Location = new System.Drawing.Point(38, 419);
            this.window_name.Name = "window_name";
            this.window_name.Size = new System.Drawing.Size(293, 20);
            this.window_name.TabIndex = 77;
            this.window_name.Text = "OBS 22.0.2 (64-bit, windows) - Profile: Untitled - Scenes: Untitled";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(168, 355);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 25);
            this.label13.TabIndex = 81;
            this.label13.Text = "وقت 4";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(364, 355);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 25);
            this.label14.TabIndex = 80;
            this.label14.Text = "وقت 4";
            // 
            // Stop_Timer4box
            // 
            this.Stop_Timer4box.Location = new System.Drawing.Point(53, 355);
            this.Stop_Timer4box.Name = "Stop_Timer4box";
            this.Stop_Timer4box.Size = new System.Drawing.Size(100, 20);
            this.Stop_Timer4box.TabIndex = 79;
            this.Stop_Timer4box.Text = "00:00";
            // 
            // Start_Timer4box
            // 
            this.Start_Timer4box.Location = new System.Drawing.Point(258, 355);
            this.Start_Timer4box.Name = "Start_Timer4box";
            this.Start_Timer4box.Size = new System.Drawing.Size(100, 20);
            this.Start_Timer4box.TabIndex = 78;
            this.Start_Timer4box.Text = "00:00";
            // 
            // counter
            // 
            this.counter.Enabled = false;
            this.counter.Location = new System.Drawing.Point(404, 517);
            this.counter.Name = "counter";
            this.counter.Size = new System.Drawing.Size(34, 20);
            this.counter.TabIndex = 82;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(307, 442);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 21);
            this.label9.TabIndex = 83;
            this.label9.Text = "اسم الحساب";
            // 
            // acount
            // 
            this.acount.Location = new System.Drawing.Point(215, 467);
            this.acount.Name = "acount";
            this.acount.Size = new System.Drawing.Size(116, 20);
            this.acount.TabIndex = 84;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 548);
            this.Controls.Add(this.acount);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.counter);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Stop_Timer4box);
            this.Controls.Add(this.Start_Timer4box);
            this.Controls.Add(this.window_name);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.run);
            this.Controls.Add(this.upload2);
            this.Controls.Add(this.folderpath);
            this.Controls.Add(this.Stop_Timer3box);
            this.Controls.Add(this.Stop_Timer2box);
            this.Controls.Add(this.Stop_Timer1box);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.timer);
            this.Controls.Add(this.Start_Timer3box);
            this.Controls.Add(this.Start_Timer2box);
            this.Controls.Add(this.Start_Timer1box);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox Start_Timer1box;
        private System.Windows.Forms.TextBox Start_Timer2box;
        private System.Windows.Forms.TextBox Start_Timer3box;
        private System.Windows.Forms.TextBox timer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Stop_Timer3box;
        private System.Windows.Forms.TextBox Stop_Timer2box;
        private System.Windows.Forms.TextBox Stop_Timer1box;
        private System.Windows.Forms.TextBox folderpath;
        private System.Windows.Forms.Button upload2;
        private System.Windows.Forms.Button run;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox window_name;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Stop_Timer4box;
        private System.Windows.Forms.TextBox Start_Timer4box;
        public System.Windows.Forms.TextBox counter;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox acount;
    }
}

