namespace Delegate_ConsoleApp;

public class HelloDelegate
{
    public delegate int GetSummaInt(int a, int b);

    public GetSummaInt GetSummaIntInt;

    public delegate int GetLenghtString(string myString);

    public GetLenghtString LenghtString;

    public delegate double GetSummaDouble(double a, double b);

    public GetSummaDouble SummaDouble;

    public delegate int GetSummaListInt(List<int> listInts);

    public GetSummaListInt SummaListInt;

    public delegate string GetUpperString(string myString);

    public GetUpperString SetUpperString;

    public delegate double GetAvg(List<int> ints);

    public GetAvg GetAvgInts;

    public delegate List<int> GetLenghtStringsByList(List<string> listString);

    public GetLenghtStringsByList LenghtListString;

    public delegate bool ItSPalindrome(string str);

    public ItSPalindrome IPalindrome;


    public delegate int GetMultiplyList(List<int> listInts);

    public GetMultiplyList GetMultiplyListInt;
}