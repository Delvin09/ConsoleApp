namespace ConsoleApp.CLI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string hello = null;
            hello ??= "default string value";

            switch (hello)
            {
                case "Hello":
                    Console.WriteLine("asdasd");
                    goto case "Bay bay";
                case "Bay bay":
                    break;
                default:
                    //.............
                    break;
            }

            int r = hello switch
            {
                "Hello" => 10,
                "Bay bay" => -1,
                _ => int.MinValue
            };

            List<int> list = new List<int>() { 1, 0, 1, 1, 1, 1 };

            foreach (var i in list)
            {
                if (i == 0)
                {
                    list.Remove(i);
                }
            }

            Console.WriteLine();

            int[,] matrix = new int[10, 10];

            int[][] jaggedArray = new int[4][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                if (i == 0)
                    jaggedArray[i] = new int[2];
                if (i == 1)
                    jaggedArray[i] = new int[0];
                if (i == 2)
                    jaggedArray[i] = new int[4];
            }

            string[] strings = new string[4] { "asdas", "adsasd", "adsasd", "" };
            for (int i = 0; i < strings.Length; i++)
            {
                var str = strings[i];
                for (int j = 0; j < str.Length; j++)
                {
                    var ch = str[j];
                    if (ch != ' ')
                    {

                    }
                }
            }
        }
    }
}
