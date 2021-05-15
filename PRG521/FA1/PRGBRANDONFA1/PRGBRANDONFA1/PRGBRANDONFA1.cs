using System;
//6854 Brandon de Bruyn

namespace PRGBRANDONFA1
{
    
    class PRGBRANDONFA1
    {
        
        static void Main(string[] args)
        {
            string s1, s2, s3;

            Console.WriteLine("Enter String: ");
            s1 = Console.ReadLine();

            Console.WriteLine("Enter substring you want to find: ");
            s2 = Console.ReadLine();

            Console.WriteLine("Enter a string to replace: ");
            s3 = Console.ReadLine();

            

            SearchReplace s = new SearchReplace();
            s.SearchSubstring(s1, s2);
            s.ReplaceSubString(s1, s2, s3);

            Console.ReadLine();
        }

        public class SearchReplace
        {
            public string SearchSubstring(string s1, string s2) //SearchSubstring
            {
                String t1 = "Valid";
                if(s1.Contains(s2))
                {
                    Console.WriteLine(t1);
                }
                return t1;
            }

            public void ReplaceSubString(string s1, string s2, string s3)
            {
                string temp = s1.Replace(s2, s3);
                Console.WriteLine("Your new String is:" + temp);
            }
        }
    }
}
