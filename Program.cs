namespace Assignment7._2._3
{
    internal class Program
    {
        static bool IsAnagram_Sort(string str1, string str2)
        {
            if (str1.Length != str2.Length)
            {
                return false;
            }

            char[] a = str1.ToCharArray();
            char[] b = str2.ToCharArray();

            Array.Sort(a);
            Array.Sort(b);

            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] != b[i])
                {
                    return false;
                }
            }

            return true;
        }
        static void Main(string[] args)
        {
            // Example usage
            string str1 = "anagram";
            string str2 = "nagaram";

            bool result = IsAnagram_Sort(str1, str2);

            Console.WriteLine(result ? $"{str1} and {str2} are anagrams." : $"{str1} and {str2} are not anagrams");
        }
    }
}
