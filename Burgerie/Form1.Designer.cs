namespace Tema_lab2
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
            this.textUser = new System.Windows.Forms.TextBox();
            this.textPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.butLog = new System.Windows.Forms.Button();
            this.butReg = new System.Windows.Forms.Button();
            this.labelReg = new System.Windows.Forms.Label();
            this.bttCreate = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textUser
            // 
            this.textUser.Location = new System.Drawing.Point(315, 88);
            this.textUser.Name = "textUser";
            this.textUser.Size = new System.Drawing.Size(182, 22);
            this.textUser.TabIndex = 0;
            // 
            // textPass
            // 
            this.textPass.Location = new System.Drawing.Point(315, 133);
            this.textPass.Name = "textPass";
            this.textPass.PasswordChar = '*';
            this.textPass.Size = new System.Drawing.Size(182, 22);
            this.textPass.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password:";
            // 
            // butLog
            // 
            this.butLog.Location = new System.Drawing.Point(338, 189);
            this.butLog.Name = "butLog";
            this.butLog.Size = new System.Drawing.Size(106, 24);
            this.butLog.TabIndex = 4;
            this.butLog.Text = "Login";
            this.butLog.UseVisualStyleBackColor = true;
            this.butLog.Click += new System.EventHandler(this.butLog_Click);
            // 
            // butReg
            // 
            this.butReg.Location = new System.Drawing.Point(338, 277);
            this.butReg.Name = "butReg";
            this.butReg.Size = new System.Drawing.Size(106, 24);
            this.butReg.TabIndex = 5;
            this.butReg.Text = "Register";
            this.butReg.UseVisualStyleBackColor = true;
            this.butReg.Visible = false;
            this.butReg.Click += new System.EventHandler(this.butReg_Click);
            // 
            // labelReg
            // 
            this.labelReg.AutoSize = true;
            this.labelReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.labelReg.Location = new System.Drawing.Point(287, 27);
            this.labelReg.Name = "labelReg";
            this.labelReg.Size = new System.Drawing.Size(238, 29);
            this.labelReg.TabIndex = 6;
            this.labelReg.Text = "Connect to account:";
            // 
            // bttCreate
            // 
            this.bttCreate.Location = new System.Drawing.Point(338, 233);
            this.bttCreate.Name = "bttCreate";
            this.bttCreate.Size = new System.Drawing.Size(106, 23);
            this.bttCreate.TabIndex = 7;
            this.bttCreate.Text = "Create account";
            this.bttCreate.UseVisualStyleBackColor = true;
            this.bttCreate.Click += new System.EventHandler(this.bttCreate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bttCreate);
            this.Controls.Add(this.labelReg);
            this.Controls.Add(this.butReg);
            this.Controls.Add(this.butLog);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textPass);
            this.Controls.Add(this.textUser);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textUser;
        private System.Windows.Forms.TextBox textPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butLog;
        private System.Windows.Forms.Button butReg;
        private System.Windows.Forms.Label labelReg;
        private System.Windows.Forms.Button bttCreate;
    }
}

