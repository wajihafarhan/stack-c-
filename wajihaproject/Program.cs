// See https://aka.ms/new-console-template for more information
//LIST

//List<string> Mobiles = new List<string>();
//string userinput;

//do
//{
//    Console.WriteLine("Enter your mobile name");

//    userinput = (Console.ReadLine()).ToLower();
//    if (userinput != "no")
//    {
//        Mobiles.Add(userinput);
//    }

//}
//while (userinput != "no");

//foreach (var item in Mobiles)
//{
//    Console.WriteLine(item);
//}


// GENERIC COLEECTION (datatype will be fixed)
//queue
// lifo(first in first out)
//example
//Queue
//fifo 
using System.Collections;

//Queue<string> name = new Queue<string>();

//name.Enqueue("Zain");
//name.Enqueue("Ali");
//name.Enqueue("hassan");
//name.Enqueue("Waqar");
//name.Enqueue("Musa");
//name.Enqueue("Talha");

//name.Dequeue();
//name.Dequeue();
//name.Dequeue();

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}

//lifo
//stack
//Stack<string> name = new Stack<string>();

//name.Push("Zain");
//name.Push("Ali");
//name.Push("hassan");
//name.Push("Waqar");
//name.Push("Musa");
//name.Push("Talha");

//name.Pop();
//name.Pop();
//name.Pop();

//foreach (var item in name)
//{
//    Console.WriteLine(item);
//}


//non genric
//arraylist
//ArrayList address = new ArrayList();

//address.Add("North Karachi");
//address.Add("Sector 5c3");
//address.Add("street no 136");
//address.Add("L-354");

//ArrayList person = new ArrayList();

//person.Add("wajiha");
//person.Add(21);
//person.Add(03172667345);
//person.Add("accp");
//person.Remove(21);
//person.RemoveAt(0);
//person.RemoveRange(2, 2);
//person.AddRange(address);
//person.Clear();
//person.Contains("accp");

//Console.WriteLine(person[2]);

//foreach (var item in person)
//{
//    Console.WriteLine(item);

//}
//task
//create an array list for the mobile application. 
ArrayList Mobiles = new ArrayList();
string userinput;

do
{
    Console.WriteLine("Enter your Specification");

    userinput = (Console.ReadLine()).ToLower();
    if (userinput != "ok")
    {
        Mobiles.Add(userinput);
    }

}
while (userinput != "ok");

foreach (var item in Mobiles)
{
    Console.WriteLine(item);
}