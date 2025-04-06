using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http;
using System.Threading.Tasks;


namespace FullStackChallenge
{

    public partial class GameForm : Form
    {
        public GameForm()
        {
            InitializeComponent();
        }

        private static readonly HttpClient client = new HttpClient();
        private string apiKey = "jlNxhawUwQxsyyzrfRiZMQ==op1mYDf70grXYgcL";

        int strikeCount = 0;
        string guessedLetters = "";
        string secretWord = "placeholder";
        bool gameOver = false;

        private void updateWordDisplay()
        {
            string display = "";

            foreach (char c in secretWord)
            {
                if (guessedLetters.Contains(c))
                {
                    display += c + " ";
                }
                else
                {
                    display += "_ ";
                }
            }

            lblWordDisplay.Text = display.Trim();
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
            if (gameOver)
                return;

            string input = txtGuess.Text.ToLower();
            txtGuess.Text = "";

            if (input.Length != 1 || !char.IsLetter(input[0]) || guessedLetters.Contains(input))
            {
                MessageBox.Show("Enter a single (unused) letter");
                return;
            }

            char guess = input[0];
            guessedLetters += guess;

            if (secretWord.Contains(guess))
            {
                lblCorrectLetters.Text += guess + " ";
            }
            else
            {
                strikeCount++;
                lblWrongLetters.Text += guess + " ";
                lblStrikes.Text = $"Strikes: {strikeCount}/7";
            }

            updateWordDisplay();

            if (strikeCount == 7)
            {
                MessageBox.Show($"You lost! The word was: {secretWord}");
                gameOver = true;
                return;
            }

            if (!lblWordDisplay.Text.Contains("_"))
            {
                MessageBox.Show("You guessed the word!");
                gameOver = true;
                return;
            }
        }
        private async Task LoadRandomWord()
        {
            client.DefaultRequestHeaders.Clear();
            client.DefaultRequestHeaders.Add("X-Api-Key", apiKey);

            HttpResponseMessage response = await client.GetAsync("https://api.api-ninjas.com/v1/randomword");
            response.EnsureSuccessStatusCode();

            string json = await response.Content.ReadAsStringAsync();

            int start = json.IndexOf("[\"") + 2;
            int end = json.IndexOf("\"]");

            if (start > 1 && end > start)
            {
                secretWord = json.Substring(start, end - start).ToLower();
            }

            updateWordDisplay();
        }
        private async void GameForm_Load(object sender, EventArgs e)
        {
            lblStrikes.Text = "Strikes: 0/7";
            await LoadRandomWord();
            
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}