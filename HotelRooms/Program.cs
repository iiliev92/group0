using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelRooms
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int days = int.Parse(Console.ReadLine());
            double studioPrice = 0, apartmentPrice = 0;

            if (days < 7)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50 * days;
                    apartmentPrice = 65 * days;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * days;
                    apartmentPrice = 68.20 * days;
                }
                else if (month == "July" || month == "August")
                {
                    studioPrice = 76 * days;
                    apartmentPrice = 77 * days;
                }
            }
            else if (days > 7 && days <= 14)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50 * days * 0.95;
                    apartmentPrice = 65 * days;
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * days;
                    apartmentPrice = 68.70 * days;
                }
                else if (month == "July" || month == "August")
                {
                    studioPrice = 76 * days;
                    apartmentPrice = 77 * days;
                }
            }
            else if (days > 100)
            {
                if (month == "May" || month == "October")
                {
                    studioPrice = 50 * days * 0.7; 
                }
                else if (month == "June" || month == "September")
                {
                    studioPrice = 75.20 * days * 0.8;
                }
                else if (month == "July" || month == "August")
                {
                    studioPrice = 76 * days;
                }

                apartmentPrice = 65 * days * 0.9;
                //apartmentPrice = 65 * days - 65 * days * 0.1;
            }


            Console.WriteLine("Apartment: {0:f2} lv.", apartmentPrice);
            Console.WriteLine("Studio: {0:f2} lv.", studioPrice);
        }
    }
}
