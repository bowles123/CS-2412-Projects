// Brian Bowles, Assignment 6, February 19, 2015.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment6
{
    public partial class typingTutorForm : Form
    {
        // Private attributes.
        private const int NUM_SENTENCES = 11;
        private const int NUM_KEYS = 41;
        private int correct = 0;
        private int incorrect = 0;
        private int initial = 0;
        private int counter = 0;
        private List<char> hardKeys = new List<char>();
        private String[] sentences = new String[NUM_SENTENCES];
        private String currentSentence;

        // Initialize the elements of the sentences array.
        public typingTutorForm()
        {
            InitializeComponent();
            virtualKeyboardGroupBox.Focus();
            sentences[0] = "A typed word is counted as any five keystrokes.";
            sentences[1] = "Do not stop to correct your errors in these first tests but check them out.";
            sentences[2] = "The beautiful scenic country of New Zealand is situated in the South Pacific to the east of Australia.";
            sentences[3] = "The ferry crosses Cook Strait and cruises beautiful Queen Charlotte Sounds between Wellington, NZ's "
                + "Capital City, and Picton.";
            sentences[4] = "NZ's East Coast has many stretches of white sand and rolling surf which attract NZ and overseas surfers. "
                + "They are popular NZ family holiday places.";
            sentences[5] = "New Zealand is a land of contrasts, which attract thousands of overseas tourists every year to climb, ski "
                + "or snowboard our mountains, swim, fish or cruise on our lakes and rivers.";
            sentences[6] = "Between The Southern Alps and the West Coast is a fantastic scenic drive taking the Haast Pass road. Here "
                + "is our great rain forest. Most overseas and local tours include this route in their Itinerary.";
            sentences[7] = "New Zealand is a very sport oriented country and sometimes hosts world events. Sports include tennis, golf,"
                + " yachting, canoeing, cruising, cricket, soccer, rugby, basketball, netball, swimming, surf lifesaving, athletics, and riding.";
            sentences[8] = "Watching events where they take place is fine but many can only watch at home as the event is screened on "
                + "our TVs. New Zealand is proud too of our sporting participants who have entered and gained medals in many sporting events "
                + "including Olympic Games.";
            sentences[9] = "Masters' Games are very popular in New Zealand as in many other countries and NZ swimmers were really proud in the "
                + "year 2002 to host the FINA World Masters Swimming Champs at Christchurch in the South Island, at which I gained 10th place medals" 
                + " for 100 m and 200 m backstroke.";
            sentences[10] = "Some challenging events which draw overseas sports people include the annual Coast to Coast involving running, "
                + "cycling and kayaking from the West Coast, through mountain passes to the East Coast, and the Iron Man including running, cycling,"
                + " and swimming. I am proud one of my sons twice took part in the Ironman.";
        }

        // Clears the text in the typing text box.
        private void clearTypingText()
        {
            typingTextBox.Text = "";
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            clearTypingText();

            // If the user is on the last sentence then display the 
            // Correct, incorrect, and struggling with information.
            if (initial == 10)
            {
                sentenceTextBox.Text = sentences[initial];
                nextButton.Visible = false;

                correctTextBox.Text += Convert.ToString(correct);
                incorrectTextBox.Text += Convert.ToString(incorrect);
                hardKeys.Sort();
                
                foreach(char c in hardKeys)
                {
                    String text = c + ", ";
                    strugglingTextBox.Text += text;
                }

                correctTextBox.Visible = true;
                incorrectTextBox.Visible = true;
                strugglingTextBox.Visible = true;
            }
            else
            {
                initial++;
                sentenceTextBox.Text = sentences[initial];
            }
            counter = 0;
            virtualKeyboardGroupBox.Focus();
        }

        private void typingTutorForm_KeyUp(object sender, KeyEventArgs e)
        {
            char pressed = (char)e.KeyCode;

            if (!e.Shift)
            {
                virtualKeyboardGroupBox.Focus();
                virtualKeyboardGroupBox.Focus();
            }

            if (e.KeyCode == Keys.OemPeriod)
                virtualKeyboardGroupBox.Focus();
            else
                if (e.KeyCode == Keys.Oemcomma)
                    virtualKeyboardGroupBox.Focus();
                else
                    if (e.KeyCode == Keys.OemSemicolon)
                        virtualKeyboardGroupBox.Focus();
                    else
                        if (e.KeyCode == Keys.Space)
                            virtualKeyboardGroupBox.Focus();
                        else
                            if (e.KeyCode == Keys.OemQuotes)
                                virtualKeyboardGroupBox.Focus();
                            else
                                if (e.KeyCode == Keys.Back)
                                    virtualKeyboardGroupBox.Focus();

            switch (pressed)
            {
                case 'A':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'B':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'C':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'D':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'E':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'F':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'G':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'H':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'I':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'J':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'K':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'L':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'M':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'N':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'O':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'P':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'Q':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'R':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'S':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'T':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'U':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'V':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'W':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'X':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'Y':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case 'Z':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '1':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '2':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '3':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '4':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '5':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '6':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '7':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '8':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '9':
                    virtualKeyboardGroupBox.Focus();
                    break;
                case '0':
                    virtualKeyboardGroupBox.Focus();
                    break;
            }

        }

        private void typingTutorForm_KeyPress(object sender, KeyPressEventArgs e)
         {
            String currentText = typingTextBox.Text;
            typingTextBox.Text += e.KeyChar;
            currentSentence = sentences[initial];

            if (e.KeyChar == (char)Keys.Back && currentText.Length > 0)
            {
                --counter;
                incorrect--;
                typingTextBox.Text = currentText.Remove(currentText.Length - 1);
            }
            else
            {
                if (counter >= currentSentence.Length)
                    counter--;
                if (currentSentence[counter++] == e.KeyChar)
                    correct++;
                else
                {
                    incorrect++;
                    hardKeys.Add(e.KeyChar);
                }
            }
        }

        private void typingTutorForm_KeyDown(object sender, KeyEventArgs e)
        {
            char pressed = (char)e.KeyCode;

            if (e.Shift)
            {
                shiftLeftButton.Focus();
                shiftRightButton.Focus();
            }

            if (e.KeyCode == Keys.OemPeriod)
                periodButton.Focus();
            else
                if (e.KeyCode == Keys.Oemcomma)
                    commaButton.Focus();
                else
                    if (e.KeyCode == Keys.OemSemicolon)
                        semicolonButton.Focus();
                    else
                        if (e.KeyCode == Keys.Space)
                            spaceButton.Focus();
                        else
                            if (e.KeyCode == Keys.OemQuotes)
                                apostropheButton.Focus();
                            else
                                if (e.KeyCode == Keys.Back)
                                    backspaceButton.Focus();

            switch(pressed)
            {
                case 'A':
                    aButton.Focus();
                    break;
                case 'B':
                    bButton.Focus();
                    break;
                case 'C':
                    cButton.Focus();
                    break;
                case 'D':
                    dButton.Focus();
                    break;
                case 'E':
                    eButton.Focus();
                    break;
                case 'F':
                    fButton.Focus();
                    break;
                case 'G':
                    gButton.Focus();
                    break;
                case 'H':
                    hButton.Focus();
                    break;
                case 'I':
                    iButton.Focus();
                    break;
                case 'J':
                    jButton.Focus();
                    break;
                case 'K':
                    kButton.Focus();
                    break;
                case 'L':
                    lButton.Focus();
                    break;
                case 'M':
                    mButton.Focus();
                    break;
                case 'N':
                    nButton.Focus();
                    break;
                case 'O':
                    oButton.Focus();
                    break;
                case 'P':
                    pButton.Focus();
                    break;
                case 'Q':
                    qButton.Focus();
                    break;
                case 'R':
                    rButton.Focus();
                    break;
                case 'S':
                    sButton.Focus();
                    break;
                case 'T':
                    tButton.Focus();
                    break;
                case 'U':
                    uButton.Focus();
                    break;
                case 'V':
                    vButton.Focus();
                    break;
                case 'W':
                    wButton.Focus();
                    break;
                case 'X':
                    xButton.Focus();
                    break;
                case 'Y':
                    yButton.Focus();
                    break;
                case 'Z':
                    zButton.Focus();
                    break;
                case '1':
                    oneButton.Focus();
                    break;
                case '2':
                    twoButton.Focus();
                    break;
                case '3':
                    threeButton.Focus();
                    break;
                case '4':
                    fourButton.Focus();
                    break;
                case '5':
                    fiveButton.Focus();
                    break;
                case '6':
                    sixButton.Focus();
                    break;
                case '7':
                    sevenButton.Focus();
                    break;
                case '8':
                    eightButton.Focus();
                    break;
                case '9':
                    nineButton.Focus();
                    break;
                case '0':
                    zeroButton.Focus();
                    break;
            }
        }
    }
}
