// See https://aka.ms/new-console-template for more information


/*
Создайте делегат, который принимает два аргумента типа int и возвращает результат их суммы.
Создайте делегат, который принимает строку и возвращает ее длину.
Создайте делегат, который принимает два аргумента типа double и возвращает результат их умножения.
Создайте делегат, который принимает список чисел и возвращает их сумму.
Создайте делегат, который принимает строку и возвращает ее в верхнем регистре.
Создайте делегат, который принимает числа и возвращает их среднее значение.
Создайте делегат, который принимает список строк и возвращает длины этих строк.
Создайте делегат, который принимает строку и проверяет является ли она палиндромом.
Создайте делегат, который принимает список чисел и возвращает их произведение.


 */

using Delegate_ConsoleApp;

Console.WriteLine("Hello, Delegate!");
HelloDelegate d = new HelloDelegate();

d.GetSummaIntInt += GetSummaInt;

Console.WriteLine(d.GetSummaIntInt(3,7));

static int GetSummaInt(int a, int b)
{
    return a + b;
}

static double GetSummaDouble(double a, double b)
{
    return a + b;
}

d.SummaDouble += GetSummaDouble;
Console.WriteLine(d.SummaDouble(3.4d,1.3f));

static int GetLenghtString(string myString)
{
    return myString.Length;
}

d.LenghtString += GetLenghtString;
Console.WriteLine(d.LenghtString("My love, my live, my moto"));

static int GetSummaListInt(List<int> listInts)
{
    return listInts.Sum();
}

d.SummaListInt += GetSummaListInt;
Console.WriteLine(d.SummaListInt(new List<int>(){1,4,6,9,6,4}));
static string SetUpperString(string myString)
{
    return myString.ToUpper();
}

d.SetUpperString += SetUpperString;
Console.WriteLine(d.SetUpperString("no Upper? itsloWer."));
static double GetAvg(List<int> listInts)
{
    var result = (double)listInts.Sum() / listInts.Count;
    return result;
}

d.GetAvgInts += GetAvg;
Console.WriteLine(d.GetAvgInts(new(){34,29}));

static List<int> GetLenghtStringsByList(List<string> listString)
{
    var result = listString
        .Select(el => el.Length)
        .ToList();
    return result;
}

d.LenghtListString += GetLenghtStringsByList;
Console.WriteLine(string.Join(Environment.NewLine,d.LenghtListString(
    new(){"hello","world", "life", "Wife"})));

static bool IsPalindrome(string str)
{
    if (str is null || str.Length == 0)
    {
        return false;
    }

    if (str.Length == 1)
    {
        return true;
    }

    var reverse =string.Join("",str.Reverse()) ;

    var result = str.CompareTo(reverse);
    if (result == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}

d.IPalindrome += IsPalindrome;
string palindrome = "fghhgf";
Console.WriteLine($"{palindrome} is "+ d.IPalindrome(palindrome));

static int GetMultiplyList(List<int> listInts)
{
    int result = 0;
    if (listInts.Count > 0)
    {
        result = listInts[0];
    }

    for (int i = 1; i < listInts.Count; i++)
    {
        result *= listInts[i];
    }

    return result;
}

d.GetMultiplyListInt += GetMultiplyList;

Console.WriteLine(d.GetMultiplyListInt(new(){9,7,5,22,3,5,6,}));