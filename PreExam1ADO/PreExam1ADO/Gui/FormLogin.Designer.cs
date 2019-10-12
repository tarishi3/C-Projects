namespace PreExam1ADO.Gui
{
	partial class FormLogin
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
			this.buttonLogin = new System.Windows.Forms.Button();
			this.textBoxUser = new System.Windows.Forms.TextBox();
			this.textBoxPass = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonLogin
			// 
			this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonLogin.Location = new System.Drawing.Point(231, 712);
			this.buttonLogin.Name = "buttonLogin";
			this.buttonLogin.Size = new System.Drawing.Size(811, 69);
			this.buttonLogin.TabIndex = 0;
			this.buttonLogin.Text = "Login";
			this.buttonLogin.UseVisualStyleBackColor = true;
			this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
			// 
			// textBoxUser
			// 
			this.textBoxUser.BackColor = System.Drawing.Color.LightSeaGreen;
			this.textBoxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxUser.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxUser.Location = new System.Drawing.Point(231, 407);
			this.textBoxUser.Name = "textBoxUser";
			this.textBoxUser.Size = new System.Drawing.Size(811, 49);
			this.textBoxUser.TabIndex = 1;
			this.textBoxUser.Text = "UserName";
			// 
			// textBoxPass
			// 
			this.textBoxPass.BackColor = System.Drawing.Color.LightSeaGreen;
			this.textBoxPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.textBoxPass.ForeColor = System.Drawing.SystemColors.InactiveCaption;
			this.textBoxPass.Location = new System.Drawing.Point(231, 563);
			this.textBoxPass.Name = "textBoxPass";
			this.textBoxPass.Size = new System.Drawing.Size(811, 49);
			this.textBoxPass.TabIndex = 2;
			this.textBoxPass.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(308, 81);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(638, 73);
			this.label3.TabIndex = 6;
			this.label3.Text = "CENTRAL LIBRARY";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(-1, -1);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1270, 236);
			this.panel1.TabIndex = 7;
			// 
			// FormLogin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1266, 943);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBoxPass);
			this.Controls.Add(this.textBoxUser);
			this.Controls.Add(this.buttonLogin);
			this.Name = "FormLogin";
			this.Text = "FormLogin";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button buttonLogin;
		private System.Windows.Forms.TextBox textBoxUser;
		private System.Windows.Forms.TextBox textBoxPass;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel1;
	}
}