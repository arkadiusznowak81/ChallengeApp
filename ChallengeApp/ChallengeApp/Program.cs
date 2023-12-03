int number = 4566;
string numberInString = number.ToString();
char[] letters = numberInString.ToArray();

int numberOf0 = 0;
int numberOf1 = 0;
int numberOf2 = 0;
int numberOf3 = 0;
int numberOf4 = 0;
int numberOf5 = 0;
int numberOf6 = 0;
int numberOf7 = 0;
int numberOf8 = 0;
int numberOf9 = 0;

foreach (var i in letters)
{
    if (i == '0')
    {
        numberOf0++;
    }
    else if (i == '1')
    {
        numberOf1++;
    }
    else if (i == '2')
    {
        numberOf2++;
    }
    else if (i == '3')
    {
        numberOf3++;
    }
    else if (i == '4')
    {
        numberOf4++;
    }
    else if (i == '5')
    {
        numberOf5++;
    }
    else if (i == '6')
    {
        numberOf6++;
    }
    else if (i == '7')
    {
        numberOf7++;
    }
    else if (i == '8')
    {
        numberOf8++;
    }
    else if (i == '9')
    {
        numberOf9++;
    }
}

Console.WriteLine("Wyniki dla liczby " + numberInString + "\r\n0 => " + numberOf0 + "\r\n1 => " + numberOf1 + "\r\n2 => " + numberOf2 + "\r\n3 => " + numberOf3
    + "\r\n4 => " + numberOf4 + "\r\n5 => " + numberOf5 + "\r\n6 => " + numberOf6 + "\r\n7 => " + numberOf7 + "\r\n8 => " + numberOf8 + "\r\n9 => " + numberOf9);