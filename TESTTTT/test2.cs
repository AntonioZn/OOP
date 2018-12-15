using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP1;



namespace TESTTTT
{
    class test2
    {
        static void Main(string[] args)
        {
            // gsm[] gsms = new gsm[10];
            // for (int i = 0; i < 10; i++)
            // {
            //     Console.WriteLine();
            // }
             var gsm = new gsm("S9",new InformationAboutOwner { address = "Shumen, District:Makak", iq = 160, profession = "Proffesional developer" }, "Samsung", 900, "Svetlozar Stoichkov", new Battery { Model = "Newest", Hoursidle = 20000, Hourstalk = 20000,BateryType = 0 }, new Display { Numberofcolors = 5000, Size = 13});
            // Console.WriteLine(gsm);
            // Console.WriteLine("Another Model");
            // Console.WriteLine("------------------------------");
            // Console.WriteLine();
            // Console.WriteLine(gsm.iPhone4S);
            //var call = new Call();
            //Console.WriteLine(call.Date);
            //Console.WriteLine(call.Time);
          
           for (int i = 0; i <10 ; i++)
           {
               gsm.Add(new Call() { DialedPhone = "000" + i, Duration = (uint)(i + 1) * 120 });
           }
            var maxCall = new Call();


            Console.WriteLine(gsm.CalculateTotalCost(0.37m));
            foreach  (Call call in gsm.CallHistory)
            {
                Console.WriteLine(call);
                if (maxCall.Duration < call.Duration)
                {
                    maxCall = call;
                }
            }
            Console.WriteLine(gsm.CalculateTotalCost(0.35m));
            gsm.Delete(maxCall);
            Console.WriteLine(gsm.CalculateTotalCost(0.35m));
            Console.WriteLine(gsm);

        }
    }
}
