namespace AsthmaApp
{
    partial class LoginPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usernametxt = new System.Windows.Forms.TextBox();
            this.passwordtxt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginbtn = new System.Windows.Forms.Button();
            this.closebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Asthma Desktop App";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "ชื่อผู้ใช้";
            // 
            // usernametxt
            // 
            this.usernametxt.Location = new System.Drawing.Point(139, 105);
            this.usernametxt.Name = "usernametxt";
            this.usernametxt.Size = new System.Drawing.Size(165, 20);
            this.usernametxt.TabIndex = 2;
            // 
            // passwordtxt
            // 
            this.passwordtxt.Location = new System.Drawing.Point(139, 153);
            this.passwordtxt.Name = "passwordtxt";
            this.passwordtxt.PasswordChar = '*';
            this.passwordtxt.Size = new System.Drawing.Size(165, 20);
            this.passwordtxt.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "รหัสผ่าน";
            // 
            // loginbtn
            // 
            this.loginbtn.Location = new System.Drawing.Point(57, 210);
            this.loginbtn.Name = "loginbtn";
            this.loginbtn.Size = new System.Drawing.Size(89, 30);
            this.loginbtn.TabIndex = 5;
            this.loginbtn.Text = "เข้าสู่ระบบ";
            this.loginbtn.UseVisualStyleBackColor = true;
            this.loginbtn.Click += new System.EventHandler(this.loginbtn_Click);
            // 
            // closebtn
            // 
            this.closebtn.Location = new System.Drawing.Point(232, 210);
            this.closebtn.Name = "closebtn";
            this.closebtn.Size = new System.Drawing.Size(89, 30);
            this.closebtn.TabIndex = 6;
            this.closebtn.Text = "ยกเลิก";
            this.closebtn.UseVisualStyleBackColor = true;
            this.closebtn.Click += new System.EventHandler(this.closebtn_Click);
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 279);
            this.Controls.Add(this.closebtn);
            this.Controls.Add(this.loginbtn);
            this.Controls.Add(this.passwordtxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.usernametxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asthma Desktop App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usernametxt;
        private System.Windows.Forms.TextBox passwordtxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginbtn;
        private System.Windows.Forms.Button closebtn;
    }
}

