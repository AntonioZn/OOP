using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{


    public class gsm
    {


        #region fields   
        private string manufacturer;
        private decimal? price;
        private string owner;
        private Battery baterry;
        private Display display;
        private InformationAboutOwner informationaboutowner;
        private static gsm IPhone4S;
        private List<Call> callHistory;

        public List<Call> CallHistory
        {
            get {
                return new List<Call>(this.callHistory);}
            set
            {
                if (this.callHistory == null)
                {
                    this.callHistory = new List<Call>();
                }
                this.callHistory.Clear();
                this.callHistory = value;
            }
        }


        public InformationAboutOwner InformationAboutOwner
        {
            get { return informationaboutowner; }
            set { informationaboutowner = value; }
        }
         static gsm()
        {
            IPhone4S = new gsm("iPhone 4S", new InformationAboutOwner { address = "Shumen, District:POJARNATA", iq = 159, profession = "Noob" }, "Apple", 200, "Antonio Nikolov", new Battery { Model = "Newest", Hoursidle = 20000, Hourstalk = 20000, BateryType = 0 }, new Display { Numberofcolors = 5000, Size = 13 });

        }

        #endregion fields  
        #region Constructors
        public gsm(string model, InformationAboutOwner informationaboutowner, string manufacturer, decimal? price, string owner,Battery battery,Display display)
        {
            this.Model = model;
            this.Manufacturer = manufacturer;
            this.Price = price;
            this.Owner = owner;
            this.Display = display;
            this.Battery = battery;
            this.InformationAboutOwner = informationaboutowner;
            this.callHistory = new List<Call>();

 
        }
        //public gsm(string model, string manufacturer, string owner)
        //    : this(model, manufacturer)
        //{
        //    this.owner = owner;
        //
        //}
        //public gsm(string model, string manufacturer, string owner, Battery battery)
        //    : this(model, manufacturer, owner)
        //{
        //
        //    this.Battery = battery;
        //
        //}






        #endregion Constructors
        #region Properties
        public static  gsm iPhone4S { get { return IPhone4S; } }
        public Display Display
        {
            get { return display; }
            set { display = value; }
        }



        public Battery Battery
        {
            get { return baterry; }
            set { baterry = value; }
        }






        public string Owner
        {
            get { return owner; }
            set { if ( string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                owner = value; }
        }


        public decimal? Price
        {
            get { return price; }
            set { if ( value == null)
                {
                    throw new ArgumentException();
                }
                price = value; }
        }



        public string Manufacturer
        {
            get { return manufacturer; }
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException();
                }
                manufacturer = value; }
        }


        public string Model { get; set; }
        #endregion Properties
        #region Methods
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
        
            sb.AppendLine(string.Format($"Owner: {this.Owner}"));
            sb.AppendLine(string.Format($"Address: {this.InformationAboutOwner}"));
            sb.AppendLine(string.Format($"Manufacturer: {this.Manufacturer}"));
            sb.AppendLine(string.Format($"Model: {this.Model}"));
            sb.AppendLine(string.Format($"Price: {this.Price}"));
            sb.AppendLine(string.Format($"Display: {this.Display}"));
            sb.AppendLine(string.Format($"Battery: {this.Battery}"));
            return sb.ToString();
        }
        public void Add(Call call)
        {
            this.callHistory.Add(call);
        }
        public void Delete(Call call)
        {
            this.callHistory.Remove(call);
        }
        public void ClearHistory()
        {
            this.callHistory.Clear();
        }
        public decimal CalculateTotalCost(decimal fixedPrice)
        {
            ulong totalDuration = 0;
            foreach (Call call in this.callHistory)
            {
                totalDuration += (ulong)call.Duration;
            }
            return fixedPrice * (decimal)(totalDuration / 60);
        }
        #endregion Methods


    }
}
