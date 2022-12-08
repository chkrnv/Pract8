using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Xml.Linq;

namespace Pract8
{
    internal class GeometricProgression : ISeries
    {
        private int _firstValue, _secondValue;
        private double _step;
        public int FirstValue
        {
            get { return _firstValue; }
            set { _firstValue = value; }
        }
        public int SecondValue
        {
            get { return _secondValue; }
            set { _secondValue = value; }
        }
        public double Step
        {
            get { return _step; }
            set { _step = value; }
        }
        public GeometricProgression(int firstValue, int secondValue)
        {
            _firstValue = firstValue;
            _secondValue = secondValue;
            _step = secondValue / firstValue;
        }
        
        public int CompareTo(object obj)
        {
            GeometricProgression progression = (GeometricProgression)obj;
            double step1=progression.Step;
            double step2=this.Step;
            return step2.CompareTo(step1);
        }
       
        public GeometricProgression ShallowClone()
        {
            return (GeometricProgression)MemberwiseClone();
        }

        public object Clone()
        {
            return new GeometricProgression(FirstValue,SecondValue);
        }
    }
}
