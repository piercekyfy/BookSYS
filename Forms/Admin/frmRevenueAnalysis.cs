using BookSYS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace BookSYS.Forms.Admin
{
    public partial class frmRevenueAnalysis : DBForm
    {
        public frmRevenueAnalysis()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            List<Order> orders = db.GetPaidOrders().ToList();

            if (orders.Count <= 0)
            {
                MessageBox.Show("No Orders exist in file.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Dictionary<int, List<Order>> yearOrders = new Dictionary<int, List<Order>>();

            foreach (Order order in orders)
            {
                int year = order.OrderDate.Year;

                if(yearOrders.TryGetValue(year, out List<Order> orderList))
                {
                    orderList.Add(order);
                } else
                {
                    yearOrders.Add(year, new List<Order>() { order });
                }
            }

            foreach (int year in yearOrders.Keys)
            {
                var series = chtMain.Series.Add(year.ToString());

                List<Order> specificOrders = yearOrders[year];
                double total = 0;

                foreach (Order order in specificOrders)
                {
                    total += order.Total;
                }

                series.Points.Add(new DataPoint(year, total));

                series.Label = total + "€";
            }


            chtMain.ChartAreas[0].AxisX.MajorGrid.LineWidth = 0;
            chtMain.ChartAreas[0].AxisY.MajorGrid.LineWidth = 0;
            chtMain.ChartAreas["ChartArea1"].AxisY.LabelStyle.Format = "C";
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
