using System;

namespace HW10_class_tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
        }

        // task 1  Verilmiş iki ədədi toplayıb nəticəsini qaytaran metod

        static int sum(int num1, int num2) 
        {
         return num1 + num2;
        }

        // task 2  Verilmiş ədədin kvadratını qaytaran metod

        static int kvadrat(int num)
        {
            return num* num;
        }

        // task 3 Verilmiş string dəyərində a hərfinin olub olmadığını qaytaran metod

        static bool hasA (string word)
        {
          bool hasA = false;
         for(int i = 0; i < word.Length; i++)
            {
                if (word[i]=='a')
                {
                    hasA= true;
                    break;
                }
            }
         return hasA;
        }

        // task 4 Verilmiş ədədin rəqəmləri cəmini qaytaran metod
        static int sumOfDigits (int num)
        {
            int sum = 0;
           
            while (num > 0)
            {
                sum += num % 10;
                num = (num - (num % 10)) / 10;
            }
            return sum;
        }

        // task 5 Verilmiş 4 ədədin ortalamasını tapıq qaytaran metod

        static int average (int num1, int num2, int num3, int num4) 
        {
            
            return  (num1 + num2 + num3 + num4) / 4;
        }

        // task 6 Verilmiş ədədin verilmiş qüvvətini tapan metod 

        static int powerOfDigit(int num, int power)
        {
            int result = 1;

            for(int i=0; i < power; i++)
            {
                result *= num;
            }
            return result;
        }

        // task 7  Verilmiş 3 ədəddən ən böyüyünü tapan metod

        static int maxOfDigits(int a, int b, int c)
        {
            int max = 0;
            if(a>b && a>c)
            {
                max = a;
            }
            else if (b>a && b>c)
            {
                max = b;
            }    
            else
            {
                max = c;
            }
            return max;
        }

        // task 8 Verilmiş ədədlər siyahısındaki ədədlərin cəmini tapan metod
        static int sum(int[] nums)
        {
            int result = 0;

            for(int i=0; i<nums.Length;i++)
            {
                result+= nums[i];
            }
            return result;
        }

        // task 9 Verilmiş ədədlər siyahısındaki ən böyük ədədi tapan metod

        static int maxOfArr(int[] nums)
        {
            int max = nums[0];

            for( int i = 0; i<nums.Length;i++)
            {
                if (nums[i]> max)
                {
                    max = nums[i];
                }
            }
            return max;
        }

        // task 10 Verilmiş ədədlər siyahısındaki ən böyük ədədin yerləşdiyi index-i qaytaran metod

        static int indexOfMax(int[] numbers)
        {
            int max = numbers[0];
            int index = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > max)
                {
                    max = numbers[i];
                    index = i;
                }
            }
            return index;
        }

        // task 11 Verilmiş yazılar siyahısındaki (string array) verilmiş yazının yerləşdiyi indexi
        // qaytaran metod.Əgər verilmiş string array-de verilmiş string dəyər yoxdursa -1 qaytarsın

        static int idexOfString (string[] words, string str)
        {
            for(int i = 0; i<words.Length;i++)
            {
                if (words[i] == str)
                {
                    return i;
                }
            }
            return -1;
        }

        // task 12 Verilmiş ədədlər siyahısındaki ədədlərin yalnız müsbət olanlarından ibarət yeni
        // bir array qaytaran metod.Yəni metodu işə salın
        // {4,-5,3,-2,6} ədədlərindən ibarət array göndərsəm metod geriyə {4,3,6} ədədlərindən ibarət array qaytarmalıdır

        static int[] positiveArr(int[] nums)

        {
            int count = 0;
            for(int i=0; i<nums.Length;i++)
            {
                if (nums[i]>0)
                {
                    count++;
                }
            }

            int j = 0;

            int[] positiv= new int[count];

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                {
                    positiv[j] = nums[i];
                    j++;
                }
            }
            return positiv;

        }

        //task 13 Verilmiş yazıda rəqəm olub olmadığını qaytaran metod
        static bool hasDigit(string str)
        {
            char[] chars = { '0', '1', '2','3', '4', '5','6', '7', '8', '9' };

            for(int i=0; i<str.Length;i++)
            {
                if (str[i] == char[i]) 
                {
                    return true;
                }
            }
            return false;
        }

        //task 14 Verilmiş yazılar siyahısında neçə yazıda rəqəm olduğunu qaytaran metod

        static int countOfDigits(string[] text)
        {
            int count = 0;

            for(int i=0; i<text.Length;i++)
            {
                if (hasDigit(text[i]))
                {
                    count++;
                }
            }
            return count;

        }
    }
}
