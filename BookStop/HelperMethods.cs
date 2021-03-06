﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace _BookStop
{
    class HelperMethods
    {
        //Checks if input is a valid isbn 10
        public bool CheckIsbn10(string text)
        {
            //Init variables
            int count = 10;
            double total = 0;

            //If input contains ax 'X'
            if (text.Substring(text.Length - 1).Equals("x", StringComparison.InvariantCultureIgnoreCase))
            {
                //Format text
                text = text.Replace((text.Length - 1).ToString(), "1");
            }

            //If isbn ins't 10 digits
            if (text.Length != 10)
            {
                return false;
            }

            //Calculate isbn validity
            foreach (char num in text)
            {
                total += char.GetNumericValue(num) * count;
                count--;
            }

            //Check
            if (total % 11 == 0)
            {
                return true;
            }

            return false;
        }

        //Checks if input is a valid isbn 13
        public bool CheckIsbn13(string text)
        {
            //Init variables
            int count = 1;
            double total = 0;
            int checkDigit = 0;

            //Check isbn length
            if (text.Length != 13)
            {
                return false;
            }

            //If isbn doesn't end with X
            if (!text.Substring(text.Length - 1).Equals("x", StringComparison.InvariantCultureIgnoreCase))
            {
                //Grab last digit
                checkDigit = Convert.ToInt32(text.Substring(text.Length - 1));
            }

            //Remove last digit
            text = text.TrimEnd(Convert.ToChar(text.Substring(text.Length - 1)));

            //Calculate isbn validity
            foreach (char num in text)
            {
                //If the number is even
                if (count % 2 == 0)
                {
                    total += char.GetNumericValue(num) * 3;
                    count++;
                }
                else
                {
                    total += char.GetNumericValue(num);
                    count++;
                }
            }

            total %= 10;

            //Check
            if (total == 0)
            {
                return true;
            }
            else if (10 - total == checkDigit)
            {
                return true;
            }

            return false;
        }

        //Write data to end of file specified
        public void WriteDataToEnd(string filePath, string data)
        {
            //Write to end of file
            using (StreamWriter report = new StreamWriter(filePath, true))
            {
                //Write
                report.WriteLine(data);
            }
        }

        //Read the last data entry of file specified
        public string ReadEndData(string filePath)
        {
            //Init variables
            string line = "";

            //Read end of file
            using (StreamReader report = new StreamReader(filePath))
            {
                //Go to the end of the file
                while (report.EndOfStream == false)
                {
                    //Read
                    line = report.ReadLine();
                }
            }

            return line;
        }

        //Reads whole file specified
        public string ReadWholeFile(string filePath)
        {
            //Init variables
            string data = "";

            //Read wholefile
            using (StreamReader reader = new StreamReader(filePath))
            {
                //Read
                data = reader.ReadToEnd();
            }

            return data;
        }

        //Checks to see if there is data in the report specified
        public bool CheckForData(string filePath)
        {
            //Init variables
            string check = ReadWholeFile(filePath);

            //Check
            if (check == "")
            {
                return false;
            }

            return true;
        }

        //Displays error message
        public void DisplayErrorMessage(Exception ex)
        {
            //Display error message
            MessageBox.Show("The was a problem. Please try again. Error message: " + ex.Message,
                "Error: " + ex.HResult,
                MessageBoxButtons.OK);
        }

        //Formats the vendor's name
        public string FixVendorName(string name)
        {
            //Trim the name
            name = name.Replace("offers.", "");
            name = name.Replace("_bb", "");

            //Reformat name
            if(name == "textbooksrus")
            {
                name = "Textbooks-R-Us";
            }
            else if(name == "abebooks")
            {
                name = "Abe Books";
            }
            else if (name == "amazon")
            {
                name = "Amazon";
            }
            else if (name == "bookbyte")
            {
                name = "Book Byte";
            }
            else if (name == "booksrun")
            {
                name = "Books Run";
            }
            else if (name == "buyback101")
            {
                name = "BuyBack101.com";
            }
            else if (name == "ecampus")
            {
                name = "eCampus.com";
            }
            else if (name == "mybookcart")
            {
                name = "myBookCart.com";
            }
            else if (name == "textbookmaniac")
            {
                name = "Textbook Maniac";
            }
            else if (name == "valorebooks")
            {
                name = "Valor Books";
            }

            return name;
        }

        public void SortDataInFile(string filePath, List<string> list)
        {
            //Read end of file
            using (StreamReader report = new StreamReader(filePath))
            {
                //Go to the end of the file
                while (report.EndOfStream == false)
                {
                    //Read
                    string line = report.ReadLine();

                    list.Add(line);
                }
            }

            //Remove blank spaces from list
            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (list[i] == "")
                {
                    list.Remove(list[i]);
                }
            }

            //Delete file
            File.WriteAllText(filePath, "");

            //Alphabatize
            list.Sort();

            //Rewrite data
            foreach (string item in list)
            {
                WriteDataToEnd(filePath, item);
                WriteDataToEnd(filePath, "");
            }

            //Delete list
            list.Clear();
        }
    }
}