using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//reDo line 33, public void SetProblem(string problem) formatting to Sentence case
namespace DroneServiceApplication
{
    internal class Drone
    {
        private string name;
        private string model;
        private string problem;
        private double cost;
        private int serviceTag;

        public void SetName(string name)
        {
            this.name = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(name);
        }
        public string GetName()
        {
            return this.name;
        }
        public void SetModel(string model)
        {
            this.model = model;
        }
        public string GetModel()
        {
            return this.model;
        }
        //in future change here to Sentence case format
        public void SetProblem(string problem)
        {
            this.problem = System.Globalization.CultureInfo.CurrentCulture.TextInfo.ToTitleCase(problem);
        }
        public string GetProblem()
        {
            return this.problem;
        }
        public void SetCost(double cost)
        {
            this.cost = cost;
        }
        public double GetCost()
        {
            return this.cost;
        }
        public void SetServiceTag(int serviceTag)
        {
            this.serviceTag = serviceTag;
        }
        public int GetServiceTag()
        {
            return this.serviceTag;
        }

        public string display()
        {
            return GetName() + " : " + GetCost();
        }
    }
}
