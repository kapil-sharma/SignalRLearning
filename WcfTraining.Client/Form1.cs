using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WcfTraining.Contracts;

namespace WcfTraining.Client
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSearchForZipCode_Click(object sender, EventArgs e)
        {
            RegionalClient proxy = new RegionalClient();
            ZipCodeData data = proxy.GetZipInfo(txtZipCode.Text.Trim());
            Trace.WriteLine("ZipCode: " + data.Zip);
            Trace.WriteLine("State: " + data.State);
            Trace.WriteLine("City: " + data.City);
        }
    }
}
