namespace GuessingGameGUI
{
    public partial class frmGuessingGame : Form {
        // Set global variables
        int correctNumber = 0;
        int numbersRemaining = 0;
        int incorrectGuesses = 0;

        public frmGuessingGame() { InitializeComponent(); } // end method
                                                            
        // event handler to end the application
        private void mnuFileExit_Click(object sender, EventArgs e) { Application.Exit(); } // end method

        // event handler to start a new game
        private void mnuFileNewGame_Click(object sender, EventArgs e) {           
            lstGameNumbers.Items.Clear(); // removes all items from the list
            incorrectGuesses = 0; // reset the amount of incorrect guesses
            // output the incorrect guesses to the correct label
            lblIncorrectGuessesCount.Text = incorrectGuesses.ToString();
            stbOutput.Text = "New Game Has Begun."; // tell the user a new game has begun in the status bar
            frmGuessingGame_Load(sender, e); // call the event handler to load the game again
        } // end method

        // event handler for loading the game
        private void frmGuessingGame_Load(object sender, EventArgs e) {
            // re-enable the listbox enable property
            lstGameNumbers.Enabled = true;
            Random r = new Random(); // instance of the random class
            correctNumber = r.Next(101); // set winning number to random number 1-100
            incorrectGuesses = 0; // reset incorrect guesses to 0
            numbersRemaining = 100; // numbers remaining in the list to the correct lable
            lblNumbersRemainingCount.Text = numbersRemaining.ToString();
            // set local variables
            int start = 1;
            int end = 101;
            int counter = 1;

            /////////////////////////////////////////////////////////////////////////////
            //     Code to set the lixt box up horizontally instead of vertically      //
            /////////////////////////////////////////////////////////////////////////////
            // for loop to add numbers in a horizontal order
            for (int i = start; i < end; i++) {
                // add the number to the list property
                lstGameNumbers.Items.Add(i);

                // if i is equal to 100, break out of the for loop
                if (i == 100) { break; }                   
                // if i is not equal to 100, keep running the loop
                else { 
                    i += 9;
                    // if i is greater than 90, reset i to the
                    // correct value to start the next column
                    if (i > 90 + counter) { i = counter++; } // end if 
                } // end else if            
            } // end for
            /////////////////////////////////////////////////////////////////////////////

            // add the numbers to the listbox
            //for (int i = start; i <= end; i++) { lstGameNumbers.Items.Add(i); } // end for 
        } // end method

        // event handler for clicking a number in the listbox
        private void lstGameNumbers_Click(object sender, EventArgs e) {
            
            if (lstGameNumbers.SelectedIndex >= 0) {   
                // set the selected index to a variable
                int selectedIndex = lstGameNumbers.SelectedIndex;
                // check to see if the selected item has been selected already,
                // if it has been selected break out of the method so nothing happens
                string selectedItem = lstGameNumbers.SelectedItem.ToString();
                if (selectedItem == "X") { return; }
                // set the selected item to a variable to test against the winning number
                int selection = int.Parse(selectedItem);                    
                
                // if statement to test the chosen number
                if (selection == correctNumber) {
                    // if selection is the winning number, tell the user and end the game.
                    stbOutput.Text = $"Congratulations, you won with {incorrectGuesses + 1} attempts.";
                    // disable to listbox enabled property
                    lstGameNumbers.Enabled = false;
                } else if (correctNumber < selection) {
                    stbOutput.Text = "Incorrect. The correct number is lower";
                    incorrectGuesses++;
                    numbersRemaining--;
                    lstGameNumbers.Items.Remove(selection);
                    lstGameNumbers.Items.Insert(selectedIndex, "X");
                    
                } else if (correctNumber > selection) {
                    stbOutput.Text = "Incorrect. The correct number is higher";
                    lstGameNumbers.Items.Remove(selection);
                    lstGameNumbers.Items.Insert(selectedIndex, "X");
                    incorrectGuesses++;
                    numbersRemaining--;
                } // end else if 

                lblIncorrectGuessesCount.Text = incorrectGuesses.ToString();
                lblNumbersRemainingCount.Text = numbersRemaining.ToString();

            } // end if
        } // end method
    }// end class
} // end namespace