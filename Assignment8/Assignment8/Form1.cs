using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment8
{
    public partial class Form1 : Form
    {
        String message = "";
        int size = 57, spamScore = 0;
        int numWords = 0, index = 0;
        double spamRate = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            String temp = "";
            message = emailTextBox.Text.Trim();
            emailTextBox.Text = "";
            spamRate = 0.0;
            spamScore = 0;
            numWords = 0;
            index = 0;

            scoreTextBox.Visible = false;
            scoreTextBox.Text = "Likely Hood of Spam: ";

            while (index < message.Length)
            {
                while (index < message.Length && !Char.IsWhiteSpace(message[index]))
                    index++;
                numWords++;
                while (index < message.Length && Char.IsWhiteSpace(message[index]))
                    index++;
            }

            foreach(char letter in message)
            {
                if(!Char.IsPunctuation(letter))
                    temp += char.ToLower(letter);
            }
            message = temp;

            String[] words = message.Split();

            for (int j = 0; j < words.Length; j++)
            {
                for (int i = 0; i < size; i++)
                {
                    String phrase = (String)spamWordsListBox.Items[i];
                    String[] tempWords = phrase.Split();

                    if(tempWords.Length > 1)
                    {
                        for (int k = 0; k < tempWords.Length; k++)
                            if (words[j] == tempWords[k])
                            {
                                spamScore++;
                                break;
                            }
                    }

                    if (words[j] == (String)spamWordsListBox.Items[i])
                    {
                        spamScore++;
                        break;
                    }
                }
            }

            scannedTextBox.Visible = true;
            spamRate = (spamScore / numWords) * 100;
            scoreTextBox.Text += "\r\n" + spamRate + "%.";
            scoreTextBox.Visible = true;
        }

        private void spamWordAddButton_Click(object sender, EventArgs e)
        {
            String temp = "";

            foreach (char letter in addTextBox.Text)
                temp += char.ToLower(letter);
            spamWordsListBox.Items.Add(temp);
            size++;
            addTextBox.Text = "";
        }

    }
}
