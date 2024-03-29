using System.Runtime.Serialization;
using System.Threading.Channels;
using static System.Net.Mime.MediaTypeNames;

namespace ArrayMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str1 = "Hello World";
            Console.WriteLine(StringMethod1(str1));

            Console.WriteLine("*******************");
            string txt = "Salam123";
            Console.WriteLine(StringMethod2(txt));
            Console.WriteLine("*******************");
            string text = "Salam Dunya!";
            Console.WriteLine(FirstWord(text));
            Console.WriteLine("*******************");
            int[] nums = { 1, 2, 4, 5 };
            int n = 9;
            IntegerArray(ref nums, n);
            for (int j = 0; j < nums.Length; j++)
            {
                Console.Write(nums[j]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("*******************");
            string sent1 = "     hello,    world        ";
            Task1(ref sent1);
            for(int j = 0;j < sent1.Length; j++)
            {
                Console.Write(sent1[j]);
            }
            Console.WriteLine();

        }


        static bool StringMethod2(string txt)
        {
            bool check1 = false;
            bool check2 = false;
            bool check3 = false;
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] >= '0' && txt[i] <= '9')
                {
                    check1 = true;
                }
                else if (txt[i] >= 'a' && txt[i] <= 'z')
                {
                    check2 = true;
                }
                else if (txt[i] >= 'A' && txt[i] <= 'Z')
                {
                    check3 = true;
                }
            }
            return check1 && check2 && check3;
        }

        static string FirstWord(string str)
        {
            string firstWord = "";
            int index = 0;


            while (index < str.Length && str[index] == ' ')
            {
                index++;
            }
            while (index < str.Length && str[index] != ' ')
            {
                firstWord += str[index];
                index++;
            }
            return firstWord;
        }


        static bool StringMethod1(string str1)
        {
            bool check = false;
            int count = 0;
            if (str1 == null || str1.Length == 0)
            {
                return false;
            }
            bool firstLetter = true;

            foreach (char a in str1)
            {
                if ((a >= 'A' && a <= 'Z') || (a >= 'a' && a <= 'z'))
                {
                    if (firstLetter)
                    {
                        if (a >= 'a' && a <= 'z')
                        {
                            return false;
                        }
                        firstLetter = false;
                    }
                }
                else if (a == ' ')
                {
                    firstLetter = true;
                    count++;
                }
                if (count > 1)
                {
                    return false;
                    break;
                }
            }
            return true;
        }


        static void IntegerArray(ref int[] array, int value)
        {
            int[] arr = new int[array.Length + 1];
            for (int i = 0; i < array.Length; i++)
            {
                arr[i] = array[i];
            }
            arr[arr.Length - 1] = value;
            array = arr;
        }

        static void Task1(ref string sent)
        {
            if(sent == null || sent.Length==0)
            {
                return;
            }
            char[] newWord = sent.ToCharArray();
            int index = 0;
            for(int i = 0;i < newWord.Length;i++)
            {
                if (newWord[i] == ' ')
                {
                    if (i > 0 && newWord[i - 1] != ' ')
                    {
                        newWord[index++] = newWord[i];
                    }
                }
                else
                {
                    newWord[index++] = newWord[i];
                }
               
               sent = new string(newWord,0, index);
            }
        }
    }
}

