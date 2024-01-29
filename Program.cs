using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
   
    class Program
    {
       
        static void Main(string[] args)
        {
            //var test = new List<SET_EXAM_SUBJECT>
            //{
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=4},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=1},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=2},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=1},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=3},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=2},
            //    new SET_EXAM_SUBJECT{SUBJECT_ID=4}
            //};
            //var sub_1 = test.Where(c => c.SUBJECT_ID == 1).FirstOrDefault();
            //var sub_2 = test.Select(c => c.SUBJECT_ID == 1).FirstOrDefault();
            //var sub_3 = test.Select(c => c.SUBJECT_ID == 4).FirstOrDefault()!=null;
            //Console.WriteLine("Hello World!");

            //userMaincode maincode = new userMaincode();

            //------------------------------------------------
            //----------------Leetcode problem 234
            //string vowels = userMaincode.findVowelcount("acdeiou");
            //Console.WriteLine("Hello World! "+ vowels);
            //Console.ReadKey();

            //-----------------------------------------------------------

            //LeetCodeProblem383 codeProblem383 = new LeetCodeProblem383();
            //bool isMatched = codeProblem383.CanConstruct("aa","aab");
            //Console.WriteLine("Hello World! " + isMatched);
            //------------Leetcode problem 413-----------------------------
            //LeetCode_413 codeProblem383 = new LeetCode_413();
            //int result = codeProblem383.NumberOfArithmeticSlices(new int[] {1,2,3,4});
            //Console.WriteLine("Hello World! " + result);

            //===============================================================
            //GoogleInterviewQuestion_3 cls = new GoogleInterviewQuestion_3();
            //string str = "geeksforgeeks";
            //Console.WriteLine("The input string is " + str);

            //int len = cls.longestUniqueSubsttr(str);

            //Console.WriteLine("The length of the longest " +
            //                  "non-repeating character " +
            //                  "substring is " + len);

            //===============================================================
            ////int[] nums1 =new int[] { 1, 2 }, nums2 = new int[] { 3, 4 };
            //int[] nums1 = new int[] { 1, 3}, nums2 = new int[] { 2};
            //LeetCodeProblem_4_MedianOfTwoSortedArrays problem4 = new LeetCodeProblem_4_MedianOfTwoSortedArrays();
            //double result= problem4.FindMedianSortedArrays(nums1, nums2);
            // Console.WriteLine("Median of two sorted array is " + result);

            ////======================LeetCode_552_Student_Attendance_Record_II=========================================
            //LeetCode_552_Student_Attendance_Record_II _552 = new LeetCode_552_Student_Attendance_Record_II();
            //var result = _552.CheckRecord(10);
            //Console.WriteLine("Student attendance record- " + result);

            //// =======================LeetCode_332_CoinChange_And_518_CoinChange2=======================================
            //LeetCode_332_CoinChange_And_518_CoinChange2 _332 = new LeetCode_332_CoinChange_And_518_CoinChange2();
            //int[] coins=new int[4] {1,3,4,5};
            //var result = _332.CoinChange(coins, 7);

            //LengthOfLongestSubstring lengthOfLongestSubstring = new LengthOfLongestSubstring();
            //string str = "ShahanazSultana";
            //var result = lengthOfLongestSubstring.lengthOfLongestSubstring(str);
            //Console.WriteLine("Length Of Longest Substring- " + result);

            //FindMedianSortedArrays findMedianSortedArrays = new FindMedianSortedArrays(); 
            //int[] arr1= { 1, 2, 4, 6, 8, 9, 12 };
            //int[] arr2 = { 1, 3, 5, 7, 9, 11, 14, 17, 23,31 };
            //var result = findMedianSortedArrays.FindMedianSortedArrays2(arr1, arr2);
            //Console.WriteLine("Median of Two sorted arrays: "+result);

            //LongestPalindrome longestPalindrome = new LongestPalindrome();
            //string palindromStr = "abccbadefgehijkjiheg";
            //var result= longestPalindrome.LongestPalindrome2( palindromStr );
            //Console.WriteLine("Median of Two sorted arrays: " + result );

            //_006_ZigZagConversion _ZigZagConversion=new _006_ZigZagConversion();
            //string str = "SHAHANAZSULTANA";
            //int rowNumber = 4;
            //var result = _ZigZagConversion.Convert(str, rowNumber);
            //Console.WriteLine("Zigzag conversion: " + result);

            //ReverseInteger reverseInteger= new ReverseInteger();
            //int val =123456789;
            //var result= reverseInteger.Reverse(val);
            //Console.WriteLine("Reverse of an Integer: " + result);

            //String_To_Integer_Atoi string_To_Integer=new String_To_Integer_Atoi();
            //string str = "-3478657 ";
            //var result= string_To_Integer.ConvertStringToIntegerAtoi(str);
            //Console.WriteLine("Converted String to Integer: " + result);

            //PalindromeNumber palindromeNumber = new PalindromeNumber();
            //int number = 345676743;
            //var result = palindromeNumber.IsPalindrome2(number);
            //Console.WriteLine("Number is palindrom: "+result);

            //RegularExpressionMatching_10 regularExpression=new RegularExpressionMatching_10();
            ////string str = "abcdefg";
            //string str = "ab";
            //// string regEx = "abc.*";
            //// string regEx = "abc.";
            //// string regEx = "abc";
            //string regEx = ".*";
            //var result = regularExpression.IsMatch(str, regEx);
            //Console.WriteLine("Regular expression wise matching found: "+result);


            ContainerWithMostWater containerWithMostWater = new ContainerWithMostWater();
            int[] containerCoordinates = new int[] { 1, 8, 6, 2, 5, 4, 8, 3, 7 };
            var result= containerWithMostWater.MaxArea(containerCoordinates);
            Console.WriteLine("Container length with most water: "+result);

            Console.ReadKey();

        }

    }
}
