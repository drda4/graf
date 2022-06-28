/*
 * Created by SharpDevelop.
 * User: Peetrs
 * Date: 25.06.2022
 * Time: 14:30
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Linq;
using System.Text;

namespace U_graph
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Random random = new Random();
		public MainForm()
		{
			InitializeComponent();
		}
		void MainFormLoad(object sender, EventArgs e)
		{
			
		}
		//---------------------------------------------------	
		void GnrButtonClick(object sender, EventArgs e)
		{
			chart1.Series[0].Points.Clear();
			double x = 0;
			decimal y = 0;
		
			for(int i=0;i<dataGridView1.Rows.Count-1;i++)
			{
				x = double.Parse(dataGridView1.Rows[i].Cells["day"].Value.ToString());
				y = decimal.Parse(dataGridView1.Rows[i].Cells["price"].Value.ToString());
				chart1.Series[0].Points.AddXY(x, y);
				chart1.Series[0].Color = Color.FromArgb(random.Next(256), random.Next(256), random.Next(256));
			}
			
		}
		void PrintButtonClick(object sender, EventArgs e)
		{
			chart1.Printing.PrintPreview();
		}
		
		void SaveButtonClick(object sender, EventArgs e)
		{
			this.chart1.SaveImage("chart.png", ChartImageFormat.Png);
			MessageBox.Show("Graf byl úspěšně uložen!");
		}
		//-------------------------------------------------------------------------	
		void DataGridView1CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
			e.FormattedValue.ToString();
			if(e.FormattedValue.ToString().Length>0)
			{
				try
				{
					double input = double.Parse(e.FormattedValue.ToString());
					
				}
				catch(Exception ex)
				{
					MessageBox.Show("Zapisujte pouze čísla!.\n" + ex.Message);
					e.Cancel = true;
				}
			}
		}
		
		void DataGridView1RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
		{
			this.dataGridView1.Rows[e.RowIndex].Cells["day"].Value = (e.RowIndex + 1).ToString();
		}
	}
}
