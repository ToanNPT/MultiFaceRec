
namespace MultiFaceRec
{
    partial class PasswordLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PasswordLogin));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.bsignin = new System.Windows.Forms.Button();
            this.bsignup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Info;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "UserName";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Info;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(61, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(221, 74);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(256, 37);
            this.txtusername.TabIndex = 3;
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft YaHei", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(221, 164);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.PasswordChar = '*';
            this.txtpassword.Size = new System.Drawing.Size(256, 37);
            this.txtpassword.TabIndex = 4;
            // 
            // bsignin
            // 
            this.bsignin.BackColor = System.Drawing.Color.DarkCyan;
            this.bsignin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsignin.BackgroundImage")));
            this.bsignin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bsignin.Cursor = System.Windows.Forms.Cursors.Default;
            this.bsignin.FlatAppearance.BorderSize = 0;
            this.bsignin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsignin.Location = new System.Drawing.Point(134, 285);
            this.bsignin.Name = "bsignin";
            this.bsignin.Size = new System.Drawing.Size(91, 81);
            this.bsignin.TabIndex = 5;
            this.bsignin.UseVisualStyleBackColor = false;
            this.bsignin.Click += new System.EventHandler(this.bsignin_Click);
            // 
            // bsignup
            // 
            this.bsignup.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.bsignup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bsignup.BackgroundImage")));
            this.bsignup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bsignup.FlatAppearance.BorderSize = 0;
            this.bsignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bsignup.Location = new System.Drawing.Point(334, 285);
            this.bsignup.Name = "bsignup";
            this.bsignup.Size = new System.Drawing.Size(86, 81);
            this.bsignup.TabIndex = 6;
            this.bsignup.UseVisualStyleBackColor = false;
            this.bsignup.Click += new System.EventHandler(this.bsignup_Click);
            // 
            // PasswordLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(575, 425);
            this.Controls.Add(this.bsignup);
            this.Controls.Add(this.bsignin);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "PasswordLogin";
            this.Text = "PasswordLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button bsignin;
        private System.Windows.Forms.Button bsignup;
    }
}