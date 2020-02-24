using System;

namespace Problems
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("String Input: ");
			string i = Console.ReadLine();
			Console.WriteLine(Prefix(i));
        }

		public static string Prefix (String input)
		{
			if (input.Length == 0)
				return "null";
			int len = input.Length;
			int num_words = 0;
			for (int k = 0; k<len;k++)
			{
				if (input[k] == ' ' && input[k-1] != ' ' && k != (len-1))
					num_words++;
				if (k == (len-1))
					num_words = num_words+1;
			}
			string output = len + "," + num_words + ":" + input;
			return output;
		}

    }
}
