using System;

namespace StandLine
{
    class StandInLine
    {
        int[] Reconstruct(int[] left)
        {
            int[] final = new int[left.Length];
            int position = 0;
            int height = 1;
            int flag = 0;
            for (int i = 0; i < left.Length; i++)
            {
                position = 0;
                while (flag != 1)
                {
                    if (left[i] > 0 && final[position] == 0)
                    {
                            position++;
                            left[i]--;   
                    }
                    else if (left[i] == 0 && final[position] == 0)
                    {
                        final[position] = height;
                        height++;
                        flag = 1;
                    }
                    else
                    {
                        position++;
                    }
                }
                flag = 0;
            }
            return final;
        }

        
        public static void Main(String[] args)
        {
            String input = Console.ReadLine();
            StandInLine standInLine = new StandInLine();
            do
            {
                int[] left = Array.ConvertAll<string, int>(input.Split(','), delegate (string s) { return Int32.Parse(s); });
                Console.WriteLine(string.Join(",", Array.ConvertAll<int, string>(standInLine.Reconstruct(left), delegate (int s) { return s.ToString(); })));
                input = Console.ReadLine();
            } while (input != "-1");
        }       
    }
}
