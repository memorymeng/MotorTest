using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MotorTest
{
    public partial class ReportDlg : Form
    {
        //public Motor_test_data mMotorTestData = new Motor_test_data();
        public ReportDlg(Motor_test_data mMotorTestData)
        {
            InitializeComponent();
            motortestdataBindingSource.DataSource = mMotorTestData;
            this.reportViewer1.LocalReport.DisplayName = $"{mMotorTestData.InputMotorSN} - ESP MOTOR TEST REPORT"; 
            //this.reportViewer1.RefreshReport();
        }

        private void ReportDlg_Load(object sender, EventArgs e)
        {
            
            this.reportViewer1.RefreshReport();
        }
    }
}
