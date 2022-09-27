class MyClass
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите несколько слов через пробел: ");
        var str = Console.ReadLine().Split(" ");
        var str2 = String.Join("", str).ToCharArray();

        string[] str3 = new string[str2.Length / 3 + 1];
        for (int i = 0; i < str2.Length; i++ )
        {
            for (int j = 0; j < 4; j++)
            {
                str3[i] = "" + str2[j];
            }
            
        }


        Console.WriteLine(String.Join(", ", str3));
    }
}