using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TrueFalseQuizApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        string question1 = "Red is a color";
        string question2 = "Blue is a shade of red";
        string question3 = "Light Blue is like blue but lighter";
        string question4 = "Blue is not a color";

        int points = 0;

        private void Start_Clicked(object sender, EventArgs e)
        {
            True.IsVisible = true;
            False.IsVisible = true;
            Start.IsVisible = false;

            QuestionResults.Text = question1;
        }

        private void True_Clicked(object sender, EventArgs e)
        {
            if(QuestionResults.Text == question1)
            {
                points++;
                QuestionResults.Text = question2;
            }

            else if (QuestionResults.Text == question2)
            {
                QuestionResults.Text = question3;
            }

            else if (QuestionResults.Text == question3)
            {
                points++;
                QuestionResults.Text = question4;
            }

            else if (QuestionResults.Text == question4)
            {
                QuestionResults.Text = $"You Scored: {points} Points";

                True.IsVisible = false;
                False.IsVisible = false;
            }
        }

        private void False_Clicked(object sender, EventArgs e)
        {
            if (QuestionResults.Text == question1)
            {
                QuestionResults.Text = question2;
            }

            else if (QuestionResults.Text == question2)
            {
                points++;
                QuestionResults.Text = question3;
            }

            else if (QuestionResults.Text == question3)
            {
                QuestionResults.Text = question4;
            }

            else if (QuestionResults.Text == question4)
            {
                points++;
                QuestionResults.Text = $"You Scored: {points} Points";

                True.IsVisible = false;
                False.IsVisible = false;
            }

        }

    }
}
