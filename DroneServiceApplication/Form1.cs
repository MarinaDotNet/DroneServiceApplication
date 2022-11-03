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

            lstView.View = View.Details;
        }

        //if service wasn't specified it auvtomatically add it to RegularService queue
        private void AddNewItem(object sender, EventArgs e)
        {
            try
            {
                Drone drone = new Drone();
                drone.SetName(txtName.Text);
                drone.SetModel(txtModel.Text);
                drone.SetCost(double.Parse(txtCost.Text));
                drone.SetProblem(txtProblem.Text);

                drone.SetServiceTag((int)numUpDown.Value);

                if (GetServicePriority() == 1)
                {
                    drone.SetCost((drone.GetCost() * 0.15) + drone.GetCost());
                    ExpressService.Enqueue(drone);
                }
                else
                {
                    RegularService.Enqueue(drone);
                }

                lstView.Items.Clear();
                displayReqularService();
                displayExpressService();
            }
            catch(FormatException error)
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
            foreach(Drone drone in RegularService)
            {
                string[] data = {"Regular", drone.GetName(), drone.GetModel(),"$" + ((decimal)drone.GetCost()),
                drone.GetServiceTag().ToString(), drone.GetProblem()};

                lstView.Items.Add(new ListViewItem(data));
            }

        }

        private void displayExpressService()
        {
            foreach(Drone drone in ExpressService)
            {
                string[] data = {"Express" ,drone.GetName(), drone.GetModel(),"$" + ((decimal)drone.GetCost()),
                drone.GetServiceTag().ToString(), drone.GetProblem()};

                lstView.Items.Add(new ListViewItem(data));
            }
        }

        //allows to enter only numbers, char.isControls, and symbol: '.', if entered another symbol it replace it with symbol '.'
        private void txtCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar) ||
                char.IsPunctuation(e.KeyChar))
            {
                if(char.IsPunctuation(e.KeyChar) && !e.KeyChar.Equals('.'))
                {
                    e.KeyChar = '.';
                }
                e.Handled = false;
            }
            else e.Handled = true;
        }

    }
}
