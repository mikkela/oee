using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Mikadocs.OEE.CostCalculator
{
    public partial class BaseCostForm : Form
    {
        public BaseCostForm()
        {
            InitializeComponent();
        }

        public List<MachineConfiguration> Machines
        {
            get { return null; }
            set { dgvMachines.DataSource = value; }
        }
    }
}
