using System;

namespace HW._07.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = "Test string: for Homework seven, which contains: ten words and three punctuation mark";

            string removeWord = RemoveMeth(text);
            string swapWordStr = SwapMeth(text);
            AmountSym(text);
            string[] sortArr = SortMeth(text);

            Console.WriteLine($"Text with the largest word removed:\n{removeWord}");
            Console.WriteLine("Swap the longest word with the shortest:\n" + swapWordStr);
            Console.WriteLine("Sorted string array:\n" + string.Join(' ', sortArr));
        }

        /// <summary>
        /// Method that removes the longest word from the string
        /// </summary>
        /// <param name="text">Input string</param>
        private static string RemoveMeth(string text)
        {
            string[] tempArr = text.Split(' ');

            Array.Sort(tempArr, new StringComparer());

            string theLongestVal = tempArr[0];
            int lengthValue = text.EndsWith(theLongestVal) ? theLongestVal.Length : theLongestVal.Length + 1;

            return text.Remove(text.IndexOf(theLongestVal), lengthValue).Trim();

            //int startIndex = 0;
            //int maxWordLength = 0;
            //int count = 0;

            //for (int i = 0; i < text.Length; i++)
            //{
            //    bool ifLastChar = (i == text.Length - 1);
            //    if (Char.IsLetterOrDigit(text[i]))
            //    {
            //        count++;
            //    }
            //    if (Char.IsWhiteSpace(text[i]) || ifLastChar)
            //    {
            //        if (maxWordLength < count)
            //        {
            //            maxWordLength = ifLastChar ? count : ++count;
            //            startIndex = ifLastChar ? i - --count : i - count;
            //        }
            //        count = 0;
            //    }
            //}

            //return text.Remove(startIndex, maxWordLength).Trim();
        }

        /// <summary>
        /// Method that swaps the longest word with the shortest
        /// </summary>
        /// <param name="text">Input string</param>
        private static string SwapMeth(string text)
        {
            string[] tempArr = text.Split(' ');

            Array.Sort(tempArr, new StringComparer());

            string theLongestVal = tempArr[0];
            string theShortestVal = tempArr[tempArr.Length - 1];

            int indexLongVal = text.IndexOf(theLongestVal);
            int indexShortVal = text.IndexOf(theShortestVal);

            if (indexLongVal > indexShortVal)
            {
                return text.Replace(theLongestVal, theShortestVal).
                            Remove(indexShortVal, theShortestVal.Length).
                            Insert(indexShortVal, theLongestVal);
            }
            else
            {
                return text.Replace(theShortestVal, theLongestVal).
                            Remove(indexLongVal, theLongestVal.Length).
                            Insert(indexLongVal, theShortestVal);
            }
        }

        /// <summary>
        /// Method that counts the number of letters and punctuation marks
        /// </summary>
        /// <param name="text">Input string</param>
        private static void AmountSym(string text)
        {
            int numLetter = 0;
            int numPunct = 0;

            for (int i = 0; i < text.Length; i++)
            {
                if(char.IsLetter(text[i]))
                {
                    numLetter++;
                }
                else if (char.IsPunctuation(text[i]))
                {
                    numPunct++;
                }
            }

            Console.WriteLine($"The number of letters in this line: {numLetter.ToString()}");
            Console.WriteLine($"The number of punctuation characters in this line: {numPunct.ToString()}");
        }

        /// <summary>
        /// Method that sorts the array by length
        /// </summary>
        /// <param name="text">Input string</param>
        private static string[] SortMeth(string text)
        {
            string[] textArr = text.Split(' ');

            Array.Sort(textArr, new StringComparer());
            return textArr;
        }
    }
}