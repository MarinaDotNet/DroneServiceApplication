using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

/**
 * author: msichova
 * student id: P272494
 * DroneServiceApplication
 * Date: 08.11.2022
 */
namespace DroneServiceApplication
{
    public partial class Form1 : Form
    {
        private List<Drone> FinishedList = new List<Drone>();
        private Queue<Drone> RegularService = new Queue<Drone>();
        private Queue<Drone> ExpressService = new Queue<Drone>();
        private List<string> Errors = new List<string>();

        public Form1()
        {
            InitializeComponent();

            lstViewRegular.View = View.Details;
            lstViewExpress.View = View.Details;
        }

        //if service wasn't specified it automatically add it to RegularService queue
        //button method add
        private void AddNewItem(object sender, EventArgs e)
        {
            try
            {
                Drone drone = new Drone(txtName.Text, txtModel.Text, txtProblem.Text);

                if (GetServicePriority() == 1)
                {
                    drone.SetServiceTag(incrementServiceTag());
                    drone.SetCost(double.Parse(txtCost.Text) + drone.GetServiceTag());
                    ExpressService.Enqueue(drone);
                    lstViewExpress.Items.Clear();
                    displayExpressService();
                }
                else
                {
                    drone.SetServiceTag((double)numUpDown.Value);
                    drone.SetCost(double.Parse(txtCost.Text) + drone.GetServiceTag());
                    RegularService.Enqueue(drone);
                    lstViewRegular.Items.Clear();
                    displayReqularService();
                }
                resetFormComponents();
            }
            catch (FormatException error)
            {
                ErrorTrapping(error);
            }
        }

        //if service not specified, in group grp1 nothing checked it returns -1
        private int GetServicePriority()
        {
            foreach (var rdButton in grp1.Controls.OfType<RadioButton>())
            {
                if (rdButton.Checked) return rdButton.TabIndex;
            }
            return -1;
        }

        private void ErrorTrapping(Exception error)
        {
            MessageBox.Show("Error: " + error.Message);

            Errors.Add(DateTime.Now.ToString() + " Object: " + error.Source + " ,Error type: " + error.GetType() +
                " " + error.Message + " " + error.TargetSite);

            stsStrip.Items.Clear();
            toolStripSplitbtn.DropDownItems.Clear();
            stsStrip.Items.Add(toolStripSplitbtn);

            Errors.ForEach((action) => toolStripSplitbtn.DropDownItems.Add(action));

            stsStrip.Items.Add(error.HResult.GetType() + " " + error.Message);
        }

        private void displayReqularService()
        {
            foreach (Drone drone in RegularService)
            {
                string[] data = {drone.GetName(), drone.GetModel(),"$" + ((decimal)drone.GetCost()),
                drone.GetServiceTag().ToString(), drone.GetProblem()};

                lstViewRegular.Items.Add(new ListViewItem(data));
            }

        }

        private void displayExpressService()
        {
            foreach (Drone drone in ExpressService)
            {
                string[] data = {drone.GetName(), drone.GetModel(),"$" + ((decimal)drone.GetCost()),
                drone.GetServiceTag().ToString(), drone.GetProblem()};

                lstViewExpress.Items.Add(new ListViewItem(data));
            }
        }

        /*
         * allows to enter only numbers, char.isControls, and symbol: '.',
         * if entered another symbol it replace it with symbol '.'
         * if there already one symbol '.' then its not allowds to enter more symbols
         * and accepts value with only one decimal point
         */
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (char.IsControl(e.KeyChar))
                {
                    e.Handled = false;
                }
                else if (checkForDecimals())
                {
                    if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar))
                    {
                        e.Handled = false;
                    }
                    else if (char.IsPunctuation(e.KeyChar))
                    {
                        if (txtCost.Text.Contains('.'))
                        {
                            e.Handled = true;
                        }
                        else if (!e.KeyChar.Equals('.'))
                        {
                            e.KeyChar = '.';
                        }
                    }
                    else e.Handled = true;
                }
                else e.Handled = true;
            }
            catch (Exception error)
            {
                ErrorTrapping(error);
            }
        }

        //accept value with one decimal point
        private bool checkForDecimals()
        {
            if (txtCost.Text.Contains('.'))
            {
                int count = txtCost.Text.Length - txtCost.Text.IndexOf('.');
                if (count > 1)
                {
                    return false;
                }
                else return true;
            }
            return true;
        }

        private double incrementServiceTag()
        {
            return ((((double)numUpDown.Value) * 0.15) + (double)numUpDown.Value);
        }

        private void resetFormComponents()
        {
            numUpDown.Value = 100;
            rdoRegular.Checked = false;
            rdoExpress.Checked = false;
            txtName.Clear();
            txtModel.Clear();
            txtCost.Clear();
            txtProblem.Clear();
        }

        private void lstViewRegular_MouseClick(object sender, MouseEventArgs e)
        {
            resetFormComponents();
            int index = lstViewRegular.FocusedItem.Index;
            txtName.Text = lstViewRegular.Items[index].SubItems[0].Text;
            txtProblem.Text = lstViewRegular.Items[index].SubItems[4].Text;
        }

        private void lstViewExpress_MouseClick(object sender, MouseEventArgs e)
        {
            resetFormComponents();
            int index = lstViewExpress.FocusedItem.Index;
            txtName.Text = lstViewExpress.Items[index].SubItems[0].Text;
            txtProblem.Text = lstViewExpress.Items[index].SubItems[4].Text;
        }

        private void btnDelRegular_Click(object sender, EventArgs e)
        {
            try
            {
                lstViewRegular.Items.RemoveAt(0);
                FinishedList.Add(RegularService.Dequeue());
                lstBox.Items.Add(getLastEllementOfFinishedList());
            }
            catch (ArgumentOutOfRangeException error)
            {
                ErrorTrapping(error);
            }
        }

        private void btnDelExpress_Click(object sender, EventArgs e)
        {
            try
            {
                lstViewExpress.Items.RemoveAt(0);
                FinishedList.Add(ExpressService.Dequeue());
                lstBox.Items.Add(getLastEllementOfFinishedList());
            }

            catch (ArgumentOutOfRangeException error)
            {
                ErrorTrapping(error);
            }
        }

        private string getLastEllementOfFinishedList()
        {
            try
            {
                int lastIndex = FinishedList.Count - 1;
                return (FinishedList.ElementAt(lastIndex).display());
            }
            catch (IndexOutOfRangeException error)
            {
                ErrorTrapping(error);
                return null;
            }
        }

        private void lstBox_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {
                int index = lstBox.SelectedIndex;
                lstBox.Items.RemoveAt(index);
                FinishedList.RemoveAt(index);
            }
            catch (ArgumentOutOfRangeException error)
            {
                ErrorTrapping(error);
            }
        }
    }
}
