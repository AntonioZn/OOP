using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;

namespace OOP1
{
    public class Battery
    {
        private int hoursIdle;
        private string model;
        private int hourstalk;
        private BatteryType bateryType;

        public BatteryType BateryType
        {
            get { return bateryType; }
            set { bateryType = value; }
        }


        public int Hourstalk
        {
            get { return hourstalk; }
            set { hourstalk = value; }
        }


        public string Model
        {
            get { return model; }
            set { model = value; }
        }
        public int Hoursidle
        {
            get { return hoursIdle; }
            set { hoursIdle = value; }
        }
        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            if (this.Model == null)
            {
                result.AppendLine("New model is working without battery");


            }
            else
            {
                result.AppendLine(string.Format("Model: {0}", this.Model));
                result.AppendLine(string.Format("Battery Type: {0}", this.BateryType));
                result.AppendLine(string.Format("HoursIdle: {0}", this.Hoursidle));
                result.AppendLine(string.Format("HoursTalk: {0}", this.Hourstalk));
            }
            return result.ToString();
        }

    }
}
