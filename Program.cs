// See https://aka.ms/new-console-template for more information

var hit = 0;
do
{
    hit++;
    Console.WriteLine(DateTime.UtcNow);
    Thread.Sleep(1000);
    
}while (hit <= 2);