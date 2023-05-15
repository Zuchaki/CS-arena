
namespace Aplikacja_okienkowa
{
	public partial class Arena
	{
		
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Arena));
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.PlayerHp = new System.Windows.Forms.Label();
			this.EnemyHp = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.fontDialog1 = new System.Windows.Forms.FontDialog();
			this.PlayerW1 = new System.Windows.Forms.Label();
			this.PlayerW2 = new System.Windows.Forms.Label();
			this.EnemyW1 = new System.Windows.Forms.Label();
			this.EnemyW2 = new System.Windows.Forms.Label();
			this.Wynik = new System.Windows.Forms.Label();
			this.wyborbox = new System.Windows.Forms.Label();
			this.button5 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Azure;
			this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
			this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button1.Location = new System.Drawing.Point(12, 427);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(280, 457);
			this.button1.TabIndex = 0;
			this.button1.Text = "s";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Azure;
			this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
			this.button2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button2.Location = new System.Drawing.Point(298, 427);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(280, 457);
			this.button2.TabIndex = 1;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Azure;
			this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
			this.button3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button3.Location = new System.Drawing.Point(584, 427);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(280, 457);
			this.button3.TabIndex = 2;
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Azure;
			this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
			this.button4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.button4.Location = new System.Drawing.Point(870, 427);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(280, 457);
			this.button4.TabIndex = 3;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// PlayerHp
			// 
			this.PlayerHp.BackColor = System.Drawing.Color.DarkRed;
			this.PlayerHp.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PlayerHp.ForeColor = System.Drawing.Color.White;
			this.PlayerHp.Image = ((System.Drawing.Image)(resources.GetObject("PlayerHp.Image")));
			this.PlayerHp.Location = new System.Drawing.Point(12, 275);
			this.PlayerHp.Name = "PlayerHp";
			this.PlayerHp.Size = new System.Drawing.Size(1137, 30);
			this.PlayerHp.TabIndex = 5;
			this.PlayerHp.Text = "PlayerHp";
			this.PlayerHp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// EnemyHp
			// 
			this.EnemyHp.BackColor = System.Drawing.Color.DarkRed;
			this.EnemyHp.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EnemyHp.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.EnemyHp.Image = ((System.Drawing.Image)(resources.GetObject("EnemyHp.Image")));
			this.EnemyHp.Location = new System.Drawing.Point(12, 9);
			this.EnemyHp.Name = "EnemyHp";
			this.EnemyHp.Size = new System.Drawing.Size(1137, 30);
			this.EnemyHp.TabIndex = 6;
			this.EnemyHp.Text = "EnemyHp";
			this.EnemyHp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.Color.Black;
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
			this.label1.Location = new System.Drawing.Point(1156, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(382, 939);
			this.label1.TabIndex = 7;
			// 
			// PlayerW1
			// 
			this.PlayerW1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.PlayerW1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PlayerW1.ForeColor = System.Drawing.SystemColors.Control;
			this.PlayerW1.Image = ((System.Drawing.Image)(resources.GetObject("PlayerW1.Image")));
			this.PlayerW1.Location = new System.Drawing.Point(12, 316);
			this.PlayerW1.Name = "PlayerW1";
			this.PlayerW1.Size = new System.Drawing.Size(1137, 30);
			this.PlayerW1.TabIndex = 8;
			this.PlayerW1.Text = "PlayerW1";
			this.PlayerW1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// PlayerW2
			// 
			this.PlayerW2.BackColor = System.Drawing.Color.Green;
			this.PlayerW2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.PlayerW2.ForeColor = System.Drawing.Color.White;
			this.PlayerW2.Image = ((System.Drawing.Image)(resources.GetObject("PlayerW2.Image")));
			this.PlayerW2.Location = new System.Drawing.Point(12, 357);
			this.PlayerW2.Name = "PlayerW2";
			this.PlayerW2.Size = new System.Drawing.Size(1137, 30);
			this.PlayerW2.TabIndex = 9;
			this.PlayerW2.Text = "PlayerW2";
			this.PlayerW2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// EnemyW1
			// 
			this.EnemyW1.BackColor = System.Drawing.SystemColors.HotTrack;
			this.EnemyW1.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EnemyW1.ForeColor = System.Drawing.Color.White;
			this.EnemyW1.Image = ((System.Drawing.Image)(resources.GetObject("EnemyW1.Image")));
			this.EnemyW1.Location = new System.Drawing.Point(12, 51);
			this.EnemyW1.Name = "EnemyW1";
			this.EnemyW1.Size = new System.Drawing.Size(1137, 30);
			this.EnemyW1.TabIndex = 10;
			this.EnemyW1.Text = "EnemyW1";
			this.EnemyW1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// EnemyW2
			// 
			this.EnemyW2.BackColor = System.Drawing.Color.Green;
			this.EnemyW2.Font = new System.Drawing.Font("Segoe UI", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.EnemyW2.ForeColor = System.Drawing.Color.White;
			this.EnemyW2.Image = ((System.Drawing.Image)(resources.GetObject("EnemyW2.Image")));
			this.EnemyW2.Location = new System.Drawing.Point(12, 92);
			this.EnemyW2.Name = "EnemyW2";
			this.EnemyW2.Size = new System.Drawing.Size(1137, 30);
			this.EnemyW2.TabIndex = 11;
			this.EnemyW2.Text = "EnemyW2";
			this.EnemyW2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// Wynik
			// 
			this.Wynik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.Wynik.Font = new System.Drawing.Font("Segoe UI", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.Wynik.Location = new System.Drawing.Point(12, 9);
			this.Wynik.Name = "Wynik";
			this.Wynik.Size = new System.Drawing.Size(1138, 894);
			this.Wynik.TabIndex = 12;
			this.Wynik.Text = "Wynik";
			this.Wynik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// wyborbox
			// 
			this.wyborbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.wyborbox.Location = new System.Drawing.Point(12, -108);
			this.wyborbox.Name = "wyborbox";
			this.wyborbox.Size = new System.Drawing.Size(1537, 1071);
			this.wyborbox.TabIndex = 13;
			this.wyborbox.Text = "wyborbox";
			// 
			// button5
			// 
			this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
			this.button5.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button5.Location = new System.Drawing.Point(32, 206);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(432, 506);
			this.button5.TabIndex = 14;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button6
			// 
			this.button6.BackColor = System.Drawing.Color.IndianRed;
			this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
			this.button6.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button6.Location = new System.Drawing.Point(496, 206);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(432, 506);
			this.button6.TabIndex = 15;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button7
			// 
			this.button7.BackColor = System.Drawing.Color.DarkOliveGreen;
			this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
			this.button7.Font = new System.Drawing.Font("Segoe UI", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.button7.Location = new System.Drawing.Point(972, 206);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(432, 506);
			this.button7.TabIndex = 16;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
			this.label2.Font = new System.Drawing.Font("Segoe UI", 90F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.label2.Location = new System.Drawing.Point(215, 27);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(1005, 159);
			this.label2.TabIndex = 17;
			this.label2.Text = "WYBIERZ POSTAĆ";
			// 
			// Arena
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1548, 957);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button7);
			this.Controls.Add(this.button6);
			this.Controls.Add(this.button5);
			this.Controls.Add(this.wyborbox);
			this.Controls.Add(this.Wynik);
			this.Controls.Add(this.EnemyW2);
			this.Controls.Add(this.EnemyW1);
			this.Controls.Add(this.PlayerW2);
			this.Controls.Add(this.PlayerW1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.EnemyHp);
			this.Controls.Add(this.PlayerHp);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Name = "Arena";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Arena";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button4;
		public System.Windows.Forms.Label PlayerHp;
		public System.Windows.Forms.Label EnemyHp;
		public System.Windows.Forms.Label label1;
		private System.Windows.Forms.FontDialog fontDialog1;
		public System.Windows.Forms.Label PlayerW1;
		public System.Windows.Forms.Label PlayerW2;
		public System.Windows.Forms.Label EnemyW1;
		public System.Windows.Forms.Label EnemyW2;
		private System.Windows.Forms.Label Wynik;
		private System.Windows.Forms.Label wyborbox;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Label label2;
	}
}

