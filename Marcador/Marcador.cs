using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Marcador
{
    public partial class Marcador : Form
    {
        public List<Stopwatch> expulsionTimers = new List<Stopwatch>();
        
        public Marcador()
        {
            InitializeComponent();
            //this.ExpulsionDataView.RowsDefaultCellStyle.SelectionBackColor = Color.LimeGreen;
            this.ExpulsionDataView.DefaultCellStyle.SelectionBackColor = this.ExpulsionDataView.DefaultCellStyle.BackColor;
            this.ExpulsionDataView.DefaultCellStyle.SelectionForeColor = this.ExpulsionDataView.DefaultCellStyle.ForeColor;

            
        }

        private void ExpulsionDataView_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            if (this.ExpulsionDataView.Rows.Count == 0)
            {
                this.ExpulsionDataView.Visible = false;
            }
            else
            {
                ExpulsionDataView.Visible = true;
            }

            var elem = expulsionTimers.ElementAt(e.RowIndex);
            elem.Stop();
            expulsionTimers.Remove(elem);
        }

        private void ExpulsionDataView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

            if (this.ExpulsionDataView.Rows.Count == 0)
            {
                this.ExpulsionDataView.Visible = false;
            }
            else
            {
                ExpulsionDataView.Visible = true;
            }

            DataGridViewRow row = this.ExpulsionDataView.Rows[e.RowIndex];
            Stopwatch sw = new Stopwatch();
            sw.Start();
            expulsionTimers.Add(sw);

        }

        private void ExpulsionDataView_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (e.Row.Cells[3].Value == "LOCAL")
                e.Row.DefaultCellStyle.BackColor = Color.White;
            else
                e.Row.DefaultCellStyle.BackColor = Color.SteelBlue;
        }

    }
}
