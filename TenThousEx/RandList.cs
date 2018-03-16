using System;
using System.Linq;
using System.IO;

namespace TenThousEx
{
    class RandList
    {
        //Default Number Vars
        private int lowRangeNumber = 1;
        private int highRangeNumber = 10000;

        //GETTER/SETTERS for number vars
        public int LowRangeNumber
        {
            get { return lowRangeNumber; }
            set { lowRangeNumber = value; }
        }

        public int HighRangeNumber
        {
            get { return highRangeNumber; }
            set { highRangeNumber = value; }
        }

        //runner operates then process of creating a file containing the user requested number list
        public int Runner(int optionInclusiveExclusive)
        {
            int totalNums;
            int[] numsArray = null;

            if (optionInclusiveExclusive == 0)
            {
                totalNums = HighRangeNumber - LowRangeNumber + 1;
                numsArray = generateArrayNumbers(LowRangeNumber, HighRangeNumber, totalNums);
            }
            else if (optionInclusiveExclusive == 1)
            {
                totalNums = HighRangeNumber - LowRangeNumber - 1;
                numsArray = generateArrayNumbers(LowRangeNumber + 1, HighRangeNumber - 1, totalNums);
            }
            else
            {
                Console.WriteLine("INVALID OPTION SELECTED");
            }
            //int totalNums = HighRangeNumber - LowRangeNumber + 1; //total distinct numbers expected (INCLUSIVE)

           
            //writeToConsole(numsArray); //debug check on creating list
            int[] shuffledArray = shuffleArray(numsArray);
            //writeToConsole(shuffledArray);
            writeToTextFile(shuffledArray);

            //Console.WriteLine(shuffledArray.Distinct().Count() == totalNums);//ensure list is complete and each number unique
            //Console.WriteLine("Press any key to exit");
            //Console.ReadKey();
            return 1;
        }

        private void writeToConsole(int[] array)
        {
            int count = 0;
            foreach (int number in array)
            {
                count++;
                Console.WriteLine("Line {0}: {1}", count, number);
            }
        }

        private void writeToTextFile(int[] array)
        {
            Console.WriteLine("WRITE TO FILE BEGINNING");
            //SAVE RESULT TO FILE WITH RANDOM ID NAME .TXT -> DESKTOP
            string stringPathDesktop = Environment.GetFolderPath(System.Environment.SpecialFolder.DesktopDirectory);
            string fullPathFile = stringPathDesktop + "\\result_" + DateTime.Now.ToString("yyyy-MM-ddTHH.mm.ss") + ".txt";

            FileStream fs = new FileStream(fullPathFile, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fs);

            int count = 0;
            foreach (int number in array)
            {
                count++;
                writer.WriteLine("Line {0}: {1}", count, number);
            }
            writer.Flush();
            writer.Close();
            Console.WriteLine("WRITE TO FILE END");
        }

        //generate list of numbers in order, given numbers for range -> returns array of that size
        private int[] generateArrayNumbers(int lowRange, int highRange, int totalEntries)
        {
            Console.WriteLine("BEGINNING LIST GENERATION");
            int[] numsArray = new int[totalEntries];
            int startPoint = lowRange;

            for (int index = 0; lowRange < highRange + 1; index++, lowRange++)
            {
                numsArray[index] = lowRange;
            }

            Console.WriteLine("LIST GENERATION ENDED");
            return numsArray;
        }

        //fisher-yates shuffle
        private int[] shuffleArray(int[] arrayUnshuffledNumbers)
        {
            Console.WriteLine("SHUFFLE BEGINNING");
            Random rng = new Random(); //pseudo-random for simplicity

            for (int index = arrayUnshuffledNumbers.Length - 1; index > 0; index--)
            {
                int swapIndex = rng.Next(index + 1);
                int numberHolder = arrayUnshuffledNumbers[index];
                arrayUnshuffledNumbers[index] = arrayUnshuffledNumbers[swapIndex];
                arrayUnshuffledNumbers[swapIndex] = numberHolder;
            }

            Console.WriteLine("SHUFFLE ENDED");
            return arrayUnshuffledNumbers; 
        }
    }
}
