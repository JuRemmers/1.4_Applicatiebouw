namespace LoginScherm
{
    partial class LoginScherm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginScherm));
            this.tb_wacthwoord = new System.Windows.Forms.TextBox();
            this.tb_werknemer_id = new System.Windows.Forms.TextBox();
            this.b_login_enter = new System.Windows.Forms.Button();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.lbl_werknemer_id = new System.Windows.Forms.Label();
            this.lbl_login = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_wacthwoord
            // 
            this.tb_wacthwoord.Location = new System.Drawing.Point(220, 437);
            this.tb_wacthwoord.Name = "tb_wacthwoord";
            this.tb_wacthwoord.Size = new System.Drawing.Size(132, 20);
            this.tb_wacthwoord.TabIndex = 3;
            // 
            // tb_werknemer_id
            // 
            this.tb_werknemer_id.Location = new System.Drawing.Point(220, 393);
            this.tb_werknemer_id.Name = "tb_werknemer_id";
            this.tb_werknemer_id.Size = new System.Drawing.Size(132, 20);
            this.tb_werknemer_id.TabIndex = 2;
            // 
            // b_login_enter
            // 
            this.b_login_enter.Location = new System.Drawing.Point(220, 482);
            this.b_login_enter.Name = "b_login_enter";
            this.b_login_enter.Size = new System.Drawing.Size(132, 23);
            this.b_login_enter.TabIndex = 4;
            this.b_login_enter.Text = "Enter";
            this.b_login_enter.UseVisualStyleBackColor = true;
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(100, 440);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbl_wachtwoord.TabIndex = 1;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // lbl_werknemer_id
            // 
            this.lbl_werknemer_id.AutoSize = true;
            this.lbl_werknemer_id.Location = new System.Drawing.Point(92, 393);
            this.lbl_werknemer_id.Name = "lbl_werknemer_id";
            this.lbl_werknemer_id.Size = new System.Drawing.Size(76, 13);
            this.lbl_werknemer_id.TabIndex = 0;
            this.lbl_werknemer_id.Text = "Werknemer ID";
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.Location = new System.Drawing.Point(77, 56);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(283, 108);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Login";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(59, 181);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(308, 168);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // LoginScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 588);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_login);
            this.Controls.Add(this.lbl_werknemer_id);
            this.Controls.Add(this.lbl_wachtwoord);
            this.Controls.Add(this.tb_wacthwoord);
            this.Controls.Add(this.b_login_enter);
            this.Controls.Add(this.tb_werknemer_id);
            this.Name = "LoginScherm";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_wacthwoord;
        private System.Windows.Forms.TextBox tb_werknemer_id;
        private System.Windows.Forms.Button b_login_enter;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.Label lbl_werknemer_id;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

