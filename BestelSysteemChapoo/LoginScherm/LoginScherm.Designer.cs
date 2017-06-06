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
            this.lbl_werknemer_id = new System.Windows.Forms.Label();
            this.lbl_wachtwoord = new System.Windows.Forms.Label();
            this.tb_werknemer_id = new System.Windows.Forms.TextBox();
            this.tb_wacthwoord = new System.Windows.Forms.TextBox();
            this.b_login_enter = new System.Windows.Forms.Button();
            this.lbl_login = new System.Windows.Forms.Label();
            this.tab_logintab = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tab_logintab.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_werknemer_id
            // 
            this.lbl_werknemer_id.AutoSize = true;
            this.lbl_werknemer_id.Location = new System.Drawing.Point(73, 421);
            this.lbl_werknemer_id.Name = "lbl_werknemer_id";
            this.lbl_werknemer_id.Size = new System.Drawing.Size(76, 13);
            this.lbl_werknemer_id.TabIndex = 0;
            this.lbl_werknemer_id.Text = "Werknemer ID";
            // 
            // lbl_wachtwoord
            // 
            this.lbl_wachtwoord.AutoSize = true;
            this.lbl_wachtwoord.Location = new System.Drawing.Point(81, 468);
            this.lbl_wachtwoord.Name = "lbl_wachtwoord";
            this.lbl_wachtwoord.Size = new System.Drawing.Size(68, 13);
            this.lbl_wachtwoord.TabIndex = 1;
            this.lbl_wachtwoord.Text = "Wachtwoord";
            // 
            // tb_werknemer_id
            // 
            this.tb_werknemer_id.Location = new System.Drawing.Point(201, 421);
            this.tb_werknemer_id.Name = "tb_werknemer_id";
            this.tb_werknemer_id.Size = new System.Drawing.Size(132, 20);
            this.tb_werknemer_id.TabIndex = 2;
            // 
            // tb_wacthwoord
            // 
            this.tb_wacthwoord.Location = new System.Drawing.Point(201, 465);
            this.tb_wacthwoord.Name = "tb_wacthwoord";
            this.tb_wacthwoord.Size = new System.Drawing.Size(132, 20);
            this.tb_wacthwoord.TabIndex = 3;
            // 
            // b_login_enter
            // 
            this.b_login_enter.Location = new System.Drawing.Point(201, 510);
            this.b_login_enter.Name = "b_login_enter";
            this.b_login_enter.Size = new System.Drawing.Size(132, 23);
            this.b_login_enter.TabIndex = 4;
            this.b_login_enter.Text = "Enter";
            this.b_login_enter.UseVisualStyleBackColor = true;
            // 
            // lbl_login
            // 
            this.lbl_login.AutoSize = true;
            this.lbl_login.Font = new System.Drawing.Font("MS Reference Sans Serif", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_login.Location = new System.Drawing.Point(66, 24);
            this.lbl_login.Name = "lbl_login";
            this.lbl_login.Size = new System.Drawing.Size(279, 107);
            this.lbl_login.TabIndex = 5;
            this.lbl_login.Text = "Login";
            // 
            // tab_logintab
            // 
            this.tab_logintab.Controls.Add(this.tabPage1);
            this.tab_logintab.Controls.Add(this.tabPage2);
            this.tab_logintab.Location = new System.Drawing.Point(2, 1);
            this.tab_logintab.Name = "tab_logintab";
            this.tab_logintab.SelectedIndex = 0;
            this.tab_logintab.Size = new System.Drawing.Size(426, 588);
            this.tab_logintab.TabIndex = 6;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lbl_login);
            this.tabPage1.Controls.Add(this.lbl_werknemer_id);
            this.tabPage1.Controls.Add(this.lbl_wachtwoord);
            this.tabPage1.Controls.Add(this.b_login_enter);
            this.tabPage1.Controls.Add(this.tb_werknemer_id);
            this.tabPage1.Controls.Add(this.tb_wacthwoord);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(418, 562);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(418, 562);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 65.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(34, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 107);
            this.label1.TabIndex = 6;
            this.label1.Text = "Beheer";
            // 
            // LoginScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 588);
            this.Controls.Add(this.tab_logintab);
            this.Name = "LoginScherm";
            this.Text = "Form1";
            this.tab_logintab.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_werknemer_id;
        private System.Windows.Forms.Label lbl_wachtwoord;
        private System.Windows.Forms.TextBox tb_werknemer_id;
        private System.Windows.Forms.TextBox tb_wacthwoord;
        private System.Windows.Forms.Button b_login_enter;
        private System.Windows.Forms.Label lbl_login;
        private System.Windows.Forms.TabControl tab_logintab;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
    }
}

