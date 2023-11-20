public class Aka
{
    public static void Main()
    {
        int n = 123, cnt = 0, sum = 0;
        sumOfDigits(n, ref cnt, ref sum);
        Console.WriteLine($"{cnt} xonali son raqamlari yig'indisi {sum}");
    }

    public static void sumOfDigits(int n, ref int count, ref int sum)
    {
        while(n > 0)
        {
            sum += n % 10;
            n /= 10;
            count++;
        } 
    }
}