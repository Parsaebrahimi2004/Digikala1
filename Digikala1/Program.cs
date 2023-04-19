using Digikala1.Model;
using Digikala1.Operations;
using KeyBoardLock;
using System.Net;
Console.WriteLine("This program will analysis digikala's dataset");
Console.ForegroundColor= ConsoleColor.DarkBlue;
Console.WriteLine("Please wait the program is downloading the Dataset file...");
Console.ForegroundColor= ConsoleColor.DarkGray;


///////////////////////////////////////////////////////////////////////////////////////////
string A;
FileDownloader DF = new FileDownloader();
DF.DownloadFile();
do
{
    string address = @"D:\digikala dataset\orders.csv";

    DigikalaContext context = new DigikalaContext(address);

    DigikalaOperation op = new DigikalaOperation(context.digikalas);

    LockKeyBoard lk = new LockKeyBoard();

    
  
    Console.WriteLine("For searching by Order ID (press O)");
    Console.WriteLine();
    Console.WriteLine("For searching by Customer ID (press C)");
    Console.WriteLine();
    Console.WriteLine("For searching by Item ID (press I)");
    Console.WriteLine();
    Console.WriteLine("For searching by Date (press D)");
    Console.WriteLine();
    Console.WriteLine("For searching by City (press S)");
   
    string x = lk.Mlocker();

    switch (x)
    {
        case "o":
            Console.WriteLine("Enter id-order");
            int o = lk.keyboardnumberlocker();

            Console.WriteLine(op.SearchByIdOrder(o));

            break;

        case "c" :
            Console.WriteLine("Enter Id-customer");
            int c = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesBycustomer(c));

            break;


        case "i":
            Console.WriteLine("Enter id-item");
            int i = lk.keyboardnumberlocker();

            Console.WriteLine(op.sumSalesByitem(i));

            break;


        case "d":
            Console.WriteLine("Enter date ");
            int t = lk.keyboardnumberlocker();

            Console.WriteLine(op.SumSalesByYear(t));

            break;


        case "s":
            Console.WriteLine("Enter city in Farsi ( better to copy a name from data set)");
            string B = ""; Console.ReadLine();

            Console.WriteLine(op.SalesByCity(B));

            break;

        default:
            throw new Exception("Invalid Input.");

    }
    Console.WriteLine("Do you want to continiu ?(press Y for yes and N for no)");
    A = lk.keyboardYorNlocker();

} while (A.ToLower() == "y");

Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("**Thanks for using this program**");
//////////////////////////////////////////////////////////////////////////////////////////





