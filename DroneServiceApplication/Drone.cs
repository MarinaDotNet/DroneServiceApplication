using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * author: msichova
 * student id: P272494
 * DroneServiceApplication
 * Date: 08.11.2022
 */

namespace DroneServiceApplication
{
    internal class Drone
    {
        private string name;
        private string model;
        private string problem;
        private double cost;
        private double serviceTag;

        public Drone(string name, string model, string problem)
        {
            this.name = name;
            this.model = model;
            this.problem = problem;
        }
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
        public void SetServiceTag(double serviceTag)
        {
            this.serviceTag = serviceTag;
        }
        public double GetServiceTag()
        {
            return this.serviceTag;
        }

        public string display()
        {
            return GetName() + " : " + GetCost();
        }
    }
}
