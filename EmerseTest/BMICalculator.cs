using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmerseTest
{
    class BMICalculator
    {
        private string name="No Name";
        private double height=0.0;
        private double weight=0.0;
        private UnitTypes unit;

        public string GetName()
        {
            return name;
        }
        public void SetName(string value)
        {
            if (!string.IsNullOrEmpty(value))
            value = name;
        }
        public double GetHeight()
        {
            return height;
        }
        public void SetHeight(double value)
        {
            if (height >= 0)
                height = value;
        }
        public double GetWeight()
        {
            return weight;
        }
        public void SetWeight(double value)
        {
            if (weight >= 0)
                weight = value;
        }
        public UnitTypes GetUnit()
        {
            return unit;
        }
        public void SetUnit(UnitTypes value)
        {
            unit = value;
        }      
        public double CalculateMetric()
        {
            double bmi=0.0;
            double heightInMeter = height / 100;
            bmi = (weight / (heightInMeter * heightInMeter));
            return bmi;
        }
        public double CalculateAmerican()
        {
            double bmi;
            bmi = (703.0*weight/ (height * height));
            return bmi;
        }

    }
  
}
