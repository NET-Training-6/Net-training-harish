

// class EntryPoint
// {
//     public static void Main()
//     {  
//         var input = Console.ReadLine();        
//         var number = 65;

//         if(number % 2 == 0)
//         {
//             Console.WriteLine(number + " is even");
//         }
//         else
//         {
//             Console.WriteLine(number + " is odd");
//         }

        
//         CW - Calculate simple interest for pricipal amount, time and rate given by user.

//         Console.ReadKey();
//     }
// }

class classwork
{
    public static void Main()
   {
    Console.WriteLine(" enter an amount");
    int amt = int.parse(console.ReadLine());
    console.writeline("enter a time period:");
    int ti = int.parse(console.ReadLine());
    console.writeline("enter a interest");
    int rate = int.parse(console.ReadLine());
    int si = amt*ti*rate/100;
    console.writeline(" the simple interest is ="+si);
   }


}