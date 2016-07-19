using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridaBhatta
{
    class AddAdultPenson
    {
        //ctor
        //propful tab 
      //  private string FullName { get; set; }
        public AddAdultPenson()
        {
            this.FirstName = string.Empty;
            this.LastName = string.Empty;

        } 
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DOB { get; set; }
        public int Age { get{return Convert.ToInt16(calculateAge()) ;}}


        public double Amount { get { return Convert.ToDouble(calculateAmount()); } }
       

        private int calculateAge()
        {
            var year = DateTime.Parse(DOB).Year;
            var todayYear = DateTime.Now.Year;
            var age = todayYear - year;
            return age;          
        }

        private double calculateAmount()
        {
            if (Age > 70 && Age < 80)
            {
                return 500;
            }

            else if (Age > 80)
            {
                return 1000;
            }

            else
            {
                return 0;
            }
           
        }


        }
}
