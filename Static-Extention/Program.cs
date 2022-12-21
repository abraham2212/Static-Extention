using Static_Extention.Helpers;
using Static_Extention.Models;

Book Book1 = new Book();
Book Book2  = new Book();
Book Book3  = new Book();
Book Book4 = new Book();
Book Book5= new Book();


//Console.WriteLine(Book.Count);
////Book5.GetCount();
//Book.Count = 100;
//Console.WriteLine(Book.Count);



//int num =100;
//Console.WriteLine( num.GetNum());


string address = "Italy";
if (address.CheckDigitString())
{
    Console.WriteLine("reqem var");

}
else
{
    Console.WriteLine("reqem yoxdur ");
}


Console.WriteLine(address.CheckDigitString());