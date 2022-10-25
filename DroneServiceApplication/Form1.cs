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

namespace DroneServiceApplication
{/**To Do:
  * txtCost excepts to enter only numbers, decimals
  * create method for errors
  * method to check inputs, txtBoxes should not be empty
  */

    public partial class Form1 : Form
    {
        private List<Drone> FinishedList = new List<Drone>();
        private Queue<Drone> RegularService = new Queue<Drone>();
        private Queue<Drone> ExpressService = new Queue<Drone>();
        private List<string> Errors = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewItem(object sender, EventArgs e)
        {
            try
            {
                Drone drone = new Drone();
                drone.SetName(txtName.Text);
                drone.SetModel(txtModel.Text);
                drone.SetCost(Double.Parse(txtCost.Text));
                drone.SetProblem(txtProblem.Text);
                drone.SetServiceTag(int.Parse(numUpDown.ToString()));

                if (rdoRegular.Checked)
                {
                    RegularService.Enqueue(drone);
                }
                else
                {
                    ExpressService.Enqueue(drone);
                }

                MessageBox.Show("Regular: " + RegularService);
                MessageBox.Show("Express: " + ExpressService);
            }
            catch(IOException error)
            {
                //ErrorTrapping(error);
            }


        }
    }
}
