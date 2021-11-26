using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R03BMI
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            creater.Text = "JK3A33 船山　謙太";
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            String height = heighit.Text;
            String weight = weighit.Text;

            double h = double.Parse(height);
            double w = double.Parse(weight);

            if(h >= 100)
            {
                h = h / 100;
            }

            if(w >= 1000)
            {
                w = w / 1000;
            }

            double BMI;

            try
            {
                BMI = w / (h * h);

                if (BMI < 18.50)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で低体重です。";
                }
                else if (BMI < 25.00)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で普通体重です。";
                }
                else if (BMI < 30.00)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で肥満(1度)です。";
                }
                else if (BMI < 35.00)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で肥満(2度)です。";
                }
                else if (BMI < 40.00)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で肥満(3度)です。";
                }
                else if (BMI >= 40.00)
                {
                    result.Text = "身長" + height + "体重" + weight + "の人のBMIは" + BMI + "で肥満(4度)です。";
                }
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex);
                heighit.Text = "!!!";
            }
        }
    }
}
