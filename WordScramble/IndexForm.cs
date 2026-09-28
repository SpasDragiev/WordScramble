using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WordScramble
{
    public partial class IndexForm : Form
    {
        private const string wordsTextFile = "words.txt";

        private readonly List<string> wordList = new();
        private readonly List<string> failedAttemptsList = new();

        private int attempts = 0;
        private int guessedWords = 0;
        private string currentWord = string.Empty;

        private readonly Random random = new();

        public IndexForm()
        {
            InitializeComponent();
            this.Load += IndexForm_Load;
        }

        private void IndexForm_Load(object? sender, EventArgs e)
        {
            GetAllWords();

            if (wordList.Count == 0)
            {
                MessageBox.Show(
                    "No words found in words.txt. Please add at least one word per line.",
                    "Word list empty",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            GenerateNewWord();
            UpdateLabels();
        }

        private void GetAllWords()
        {
            if (!File.Exists(wordsTextFile))
            {
                return;
            }

            using StreamReader reader = new(wordsTextFile);
            while (!reader.EndOfStream)
            {
                string? line = reader.ReadLine();
                if (!string.IsNullOrWhiteSpace(line))
                {
                    wordList.Add(line.Trim());
                }
            }
        }

        private void GenerateNewWord()
        {
            if (wordList.Count == 0)
            {
                currentWord = string.Empty;
                labelScrambledWord.Text = "(no words left)";
                return;
            }

            int index = random.Next(wordList.Count);
            currentWord = wordList[index];
            ResetGameInfo();
        }

        private void ResetGameInfo()
        {
            attempts = 0;
            failedAttemptsList.Clear();
            labelScrambledWord.Text = ScrambleWord(currentWord);
        }

        private string ScrambleWord(string word)
        {
            if (string.IsNullOrEmpty(word))
            {
                return string.Empty;
            }

            char[] chars = word.ToCharArray();

            for (int n = chars.Length - 1; n > 0; n--)
            {
                int k = random.Next(n + 1);
                (chars[n], chars[k]) = (chars[k], chars[n]);
            }

            string scrambled = new(chars);

            if (scrambled == word && word.Length > 1)
            {
                return ScrambleWord(word);
            }

            return scrambled;
        }

        private void CheckTheWord()
        {
            string input = textBoxInput.Text.Trim();

            if (string.IsNullOrEmpty(input))
            {
                return;
            }

            if (string.Equals(input, currentWord, StringComparison.OrdinalIgnoreCase))
            {
                SuccessfulAttempt();
            }
            else
            {
                UnsuccessfulAttempt(input);
            }
        }

        private void SuccessfulAttempt()
        {
            guessedWords++;
            wordList.Remove(currentWord);
            GenerateNewWord();
        }

        private void UnsuccessfulAttempt(string input)
        {
            attempts++;
            failedAttemptsList.Add(input);

            if (attempts > 9)
            {
                GenerateNewWord();
            }
        }

        private void UpdateLabels()
        {
            labelAttemptsCount.Text = attempts.ToString();
            labelGuessedCount.Text = guessedWords.ToString();
            textBoxFailedAttempts.Text = string.Join(Environment.NewLine, failedAttemptsList);
            textBoxInput.Clear();
            textBoxInput.Focus();
        }

        private void buttonCheck_Click(object? sender, EventArgs e)
        {
            CheckTheWord();
            UpdateLabels();
        }

        private void buttonSkip_Click(object? sender, EventArgs e)
        {
            GenerateNewWord();
            UpdateLabels();
        }
    }
}
