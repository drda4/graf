/*
 * Created by SharpDevelop.
 * User: Peetrs
 * Date: 25.06.2022
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace U_graph
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
			System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
			System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.GnrButton = new System.Windows.Forms.Button();
			this.PrintButton = new System.Windows.Forms.Button();
			this.SaveButton = new System.Windows.Forms.Button();
			this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
			this.day = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
									this.day,
									this.price});
			this.dataGridView1.Location = new System.Drawing.Point(12, 12);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(245, 493);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.DataGridView1CellValidating);
			this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.DataGridView1RowPostPaint);
			// 
			// GnrButton
			// 
			this.GnrButton.Location = new System.Drawing.Point(263, 450);
			this.GnrButton.Name = "GnrButton";
			this.GnrButton.Size = new System.Drawing.Size(120, 55);
			this.GnrButton.TabIndex = 1;
			this.GnrButton.Text = "Generuj";
			this.GnrButton.UseMnemonic = false;
			this.GnrButton.UseVisualStyleBackColor = true;
			this.GnrButton.Click += new System.EventHandler(this.GnrButtonClick);
			// 
			// PrintButton
			// 
			this.PrintButton.Location = new System.Drawing.Point(601, 450);
			this.PrintButton.Name = "PrintButton";
			this.PrintButton.Size = new System.Drawing.Size(120, 55);
			this.PrintButton.TabIndex = 3;
			this.PrintButton.Text = "Tisk grafu";
			this.PrintButton.UseMnemonic = false;
			this.PrintButton.UseVisualStyleBackColor = true;
			this.PrintButton.Click += new System.EventHandler(this.PrintButtonClick);
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(727, 450);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(120, 55);
			this.SaveButton.TabIndex = 4;
			this.SaveButton.Text = "Ulož graf";
			this.SaveButton.UseMnemonic = false;
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButtonClick);
			// 
			// chart1
			// 
			chartArea1.Name = "ChartArea1";
			this.chart1.ChartAreas.Add(chartArea1);
			legend1.Name = "Legend1";
			this.chart1.Legends.Add(legend1);
			this.chart1.Location = new System.Drawing.Point(263, 12);
			this.chart1.Name = "chart1";
			series1.ChartArea = "ChartArea1";
			series1.Legend = "Legend1";
			series1.Name = "Natural 95";
			this.chart1.Series.Add(series1);
			this.chart1.Size = new System.Drawing.Size(584, 414);
			this.chart1.TabIndex = 5;
			this.chart1.Text = "chart1";
			// 
			// day
			// 
			this.day.HeaderText = "Den";
			this.day.Name = "day";
			// 
			// price
			// 
			this.price.HeaderText = "Cena";
			this.price.Name = "price";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(864, 518);
			this.Controls.Add(this.chart1);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.PrintButton);
			this.Controls.Add(this.GnrButton);
			this.Controls.Add(this.dataGridView1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "MainForm";
			this.Text = "Graf";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridViewTextBoxColumn price;
		private System.Windows.Forms.DataGridViewTextBoxColumn day;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button PrintButton;
		private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
		private System.Windows.Forms.Button GnrButton;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}
