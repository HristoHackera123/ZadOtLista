namespace MirrorNum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int result = MirrorNum(num);
            Console.WriteLine(result);
            Console.WriteLine($"Last figure of number({num}) is: {WordLastFigure(num)}");
        }
        static int MirrorNum(int num)
        {
            List<int> result = new List<int>();
            while (num > 0)
            {
                result.Add(num % 10);
                num /= 10;
            }
            return int.Parse(string.Join("", result));
        }
        static string WordLastFigure(int num)
        {
            string result = null;
            int last = num % 10;
            switch (last) 
            {
                case 0:
                    result = "zero";
                    break;
                case 1:
                    result = "one";
                    break;
                case 2:
                    result = "two";
                    break;
                case 3:
                    result = "three";
                    break;
                case 4:
                    result = "four";
                    break;
                case 5:
                    result = "five";
                    break;
                case 6:
                    result = "six";
                    break;
                case 7:
                    result = "seven";
                    break;
                case 8:
                    result = "eight";
                    break;
                case 9:
                    result = "nine";
                    break;
                default:
                    return "how.";

            }
            return result;
        }
    }
}
