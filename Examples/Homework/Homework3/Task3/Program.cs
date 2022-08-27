class Program
{
    static void Main(string[] args)
    {
        int numberN = int.Parse(Console.ReadLine());
        double result;

        for (int i = 1; i <= numberN; i++)
        {
            result = Math.Pow(i, 3);
            Console.WriteLine(result);
        }
    } 
}