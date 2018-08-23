using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace MotorTest
{
    public partial class InputDlg : Form
    {
        private bool mIsUpdating = false;
        private Motor_test_data mMotorTestData = new Motor_test_data() { InputChooseMotorConfigForShaftExtension = "UT", InputChooseIsAirTestPassed = "NO", InputChooseDidMotorStartedWithLowVoltAt60Hz = "NO" };

        public InputDlg()
        {
            InitializeComponent();

            //Load Desc for Motors from Database, add all to InputChooseModel Control
            if (!mIsUpdating)
                ReloadComboboxContentFromDatabase();
            InputCustomerName.Focus();
            motortestdataBindingSource.DataSource = mMotorTestData;

        }

        private void ReloadComboboxContentFromDatabase()
        {
            if (mIsUpdating)
                return;
            mIsUpdating = true;
            using (var context = new mydbEntities())
            {
                var moterList = context.Motors.Where(m => m.Series == InputChooseSeries.Text);
                InputChooseModel.Items.Clear();
                InputChooseModel.Items.Add("");
                foreach (Motor motor in moterList)
                {
                    InputChooseModel.Items.Add(motor.Desc);
                    //System.Console.WriteLine(motor.ID);

                }

                var motorTestDataList = context.Motor_test_data.ToList();
                InputChooseLoadData.Items.Clear();
                InputChooseLoadData.Items.Add("");
                foreach (Motor_test_data motorTestData in motorTestDataList)
                {
                    InputChooseLoadData.Items.Add("ID: " + motorTestData.InputReportID + " --- " + motorTestData.InputMotorSN + " --- " + motorTestData.InputTestDate);//Report ID
                    
                }

                InputChooseModel.SelectedItem = mMotorTestData.InputChooseModel;
                InputChooseLoadData.SelectedItem = "ID: " + mMotorTestData.InputReportID + " --- " + mMotorTestData.InputMotorSN + " --- " + mMotorTestData.InputTestDate;//Report ID





            }

            mIsUpdating = false;
        }

        private void InputDlg_Load(object sender, EventArgs e)
        {
            ReCalculateOutputs();
        }

        private void InputChooseModel_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (InputChooseModel.SelectedIndex < 1 || mIsUpdating)
                return;
            
            using (var context = new mydbEntities())
            {
                mMotorTestData.Motor = context.Motors.FirstOrDefault(m => m.Desc == InputChooseModel.Text);
                if (null == mMotorTestData.Motor)
                    return;
                //mMotorTestData.ID_Motor = mMotorTestData.motor.ID;
                mMotorTestData.InputChooseModel = mMotorTestData.Motor.Desc;
                mMotorTestData.OutputInsulationResistanceCheckMinVoltRequired = (mMotorTestData.Motor.Volts < 1000M) ? 500M : ((mMotorTestData.Motor.Volts < 2500M) ? 1000M : ((mMotorTestData.Motor.Volts < 5000M) ? 2500M : 0M));
                mMotorTestData.OutputRecommendedLowVoltStartAt60Hz = 0.4M * mMotorTestData.Motor.Volts;
            }

            ForceRefreshBindingDataToControls();

        }

        private void InputChooseLoadData_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (InputChooseLoadData.SelectedIndex<1 || mIsUpdating)
                return;

            using (var context = new mydbEntities())
            {
                string selectedReportID = InputChooseLoadData.SelectedItem.ToString().Substring(4, InputChooseLoadData.SelectedItem.ToString().IndexOf(" --- ") - (" --- ").Length + 1);
                mMotorTestData = context.Motor_test_data.FirstOrDefault(t => t.InputReportID == selectedReportID);
                if (null == mMotorTestData)
                    return;
                motortestdataBindingSource.DataSource = mMotorTestData;
                if(!mIsUpdating)
                {
                    ReloadComboboxContentFromDatabase();
                    ForceRefreshBindingDataToControls();
                }
                    
                //InputChooseModel.SelectedIndex = mMotorTestData.ID_Motor;
            }
        }

        private void InputDlg_Click(object sender, EventArgs e)
        {
            //System.Console.WriteLine($" OutputRecommendedLowVoltStartAt60Hz? =  {mMotorTestData.OutputRecommendedLowVoltStartAt60Hz-2??999}");
            if (InputMonthCalendar.Visible)
                InputMonthCalendar.Hide();
            ForceRefreshBindingDataToControls();
            //System.Console.WriteLine(InputChooseLoadData.SelectedItem.ToString());
            //System.Console.WriteLine(InputChooseLoadData.SelectedItem.ToString().Substring(4, InputChooseLoadData.SelectedItem.ToString().IndexOf(" --- ") - (" --- ").Length + 1));
            
        }

        void SetCalenderDateAsTestDate()
        {
            //Set date selected in calender to InputTestDate Control, set focus back to text box, hide calender 
            InputTestDate.Text = InputMonthCalendar.SelectionEnd.Date.ToString("dddd, MMM dd, yyyy");
            InputTestDate.Focus();
            InputTestDate.Select(0, 0);
            if (InputMonthCalendar.Visible)
                InputMonthCalendar.Hide();

        }

        private void InputTestDate_Enter(object sender, EventArgs e)
        {
            //System.Console.WriteLine("enter date box");
            InputMonthCalendar.Show();
            
        }

        private void InputMonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SetCalenderDateAsTestDate();
        }

        private void InputMonthCalendar_Leave(object sender, EventArgs e)
        {
            //System.Console.WriteLine("leave calender");
            if (InputMonthCalendar.Visible)
                InputMonthCalendar.Hide();
        }

        private void InputTestDate_Leave(object sender, EventArgs e)
        {
            if (InputMonthCalendar.Visible)
                InputMonthCalendar.Hide();

        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            this.mMotorTestData = new Motor_test_data() { InputChooseMotorConfigForShaftExtension = "UT", InputChooseIsAirTestPassed = "NO", InputChooseDidMotorStartedWithLowVoltAt60Hz = "NO" };
            this.motortestdataBindingSource.DataSource = this.mMotorTestData;
            InputChooseSupplier.SelectedIndex = -1;
            InputChooseSeries.SelectedIndex = -1;
            InputChooseLoadData.SelectedIndex = -1;
   
        }

        

        private void ButtonReport_Click(object sender, EventArgs e)
        {
            if (!ReCalculateOutputs())
                System.Console.WriteLine($"Warning: something wrong was passed to report page");
            this.Hide();
            Form reportForm = new ReportDlg(mMotorTestData);


            var res = reportForm.ShowDialog();
            this.Show();
        }


        private void ButtonSave_Click(object sender, EventArgs e)
        {
           
            if (!ReCalculateOutputs("Save"))
                return;
            if(!mIsUpdating)
                ReloadComboboxContentFromDatabase();

        }

        

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            if (mMotorTestData.ID < 1)
                return;
            if (!ReCalculateOutputs("Update"))
                return;
            if (!mIsUpdating)
                ReloadComboboxContentFromDatabase();
        }

        private bool ReCalculateOutputs(string operation = "")
        {
            using (var context = new mydbEntities())
            {
                mMotorTestData.Motor = context.Motors.FirstOrDefault(m => m.Desc == InputChooseModel.Text);
                mMotorTestData.Motor_shaft_extension = context.Motor_shaft_extension.FirstOrDefault(mse => mse.Desc.Contains(mMotorTestData.InputChooseSeries) && mse.Desc.Contains(mMotorTestData.InputChooseMotorConfigForShaftExtension));
                //if (null == mMotorTestData.motor || null == mMotorTestData.Motor_shaft_extension)
                //    return false;
                if(null != mMotorTestData.Motor)
                mMotorTestData.ID_Motor = mMotorTestData.Motor.ID;
                if (null != mMotorTestData.Motor_shaft_extension)
                    mMotorTestData.ID_Motor_Shaft_Extension = mMotorTestData.Motor_shaft_extension.ID;
                mMotorTestData.ReCalculateOutputs();
                
                if("" != operation)
                {
                    if (null == mMotorTestData.InputReportID || "" == mMotorTestData.InputReportID)
                    {
                        MessageBox.Show("Please enter a Report ID to continue", operation + " Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (mMotorTestData.ID_Motor < 1 || mMotorTestData.ID_Motor_Shaft_Extension < 1)
                    {
                        MessageBox.Show("Please choose a Motor Model to continue", operation + " Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return false;
                    }

                    if (null != context.Motor_test_data.FirstOrDefault(mt=>mt.InputReportID == mMotorTestData.InputReportID))
                    {
                        MessageBox.Show("Entered Report ID already exists, please try another one", operation + " Failed",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        return false;
                    }
                }

                if("Save" == operation)
                {
                    
                    context.Motor_test_data.Add(mMotorTestData);
                    if (context.SaveChanges() > 0)
                        System.Console.WriteLine($"Save new record to table Motor_test_data, ID: { mMotorTestData.ID }");
                    else
                    {
                        System.Console.WriteLine($"Failed on saving new record ID: { mMotorTestData.ID }");
                        return false;
                    }
                        
                }
                else if("Update" == operation)
                {
                    var preTestData = context.Motor_test_data.FirstOrDefault(mtd => mtd.ID == mMotorTestData.ID);
                    if (null == preTestData)
                    {
                        System.Console.WriteLine($"Unable to locate ID: { mMotorTestData.ID } in test record");
                        return false;
                    }
                        
                    context.Entry(preTestData).CurrentValues.SetValues(mMotorTestData);
                    if (context.SaveChanges() > 0)
                        System.Console.WriteLine($"Update record in table Motor_test_data, ID = { mMotorTestData.ID }");
                    else
                    {
                        System.Console.WriteLine($"Failed on updating record ID: { mMotorTestData.ID }");
                        return false;
                    }
                }
            }
            return true;
        }

        private void ForceRefreshBindingDataToControls()
        {
            foreach (Control c in this.Controls)
            {
                //System.Console.WriteLine(c.Name);
                foreach (Binding b in c.DataBindings)
                {
                    //System.Console.WriteLine(b.FormatInfo);
                    b.ReadValue();
                }
            }

        }

        private void InputChooseSeries_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (!mIsUpdating)
            {
                mMotorTestData.InputChooseSeries = InputChooseSeries.Text;
                ReloadComboboxContentFromDatabase();
                ForceRefreshBindingDataToControls();
            }

            
        }
    }
}
