// See https://aka.ms/new-console-template for more information

using readTxt;

var txt = File.ReadAllText("txt.txt");
Console.WriteLine(txt);
Console.ReadLine();

//singleton

foreach (var message in Helper.Instance.MessagesList)
{
    Console.WriteLine(message);

}