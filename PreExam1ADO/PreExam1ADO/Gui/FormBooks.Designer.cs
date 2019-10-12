namespace PreExam1ADO.Gui
{
	partial class FormBooks
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label3 = new System.Windows.Forms.Label();
			this.textBoxAuthor = new System.Windows.Forms.TextBox();
			this.textBoxTitle = new System.Windows.Forms.TextBox();
			this.textBoxIsbn = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.buttonSearch = new System.Windows.Forms.Button();
			this.buttonExit = new System.Windows.Forms.Button();
			this.buttonRefresh = new System.Windows.Forms.Button();
			this.buttonUpdate = new System.Windows.Forms.Button();
			this.buttonDelete = new System.Windows.Forms.Button();
			this.buttonAdd = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.textBoxSearchAuthor = new System.Windows.Forms.TextBox();
			this.textBoxSearchTitle = new System.Windows.Forms.TextBox();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new System.Drawing.Point(3, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1796, 236);
			this.panel1.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
			this.label3.Location = new System.Drawing.Point(563, 80);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(638, 73);
			this.label3.TabIndex = 6;
			this.label3.Text = "CENTRAL LIBRARY";
			// 
			// textBoxAuthor
			// 
			this.textBoxAuthor.Location = new System.Drawing.Point(938, 301);
			this.textBoxAuthor.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxAuthor.Name = "textBoxAuthor";
			this.textBoxAuthor.Size = new System.Drawing.Size(196, 31);
			this.textBoxAuthor.TabIndex = 14;
			// 
			// textBoxTitle
			// 
			this.textBoxTitle.Location = new System.Drawing.Point(536, 301);
			this.textBoxTitle.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxTitle.Name = "textBoxTitle";
			this.textBoxTitle.Size = new System.Drawing.Size(196, 31);
			this.textBoxTitle.TabIndex = 13;
			// 
			// textBoxIsbn
			// 
			this.textBoxIsbn.Enabled = false;
			this.textBoxIsbn.Location = new System.Drawing.Point(142, 301);
			this.textBoxIsbn.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxIsbn.Name = "textBoxIsbn";
			this.textBoxIsbn.Size = new System.Drawing.Size(196, 31);
			this.textBoxIsbn.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(812, 307);
			this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(75, 25);
			this.label4.TabIndex = 11;
			this.label4.Text = "Author";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(412, 307);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 25);
			this.label1.TabIndex = 10;
			this.label1.Text = "Title";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(46, 307);
			this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 25);
			this.label2.TabIndex = 9;
			this.label2.Text = "ISBN";
			// 
			// buttonSearch
			// 
			this.buttonSearch.Location = new System.Drawing.Point(171, 197);
			this.buttonSearch.Margin = new System.Windows.Forms.Padding(6);
			this.buttonSearch.Name = "buttonSearch";
			this.buttonSearch.Size = new System.Drawing.Size(151, 44);
			this.buttonSearch.TabIndex = 26;
			this.buttonSearch.Text = "Search";
			this.buttonSearch.UseVisualStyleBackColor = true;
			this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
			// 
			// buttonExit
			// 
			this.buttonExit.Location = new System.Drawing.Point(1614, 975);
			this.buttonExit.Margin = new System.Windows.Forms.Padding(6);
			this.buttonExit.Name = "buttonExit";
			this.buttonExit.Size = new System.Drawing.Size(150, 44);
			this.buttonExit.TabIndex = 25;
			this.buttonExit.Text = "Exit";
			this.buttonExit.UseVisualStyleBackColor = true;
			this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
			// 
			// buttonRefresh
			// 
			this.buttonRefresh.Location = new System.Drawing.Point(285, 414);
			this.buttonRefresh.Margin = new System.Windows.Forms.Padding(6);
			this.buttonRefresh.Name = "buttonRefresh";
			this.buttonRefresh.Size = new System.Drawing.Size(150, 44);
			this.buttonRefresh.TabIndex = 24;
			this.buttonRefresh.Text = "Refresh";
			this.buttonRefresh.UseVisualStyleBackColor = true;
			this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
			// 
			// buttonUpdate
			// 
			this.buttonUpdate.Location = new System.Drawing.Point(499, 414);
			this.buttonUpdate.Margin = new System.Windows.Forms.Padding(6);
			this.buttonUpdate.Name = "buttonUpdate";
			this.buttonUpdate.Size = new System.Drawing.Size(150, 44);
			this.buttonUpdate.TabIndex = 23;
			this.buttonUpdate.Text = "Update";
			this.buttonUpdate.UseVisualStyleBackColor = true;
			this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
			// 
			// buttonDelete
			// 
			this.buttonDelete.Location = new System.Drawing.Point(714, 414);
			this.buttonDelete.Margin = new System.Windows.Forms.Padding(6);
			this.buttonDelete.Name = "buttonDelete";
			this.buttonDelete.Size = new System.Drawing.Size(150, 44);
			this.buttonDelete.TabIndex = 22;
			this.buttonDelete.Text = "Delete";
			this.buttonDelete.UseVisualStyleBackColor = true;
			this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
			// 
			// buttonAdd
			// 
			this.buttonAdd.Location = new System.Drawing.Point(59, 414);
			this.buttonAdd.Margin = new System.Windows.Forms.Padding(6);
			this.buttonAdd.Name = "buttonAdd";
			this.buttonAdd.Size = new System.Drawing.Size(150, 44);
			this.buttonAdd.TabIndex = 21;
			this.buttonAdd.Text = "Add";
			this.buttonAdd.UseVisualStyleBackColor = true;
			this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(64, 128);
			this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(178, 25);
			this.label6.TabIndex = 30;
			this.label6.Text = "Search by Author";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(78, 50);
			this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(156, 25);
			this.label5.TabIndex = 29;
			this.label5.Text = "Search by Title";
			// 
			// textBoxSearchAuthor
			// 
			this.textBoxSearchAuthor.Location = new System.Drawing.Point(244, 125);
			this.textBoxSearchAuthor.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxSearchAuthor.Name = "textBoxSearchAuthor";
			this.textBoxSearchAuthor.Size = new System.Drawing.Size(197, 31);
			this.textBoxSearchAuthor.TabIndex = 28;
			// 
			// textBoxSearchTitle
			// 
			this.textBoxSearchTitle.Location = new System.Drawing.Point(244, 47);
			this.textBoxSearchTitle.Margin = new System.Windows.Forms.Padding(6);
			this.textBoxSearchTitle.Name = "textBoxSearchTitle";
			this.textBoxSearchTitle.Size = new System.Drawing.Size(197, 31);
			this.textBoxSearchTitle.TabIndex = 27;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(1170, 556);
			this.dataGridView2.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(535, 378);
			this.dataGridView2.TabIndex = 32;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(59, 508);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(1075, 511);
			this.dataGridView1.TabIndex = 31;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.textBoxSearchTitle);
			this.groupBox1.Controls.Add(this.textBoxSearchAuthor);
			this.groupBox1.Controls.Add(this.buttonSearch);
			this.groupBox1.Location = new System.Drawing.Point(1223, 266);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(497, 265);
			this.groupBox1.TabIndex = 33;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Search Box";
			// 
			// FormBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1793, 1046);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.buttonExit);
			this.Controls.Add(this.buttonRefresh);
			this.Controls.Add(this.buttonUpdate);
			this.Controls.Add(this.buttonDelete);
			this.Controls.Add(this.buttonAdd);
			this.Controls.Add(this.textBoxAuthor);
			this.Controls.Add(this.textBoxTitle);
			this.Controls.Add(this.textBoxIsbn);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.panel1);
			this.Name = "FormBooks";
			this.Text = "FormBooks";
			this.Load += new System.EventHandler(this.FormBooks_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBoxAuthor;
		private System.Windows.Forms.TextBox textBoxTitle;
		private System.Windows.Forms.TextBox textBoxIsbn;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button buttonSearch;
		private System.Windows.Forms.Button buttonExit;
		private System.Windows.Forms.Button buttonRefresh;
		private System.Windows.Forms.Button buttonUpdate;
		private System.Windows.Forms.Button buttonDelete;
		private System.Windows.Forms.Button buttonAdd;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBoxSearchAuthor;
		private System.Windows.Forms.TextBox textBoxSearchTitle;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.GroupBox groupBox1;
	}
}