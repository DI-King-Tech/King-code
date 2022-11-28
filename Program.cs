using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace Waterbill
{
    internal class Waterbill
    {
        public string Name { get; set; }
        public string Residentialplace { get; set; }
        public string address { get; set; }
        public double portablewaterused { get; set; } 
        public double portablewatercost     { get; set; }
        public double portablewaterwastecost { get; set; }
        public double portablewaterwastecostwithVAT { get; set; }
        public double portablewatercostwithVAT;
        public double Totalcost;
      
        public Waterbill (string Fullnames,string Resident, string add, double Kl , double klamount,double wasterwater,double watercostwithVat, double wastewaterwithVat , double TotalAMOUNT)
        {
            Name = Fullnames;
            Residentialplace = Resident;
            address = add;
            portablewaterused = Kl;
            portablewatercost = klamount;
            portablewaterwastecost = wasterwater;
            portablewaterwastecostwithVAT = wastewaterwithVat;
            portablewatercostwithVAT = watercostwithVat;
            Totalcost= TotalAMOUNT;
        }
        public double watermathdomestic() // this will calculate the portable water used in domestic.
        {
            switch (portablewaterused)
            {
                case  > 5.0:
                    portablewatercost = portablewaterused * 3.60 ;
                    portablewatercostwithVAT = portablewaterused * 3.60;
                    portablewaterwastecost = portablewaterused * 0.65;
                    portablewaterwastecostwithVAT = portablewaterused * 0.65;
                    Totalcost =( portablewaterused * 3.60) + (portablewaterused * 0.65);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name      +  "Stay"          +  Residentialplace     + "Plot"   + address     +  "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is : %14 ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                case  5.0 - 15.0:
                    portablewatercost = portablewaterused * 11.78;
                    portablewatercostwithVAT = portablewaterused * 13.43;
                    portablewaterwastecost = portablewaterused * 2.95;
                    portablewaterwastecostwithVAT = portablewaterused * 3.36;
                    Totalcost = (portablewaterused * 13.43) + (portablewaterused * 3.36)+ (portablewaterused * 3.60 )+ (portablewaterused * 0.65);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name   +   "Stay" +    Residentialplace    +  "Plot"   +  address       + "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl:  " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14 ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break ;

                case > 15.0-25.0:
                    portablewatercost = portablewaterused * 20.62;
                    portablewatercostwithVAT = portablewaterused * 23.51;
                    portablewaterwastecost = portablewaterused * 4.41;
                    portablewaterwastecostwithVAT = portablewaterused * 5.03;
                    Totalcost = (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name        +  "Stay"       +  Residentialplace       +   "Plot"       +  address       + "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14  ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                case > 25.0 - 40.0:
                    portablewatercost = portablewaterused * 31.72 ;
                    portablewatercostwithVAT = portablewaterused * 36.16;
                    portablewaterwastecost = portablewaterused * 5.89;
                    portablewaterwastecostwithVAT = portablewaterused * 6.71;
                    Totalcost =  (portablewaterused * 36.16) + (portablewaterused * 6.71) + (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name +   "Stay"      +   Residentialplace      +     "Plot"     +   address        +   "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl  " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14  ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                default:
                    portablewatercost = portablewaterused * 39.66;
                    portablewatercostwithVAT = portablewaterused * 45.21;
                    portablewaterwastecost = portablewaterused * 7.36;
                    portablewaterwastecostwithVAT = portablewaterused * 8.39;
                    Totalcost =  (portablewaterused * 45.21)  + (portablewaterused * 8.39) + (portablewaterused * 36.16) + (portablewaterused * 6.71) + (portablewaterused * 23.51) + (portablewaterused * 5.03) + (portablewaterused * 13.43) + (portablewaterused * 3.36) + (portablewaterused * 3.60) + (portablewaterused * 0.65);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name +    "Stay"       +    Residentialplace    +    "Plot"    +  address      +   "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14 " );
                    Console.WriteLine("Total Amount : P "  + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

            }
            return portablewatercost;
        }


      
        public double watermathBusinessCom()// This will be the portable water  cost for the comercial industry.
        {
            switch (portablewaterused)
            {
                case > 5.0:
                    portablewatercost = portablewaterused * 4.32 ;
                    portablewatercostwithVAT = portablewaterused * 4.92 ;
                    portablewaterwastecost = portablewaterused * 0.65;
                    portablewaterwastecostwithVAT = portablewaterused * 0.74;
                    Totalcost =  (portablewaterused * 4.92)  + (portablewaterused * 0.74);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name +     "Stay"    +    Residentialplace        +      "Plot"      +   address      +   "Monthly Bil");
                    Console.WriteLine("Portable Water used Kl " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14  " );
                    Console.WriteLine("Total Amount : P" + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                case 5.0 - 15.0:
                    portablewatercost = portablewaterused * 12.83 ;
                    portablewatercostwithVAT = portablewaterused * 14.61 ;
                    portablewaterwastecost = portablewaterused * 2.95 ;
                    portablewaterwastecostwithVAT = portablewaterused * 3.36 ;
                    Totalcost = (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name      +    "Stay"   +    Residentialplace    +    "Plot"   +    address    +      "Monthly Bill");
                    Console.WriteLine("Portable Water cost " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14 , portablewaterwastecostwithVAT " + portablewaterwastecostwithVAT + " portablewatercostwithVAT " + portablewatercostwithVAT);
                    Console.WriteLine("Total Amount : " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;
                case > 15.0 - 25.0:
                    portablewatercost = portablewaterused * 22.44;
                    portablewatercostwithVAT = portablewaterused * 25.88;
                    portablewaterwastecost = portablewaterused * 4.41;
                    portablewaterwastecostwithVAT = portablewaterused * 5.03;
                    Totalcost = (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " +   Name       +    "Stay"    +     Residentialplace       +     "Plot"     +    address         +    "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl" + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14 " );
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                case > 25.0 - 40.0:
                    portablewatercost = portablewaterused * 34.52;
                    portablewatercostwithVAT = portablewaterused * 39.35;
                    portablewaterwastecost = portablewaterused * 5.89;
                    portablewaterwastecostwithVAT = portablewaterused * 6.71;
                    Totalcost = (portablewaterused * 39.35) + (portablewaterused * 6.71) + (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name       +    "Stay"    +     Residentialplace      +   "Plot"    +    address      +    "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl " + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14  ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

                default:
                    portablewatercost = portablewaterused * 43.16;
                    portablewatercostwithVAT = portablewaterused * 49.20;
                    portablewaterwastecost = portablewaterused * 7.36;
                    portablewaterwastecostwithVAT = portablewaterused * 8.39;
                    Totalcost = (portablewaterused * 49.20) + (portablewaterused * 8.39) + (portablewaterused * 39.35) + (portablewaterused * 6.71) + (portablewaterused * 25.88) + (portablewaterused * 5.03) + (portablewaterused * 14.61) + (portablewaterused * 3.36) + (portablewaterused * 4.92) + (portablewaterused * 0.74);
                    Console.WriteLine("******************************************************************************************************************");
                    Console.WriteLine("Names: " + Name +    "Stay"    +    Residentialplace     +    "Plot"     +    address     +     "Monthly Bill");
                    Console.WriteLine("Portable Water used Kl" + portablewaterused);
                    Console.WriteLine("Monthly Bill for Portable water cost is : P " + portablewatercost);
                    Console.WriteLine("Monthly Bill for Waste water cost is : P " + portablewaterwastecost);
                    Console.WriteLine("Monthly VAT is %14 ");
                    Console.WriteLine("Total Amount : P " + Totalcost);
                    Console.WriteLine("******************************************************************************************************************");
                    break;

            }
            return portablewaterused;
        }
    }
    internal class WaterBilltest
    {
        static void Main(string[] args)
        {
            StreamWriter outputFile;
            StreamWriter recordFile;
            outputFile = new("Invoice.csv"); // this is where the file will be saved .
            recordFile = File.AppendText("Report.csv");// this the report that will be outputed from the previous months.
            
            Waterbill waterbill = new Waterbill("0","0","0",0,0,0,0,0,0);

            for (int i = 0; i < 3; i++)
            {
                if (i == 1)
                {
                    Console.WriteLine("Do you want to continue? enter 1 for Yes and 2 for No");
                    int answer1 = Convert.ToInt32(Console.ReadLine());
                    if (answer1 == 1)
                    {
                        continue;
                    }
                    else
                    {
                        break;
                    }
                }

                ConsoleKeyInfo key;

                string password = ("");

                Console.WriteLine(" Please Enter Username");
                string Username = Console.ReadLine();// user name.

                Console.WriteLine("Please Enter Password ");
                do
                {
                    key = Console.ReadKey(true);
                    if (key.Key != ConsoleKey.Backspace)
                    {
                        password += key.KeyChar;

                        Console.Write("*********");

                    }
                    else
                    {
                        if (password.Length > 0)
                        {
                            password = password.Substring(0, password.Length - 1);//password is stored.
                            Console.Write("\b \b");
                        }
                    }

                } while (key.Key! == ConsoleKey.Enter);

                outputFile.WriteLine("User Name is : " + Username);
                outputFile.WriteLine("Password is :" + password);



                Console.WriteLine("*****************************************************************************");
                outputFile.WriteLine("******************************************************************************");
                Console.WriteLine();
                Console.WriteLine("Please Enter Full Names :");
                waterbill.Name = Console.ReadLine();// the name will be stored in this string Name.
                outputFile.WriteLine("Name" + waterbill.Name);
                Console.WriteLine("Please Enter REsidential place");
                waterbill.Residentialplace = Console.ReadLine();
                outputFile.WriteLine("Residence "+ waterbill.Residentialplace);
                Console.WriteLine("Please Enter Address Plot");
                waterbill.address = Console.ReadLine();
                outputFile.WriteLine("Plot" + waterbill.address);
                Console.WriteLine("Please enter water Kilo Litres used");
                waterbill.portablewaterused = Convert.ToDouble(Console.ReadLine());
                outputFile.WriteLine("Portable Water Used :" + waterbill.portablewaterused);
                Console.WriteLine("The water used in Kilo Liters What user type  is it Domestic enter 1 if not then Enter 2 for Business Commercial");// to determine which is tarrif the customer belongs to.
                int answer;
                answer = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("_ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _ _   _ __ _ _ _ _ _ _ _  _ _   __ _ _ _ _ _ _  __ _ _ _ _ _ __ _ ");

                if (answer == 1)
                {
                    
                    outputFile.WriteLine(waterbill.Name + waterbill.Residentialplace + waterbill.address + " Monthly Bill");
                    Console.WriteLine(waterbill.watermathdomestic());// invoking the method for math domstic.
                    outputFile.WriteLine(waterbill.watermathdomestic());
                }
                else
                {
                   
                    outputFile.WriteLine(waterbill.Name + waterbill.Residentialplace + waterbill.address + " Monthly Bill");
                    Console.WriteLine(waterbill.watermathBusinessCom());// invoking the method for math business.
                    outputFile.WriteLine(waterbill.watermathBusinessCom());
                }
                
            

               
                

            }
            outputFile.Close();
            recordFile.Close();
            Console.WriteLine("_ _ _ _ _  __ _ _ _ _  _ __  __ _ _ __  _ _ _ _ __  _ _ _ _  _  _  _ __ _ _ _ _ __  _ __ _  _  _  _ _ __ _ _ _ _ _ _  __ ");
           














        }
    }
}

