using System;
using System.Text;

namespace RemoveAdjacentDuplicates
{
    class Program
    {
        //public static StringBuilder sb;
        public static string removeDuplicates(string s, int n)
        {
            StringBuilder sb = new StringBuilder();
            bool[] letters = new bool[26];            
            int repeat = 0;
            for (int i = 0; i < n; i++)
            {
                int curr_index = s[i] - 'a';                                
                if (!letters[curr_index])
                {
                    if(i-1>=0)
                    {
                        int pre_index = s[i - 1] - 'a';
                        letters[pre_index] = false;                       
                    }
                    repeat = 0;
                    letters[curr_index] = true;
                    sb.Append(s[i]);
                }
                else
                {
                    repeat++;
                    if (repeat == 1)
                        sb.Remove(sb.Length - 1, 1);
                }                
            }
            /***
            if (s.Length != sb.Length)
            {
                removeDuplicates(sb.ToString(), sb.Length);

            }***/
            //else { return sb.ToString(); }
            return sb.ToString();
        }

        public static string CallRemoveDuplicates(string str, int length)
        {
            StringBuilder strWithDups = new StringBuilder(str);

            //string strWithDups = str;
            string result = "" ;
            while(result.Length != strWithDups.Length)
            {
                strWithDups = new StringBuilder(result);
                result = removeDuplicates(strWithDups.ToString(), strWithDups.Length);
                
            }
            
            return result;
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            string input = "azxxzy";
           // StringBuilder sb = new StringBuilder(input);
            String Result= CallRemoveDuplicates(input,input.Length);

            Console.WriteLine(Result);
            Console.ReadLine();
        }
    }
}
