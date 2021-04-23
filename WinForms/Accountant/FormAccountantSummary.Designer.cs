
namespace CovidAirlines
{
	partial class FormAccountantSummary
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
			this.labelTotalFlights = new System.Windows.Forms.Label();
			this.labelFlights = new System.Windows.Forms.Label();
			this.labelTotalIncome = new System.Windows.Forms.Label();
			this.labelTotalCapacity = new System.Windows.Forms.Label();
			this.labelCapacity = new System.Windows.Forms.Label();
			this.labelIncome = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// labelTotalFlights
			// 
			this.labelTotalFlights.AutoSize = true;
			this.labelTotalFlights.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalFlights.Location = new System.Drawing.Point(66, 36);
			this.labelTotalFlights.Name = "labelTotalFlights";
			this.labelTotalFlights.Size = new System.Drawing.Size(81, 13);
			this.labelTotalFlights.TabIndex = 0;
			this.labelTotalFlights.Text = "Total Flights:";
			// 
			// labelFlights
			// 
			this.labelFlights.AutoSize = true;
			this.labelFlights.Location = new System.Drawing.Point(150, 36);
			this.labelFlights.Name = "labelFlights";
			this.labelFlights.Size = new System.Drawing.Size(65, 13);
			this.labelFlights.TabIndex = 1;
			this.labelFlights.Text = "*total flights*";
			// 
			// labelTotalIncome
			// 
			this.labelTotalIncome.AutoSize = true;
			this.labelTotalIncome.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalIncome.Location = new System.Drawing.Point(61, 140);
			this.labelTotalIncome.Name = "labelTotalIncome";
			this.labelTotalIncome.Size = new System.Drawing.Size(85, 13);
			this.labelTotalIncome.TabIndex = 0;
			this.labelTotalIncome.Text = "Total Income:";
			// 
			// labelTotalCapacity
			// 
			this.labelTotalCapacity.AutoSize = true;
			this.labelTotalCapacity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.labelTotalCapacity.Location = new System.Drawing.Point(55, 88);
			this.labelTotalCapacity.Name = "labelTotalCapacity";
			this.labelTotalCapacity.Size = new System.Drawing.Size(93, 13);
			this.labelTotalCapacity.TabIndex = 0;
			this.labelTotalCapacity.Text = "Total Capacity:";
			// 
			// labelCapacity
			// 
			this.labelCapacity.AutoSize = true;
			this.labelCapacity.Location = new System.Drawing.Point(150, 88);
			this.labelCapacity.Name = "labelCapacity";
			this.labelCapacity.Size = new System.Drawing.Size(78, 13);
			this.labelCapacity.TabIndex = 1;
			this.labelCapacity.Text = "*total capacity*";
			// 
			// labelIncome
			// 
			this.labelIncome.AutoSize = true;
			this.labelIncome.Location = new System.Drawing.Point(150, 140);
			this.labelIncome.Name = "labelIncome";
			this.labelIncome.Size = new System.Drawing.Size(72, 13);
			this.labelIncome.TabIndex = 1;
			this.labelIncome.Text = "*total income*";
			// 
			// FormAccountingSummary
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(317, 254);
			this.Controls.Add(this.labelIncome);
			this.Controls.Add(this.labelCapacity);
			this.Controls.Add(this.labelFlights);
			this.Controls.Add(this.labelTotalCapacity);
			this.Controls.Add(this.labelTotalIncome);
			this.Controls.Add(this.labelTotalFlights);
			this.Name = "FormAccountingSummary";
			this.Text = "Summary - ???";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelTotalFlights;
		private System.Windows.Forms.Label labelFlights;
		private System.Windows.Forms.Label labelTotalIncome;
		private System.Windows.Forms.Label labelTotalCapacity;
		private System.Windows.Forms.Label labelCapacity;
		private System.Windows.Forms.Label labelIncome;
	}
}