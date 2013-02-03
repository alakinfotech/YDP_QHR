
namespace QHRLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.w = new System.Windows.Forms.Label();
            this.tBoxUID = new System.Windows.Forms.TextBox();
            this.Pwd = new System.Windows.Forms.Label();
            this.tBoxPwd = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // w
            // 
            this.w.AutoSize = true;
            this.w.BackColor = System.Drawing.Color.White;
            this.w.Location = new System.Drawing.Point(266, 321);
            this.w.Name = "w";
            this.w.Size = new System.Drawing.Size(43, 13);
            this.w.TabIndex = 0;
            this.w.Text = "User ID";
            this.w.Click += new System.EventHandler(this.w_Click);
            // 
            // tBoxUID
            // 
            this.tBoxUID.Location = new System.Drawing.Point(316, 321);
            this.tBoxUID.Name = "tBoxUID";
            this.tBoxUID.Size = new System.Drawing.Size(187, 20);
            this.tBoxUID.TabIndex = 1;
            this.tBoxUID.TextChanged += new System.EventHandler(this.tBoxUID_TextChanged);
            // 
            // Pwd
            // 
            this.Pwd.AutoSize = true;
            this.Pwd.BackColor = System.Drawing.Color.White;
            this.Pwd.Location = new System.Drawing.Point(269, 354);
            this.Pwd.Name = "Pwd";
            this.Pwd.Size = new System.Drawing.Size(28, 13);
            this.Pwd.TabIndex = 2;
            this.Pwd.Text = "Pwd";
            this.Pwd.Click += new System.EventHandler(this.Pwd_Click);
            // 
            // tBoxPwd
            // 
            this.tBoxPwd.Location = new System.Drawing.Point(316, 354);
            this.tBoxPwd.Name = "tBoxPwd";
            this.tBoxPwd.Size = new System.Drawing.Size(187, 20);
            this.tBoxPwd.TabIndex = 3;
            this.tBoxPwd.TextChanged += new System.EventHandler(this.tBoxPwd_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(316, 381);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 23);
            this.Login.TabIndex = 4;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(900, 638);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.tBoxPwd);
            this.Controls.Add(this.Pwd);
            this.Controls.Add(this.tBoxUID);
            this.Controls.Add(this.w);
            this.Name = "Form1";
            this.Text = "WebService Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label w;
        private System.Windows.Forms.TextBox tBoxUID;
        private System.Windows.Forms.Label Pwd;
        private System.Windows.Forms.TextBox tBoxPwd;
        private System.Windows.Forms.Button Login;
    }
}

