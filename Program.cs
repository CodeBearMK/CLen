namespace Interface2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("輸入英制長度(吋)：");
            double len = float.Parse(Console.ReadLine());
            Console.WriteLine();
            CLen length = new CLen();
            length.Convert(len);
            Console.Read();
        }
    }
}