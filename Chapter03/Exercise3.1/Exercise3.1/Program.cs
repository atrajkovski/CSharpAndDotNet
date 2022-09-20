using static System.Console;

int myNum = 12;

try
{
    WriteLine($"{myNum} / {0} = {myNum / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}

double myDouble = 12.0;

try
{
    WriteLine($"{myDouble} / {0} = {myDouble / 0}");
}
catch (Exception ex)
{
    WriteLine(ex.ToString());
}
int intOverflow = int.MaxValue;

WriteLine($"Min value of int: {int.MinValue}");
WriteLine($"Max value of int: {int.MaxValue}");
WriteLine($"Overflow of int by one: {++intOverflow + 1000000000}");

int y = 5;
int x = y++;
WriteLine($"y is {y}");
WriteLine($"x = y++ is {x}");

int c = 5;
int d = ++c;
WriteLine($"d = ++c is {d}");

for (int i = 0; i <= 5; i++)
{
    WriteLine(i);
    if (i == 2)
    {
        break;
    }
    WriteLine("End of iteration");
}

for (int i = 0; i <= 5; i++)
{
    WriteLine(i);
    if (i == 2)
    {
        continue;
    }
    WriteLine("End of iteration");
}

for (int i = 0; i <= 5; i++)
{
    WriteLine(i);
    if (i == 2)
    {
       // return;
    }
    WriteLine("End of iteration");
}
