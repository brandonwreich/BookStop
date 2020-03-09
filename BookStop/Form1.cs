using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace _BookStop
{
    #region Data

    //Valid, Found
    //9780538493635
    //0815142331
    //0133405184

    //Valid, Not Found
    //007462542X

    //Invalid
    //0112112425

    #endregion

    public partial class MainPage : Form
    {
        //Init variables
        readonly string path = @Directory.GetParent(Environment.CurrentDirectory).Parent.FullName.ToString() + "\\BookReport.txt";
        readonly HelperMethods methHelps = new HelperMethods();

        public MainPage()
        {
            //Init elements
            InitializeComponent();

            //Set preferences
            this.AcceptButton = enterButton;
            this.BackColor = Color.Cyan;
            this.MaximizeBox = false;

            //Focus on input textbox
            inputTextbox.Focus();
        }

        #region Buttons

        //When the enter button is clicked then it compares the book isbn
        private async void EnterButton_ClickAsync(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Init variables
                string text = inputTextbox.Text;

                //Limit only valid isbns
                if (!methHelps.CheckIsbn10(text) && !methHelps.CheckIsbn13(text))
                {
                    throw new Exception("Please enter a valid isbn");
                }
                else
                {
                    //Init variables
                    var isbn = text.Trim();
                    decimal highestOffer = 0;
                    string bookTitle = "";
                    string vendorName = "";

                    var httpClient = new HttpClient();
                    httpClient.DefaultRequestHeaders.Add("authority", "www.bookfinder.com");
                    var response3 = await httpClient.GetAsync($"https://www.bookfinder.com/buyback/affiliate/{isbn}.mhtml");
                    var raw3 = await response3.Content.ReadAsStringAsync();

                    //If connection is made
                    if (response3.IsSuccessStatusCode)
                    {
                        //Init variables
                        var jobject = JObject.Parse(raw3);
                        bookTitle = jobject.GetValue("title").ToString();
                        var offers = jobject.GetValue("offers");
                        var test1 = offers.Children();

                        //Loop through buyback offers
                        foreach (var child in offers.Children().ToList())
                        {
                            //Init variables
                            var test = child.Children().FirstOrDefault();

                            //If offer is greater than highestOffer
                            if (test.Value<decimal>("buyback") == 1 && test.Value<decimal>("offer") > highestOffer)
                            {
                                //Set highesOffer
                                highestOffer = test.Value<decimal>("offer");

                                //Fix vendor name
                                vendorName = methHelps.FixVendorName(child.Path);
                            }
                        }
                    }

                    //If book wasn't found
                    if (bookTitle.Equals("") && highestOffer == 0)
                    {
                        //Display alert
                        MessageBox.Show("Isbn " + isbn + " wasn't found. Please try again!", "Data Error", MessageBoxButtons.OK);

                        //Clear data
                        ClearButton_Click(sender, e);
                    }
                    else
                    {
                        //Set the textboxes
                        titleTextbox.Text = bookTitle;
                        vendorTextbox.Text = vendorName;
                        isbnTextbox.Text = isbn;
                        buybackOfferTextbox.Text = highestOffer.ToString();

                        //If priceTextbox is empty
                        if (ourPriceTextbox.Text.Equals(""))
                        {
                            //Set text
                            ourPriceTextbox.Text = "0.00";
                        }

                        //Format priceTextbox
                        decimal ourPrice = Convert.ToDecimal(ourPriceTextbox.Text);

                        //If book makes profit
                        if (highestOffer > ourPrice)
                        {
                            //Change background to green
                            this.BackColor = Color.Green;
                        }
                        else
                        {
                            //Change background to red
                            this.BackColor = Color.Red;
                        }
                    }

                    //Reset input textbox
                    inputTextbox.Text = "";

                    //Set focus to input textbox
                    inputTextbox.Focus();
                }
            }
            catch (Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);

                //Clear data
                ClearButton_Click(sender, e);
            }

            //Reset Cursor
            Cursor.Current = Cursors.Default;
        }

        //When clear button is clicked it clears all of the fields
        private void ClearButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Clear all text
                titleTextbox.Text = "";
                vendorTextbox.Text = "";
                isbnTextbox.Text = "";
                buybackOfferTextbox.Text = "";
                notesTextbox.Text = "";
                inputTextbox.Text = "";

                //Reset rectangle color
                this.BackColor = Color.Cyan;

                //Set focus to input textbox
                inputTextbox.Focus();
            }
            catch(Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset cursor
            Cursor.Current = Cursors.Default;
        }

        //Shows the report to the user
        private void ViewReportButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //If report is empty
                if (!methHelps.CheckForData(path))
                {
                    //Display error message
                    MessageBox.Show("There is no data to in the report. Please enter an isbn", "Data Error", MessageBoxButtons.OK);
                }
                else
                {
                    //Open the report
                    Process.Start(path);
                }
            }
            catch (Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset cursor
            Cursor.Current = Cursors.Default;
        }

        //Adds the book to the report
        private void AddButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Check that there is data
                if (isbnTextbox.Text == "" && titleTextbox.Text == "" && vendorTextbox.Text == "")
                {
                    //Display error message
                    MessageBox.Show("There is no data to enter. Please enter an isbn", "Data Error", MessageBoxButtons.OK);
                }
                else
                {
                    //Build result
                    string result = $"Vendor: {vendorTextbox.Text}, " +
                        $"Title: {titleTextbox.Text}, " +
                        $"ISBN: {isbnTextbox.Text}, " +
                        $"Company: {vendorTextbox.Text}, " +
                        $"Offer: {buybackOfferTextbox.Text}";

                    //Write to file
                    methHelps.WriteDataToEnd(path, result);

                    //Check data writes
                    string check = methHelps.ReadEndData(path);

                    //If the last line isn't the result
                    if (check != result)
                    {
                        throw new Exception("Data did not show in the report");
                    }

                    //Display confirmation message
                    MessageBox.Show("Book successfully added to the report", "Success", MessageBoxButtons.OK);

                    //Format
                    methHelps.WriteDataToEnd(path, "");
                }
            }
            catch (Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset cursor
            Cursor.Current = Cursors.Default;
        }

        //When the exit button is clicked it exits the program
        private void ExitButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Close the program
                Close();
            }
            catch(Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }
        }

        //When the delete button is clicked it deletes all the content in the report
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Display confirmation message
                DialogResult result = MessageBox.Show("Are you sure you want to delete the report?", "Confirmation", MessageBoxButtons.YesNo);

                //If the user presses yes
                if (result == DialogResult.Yes)
                {
                    //Replace all text with spaces
                    File.WriteAllText(path, "");

                    //Check
                    string check = File.ReadAllText(path);

                    //If text doesn't delete
                    if (check != "")
                    {
                        throw new Exception("Data was not completely deleted");
                    }

                    //Show confirmation
                    MessageBox.Show("Report successfully deleted", "Success", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset cursor
            Cursor.Current = Cursors.Default;
        }

        //When the downlad button is clicked it saves the report to the desktop and launchs it
        private void DownloadButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Check that there is data
                if (!methHelps.CheckForData(path))
                {
                    //Display error message
                    MessageBox.Show("There is no data to in the report. Please enter an isbn", "Data Error", MessageBoxButtons.OK);
                }
                else
                {
                    //Init varibles
                    var desktopFolder = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                    var savePath = Path.Combine(desktopFolder, $"BookReport({DateTime.Now.ToString("ddMMMMyyyy hh.mm.ss")}).txt");

                    //Save
                    File.Copy(path, savePath);

                    //Display success message
                    MessageBox.Show("File successfuly saved", "Success", MessageBoxButtons.OK);

                    //Launch report
                    Process.Start(savePath);
                }
            }
            catch(Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset cursor
            Cursor.Current = Cursors.Default;
        }

        //Prints the report using the default printer
        private void PrintButton_Click(object sender, EventArgs e)
        {
            //Set cursor
            Cursor.Current = Cursors.WaitCursor;

            try
            {
                //Check that there is data
                if (!methHelps.CheckForData(path))
                {
                    //Display error message
                    MessageBox.Show("There is no data to in the report. Please enter an isbn");
                }
                else
                {
                    //Init variables
                    ProcessStartInfo info = new ProcessStartInfo
                    {
                        Verb = "print",
                        FileName = path,
                        CreateNoWindow = true,
                        WindowStyle = ProcessWindowStyle.Hidden
                    };

                    Process print = new Process
                    {
                        StartInfo = info
                    };

                    //Print
                    print.Start();

                    //Close printer when done
                    print.WaitForInputIdle();
                    System.Threading.Thread.Sleep(3000);
                    print.Kill();
                }
            }
            catch(Exception ex)
            {
                //Display error message
                methHelps.DisplayErrorMessage(ex);
            }

            //Reset Cursor
            Cursor.Current = Cursors.Default;
        }

        #endregion

        #region Textboxes

        //Limits ourPrice textbox to only accept numbers and one decimal
        private void OurPriceTextbox_TextChanged(object sender, EventArgs e)
        {
            //Init variables
            bool enteredLetter = false;
            bool isDecimal = false;
            Queue<char> text = new Queue<char>();

            //Loop through input text
            foreach (char ch in ourPriceTextbox.Text)
            {
                //If there isn't a decimal
                if (!isDecimal)
                {
                    //If its a number or decimal
                    if (char.IsDigit(ch) || Equals(ch.ToString(), "."))
                    {
                        //If the input includes a decimal
                        if (Equals(ch.ToString(), "."))
                        {
                            isDecimal = true;
                        }

                        //Add to text
                        text.Enqueue(ch);
                    }
                    else
                    {
                        enteredLetter = true;
                    }
                }
                else
                {
                    //If its a number
                    if (char.IsDigit(ch))
                    {
                        //Add to text
                        text.Enqueue(ch);
                    }
                    else
                    {
                        enteredLetter = true;
                    }
                }
            }

            //If you entered a letter
            if (enteredLetter)
            {
                //Init variables
                StringBuilder sb = new StringBuilder();

                //While count is above 0
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                //Set text
                ourPriceTextbox.Text = sb.ToString();
                ourPriceTextbox.SelectionStart = ourPriceTextbox.Text.Length;
            }
        }

        //Limits input textbot to accept only numbers
        private void InputTextbox_TextChanged(object sender, EventArgs e)
        {
            //Init variables
            bool enteredLetter = false;
            Queue<char> text = new Queue<char>();

            //Loop through input text
            foreach (char ch in inputTextbox.Text)
            {
                //If its a number
                if (char.IsDigit(ch) || ch.Equals('x') || ch.Equals('X'))
                {
                    //Add to text
                    text.Enqueue(ch);
                }
                else
                {
                    enteredLetter = true;
                }
            }

            //If you entered a letter
            if (enteredLetter)
            {
                //Init variables
                StringBuilder sb = new StringBuilder();

                //While count is above 0
                while (text.Count > 0)
                {
                    sb.Append(text.Dequeue());
                }

                //Set text
                inputTextbox.Text = sb.ToString();
                inputTextbox.SelectionStart = inputTextbox.Text.Length;
            }
        }

        #endregion
    }
}