namespace NameInFrame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char frameChar = '%';

            Console.Write("Введите своё имя: ");
            string name = Console.ReadLine();

            Console.WriteLine();
            string frameTop = frameChar.ToString();

            for (int i = 0; i <= name.Length; i++)
            {
                frameTop += frameChar.ToString();
            }

            string frameBottom = frameTop;
            Console.WriteLine(frameTop);
            Console.WriteLine($"{frameChar}{name}{frameChar}");
            Console.WriteLine(frameBottom);
            Console.ReadKey();
        }
    }
}
