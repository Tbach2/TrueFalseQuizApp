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
        string question4 = "Green is not a color";

        string image1 = "https://gonoord.com/wp-content/uploads/2020/03/Red_Color.jpg";
        string image2 = "https://www.kovifabrics.com/img/products/7737.JPG";
        string image3 = "https://wallpapercave.com/wp/UGOcPA9.jpg";
        string image4 = "https://www.solidbackgrounds.com/images/2048x2048/2048x2048-bright-green-solid-color-background.jpg";

        int points = 0;

        private void Start_Clicked(object sender, EventArgs e)
        {
            Start.IsVisible = false;
            Images.IsVisible = true;

            QuestionResults.Text = question1;

            Images.Source = image1;
        }

        private void SwipeRight(object sender, EventArgs e)
        {
            if(QuestionResults.Text == question1)
            {
                points++;
                QuestionResults.Text = question2;
                Images.Source = image2;
            }

            else if (QuestionResults.Text == question2)
            {
                QuestionResults.Text = question3;
                Images.Source = image3;
            }

            else if (QuestionResults.Text == question3)
            {
                points++;
                QuestionResults.Text = question4;
                Images.Source = image4;
            }

            else if (QuestionResults.Text == question4)
            {
                QuestionResults.Text = $"You Scored: {points} Points";
                Images.IsVisible = false;
            }
        }

        private void SwipeLeft(object sender, EventArgs e)
        {
            if (QuestionResults.Text == question1)
            {
                QuestionResults.Text = question2;
                Images.Source = image2;
            }

            else if (QuestionResults.Text == question2)
            {
                points++;
                QuestionResults.Text = question3;
                Images.Source = image3;
            }

            else if (QuestionResults.Text == question3)
            {
                QuestionResults.Text = question4;
                Images.Source= image4;
            }

            else if (QuestionResults.Text == question4)
            {
                points++;
                QuestionResults.Text = $"You Scored: {points} Points";
                Images.IsVisible = false;
            }

        }

    }
}
