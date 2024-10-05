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
            Console.Write(frameChar);

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(frameChar);
            }

            Console.WriteLine(frameChar);
            Console.Write(frameChar);
            Console.Write(name);
            Console.WriteLine(frameChar);
            Console.Write(frameChar);

            for (int i = 0; i < name.Length; i++)
            {
                Console.Write(frameChar);
            }

            Console.WriteLine(frameChar);
            Console.ReadKey();
        }
    }
}
