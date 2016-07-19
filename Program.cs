using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridaBhatta
{
    class Program
    {


        static void Main(string[] args)
        {

            bool checkContinue = true;
            
            List<AddAdultPenson> ListAdultPenson = new List<AddAdultPenson>();
            while (checkContinue)
            {
                AddAdultPenson _addOneAdultPension = new AddAdultPenson();

                Console.Write("Enter First Name:");
                _addOneAdultPension.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name:");
                _addOneAdultPension.LastName = Console.ReadLine();

                Console.WriteLine("Enter Your Date of Birth:");
                _addOneAdultPension.DOB = Console.ReadLine();
                var year = DateTime.Parse(_addOneAdultPension.DOB).Year;

                ListAdultPenson.Add(_addOneAdultPension);
                Console.WriteLine("Do you want to continue?Y/N?");
                checkContinue = (Console.ReadLine().ToUpper()) == "Y" ? true : false;

            }

            Console.WriteLine("Details are:");
            Console.WriteLine("Full Name:     Age:      Amount:");

              string query="Insert into PersonInfo (FirstName, LastName, DOB, Age, Amount) values(@fname,@lname,@dob,@age,@amount)";
            SqlHelper sqlhp = new SqlHelper();
          
            foreach (var item in ListAdultPenson)
            {
                Console.Write(item.FirstName + " " + item.LastName + "     ");
                Console.Write(item.Age+ "     ");
                Console.WriteLine(item.Amount);
                sqlhp.ExectueNonQuery(query,"@fname",item.FirstName,"@lname",item.LastName,"@dob",item.DOB,"@age",item.Age,"@amount",item.Amount);
            }

            
            sqlhp.Disconnect();

            Console.ReadLine();
        }
    }
}
