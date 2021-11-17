using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TFlab
{
    public partial class MainPage : ContentPage
    {
        private static string[] questions = new string[]
        {
            "Is 7 prime?",
            "Is 17 prime?",
            "Is 27 prime?",
            "Is 37 prime?",
            "Is 47 prime?",
        };
        private static bool[] answers = new bool[]
        {
            true,
            true,
            false,
            true,
            true
        };
        private int counter = 0;
        private int score = 0;
        public MainPage()
        {
            InitializeComponent();
            outtyLabel.Text = questions[counter];
        }
        private void onTrueClick(object sender, EventArgs e)
        {
            if (answers[counter])
            {
                score++;
            }
            if (counter <=3)
            {
                nextQuestion();
            }
            else
            {
                endQuiz();
            }
        }
        private void onFalseClick(object sender, EventArgs e)
        {
            if (!answers[counter])
            {
                score++;
            }
            if (counter <=3)
            {
                nextQuestion();
            }
            else
            {
                endQuiz();
            }
        }
        private void endQuiz()
        {
            outtyLabel.Text = "quiz over. score: " + score;
            trueBtn.IsEnabled = false;
            falseBtn.IsEnabled = false;
        }
        private void nextQuestion()
        {
            counter++;
            outtyLabel.Text = questions[counter];
        }
    }
}
