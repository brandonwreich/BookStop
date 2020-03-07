using System;
using System.IO;
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
            //Write to file
            using (StreamWriter report = new StreamWriter(filePath, true))
            {
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
            MessageBox.Show("The was a problem. Please try again. Error message: " + ex.Message,
                "Error: " + ex.HResult,
                MessageBoxButtons.OK);
        }
    }
}