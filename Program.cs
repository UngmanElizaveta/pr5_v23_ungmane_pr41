// See https://aka.ms/new-console-template for more information
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine());

int summChet=0;
int summNechet = 0;
int result = 0;

while (n>9)
{
    bool pos = true;//нечетное
    while (n>0)
   {
        if(pos)
        {
            summNechet += n % 10;
        }
        else
        {
            summChet += n % 10;
        }
        n/=10;
        pos = !pos;
   }
   result=summNechet-summChet;
}

Console.WriteLine(result);