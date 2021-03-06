﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Training
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ConcatTwoString_Click(object sender, RoutedEventArgs e)
        {
            Output1.Content = Strings.Concat(Input1.Text, Input2.Text);
        }

    

        private void AddtwoNumbers_Click(object sender, RoutedEventArgs e)
        {
            int first = Int32.Parse(Input21.Text);
            int second = Int32.Parse(Input22.Text);
            ;
            Output2.Content = MathsFunctions.AddTwoNumbers(first, second).ToString();
        }

        private void SubtractTwoNumbers_Click(object sender, RoutedEventArgs e)
        {
            int first = Int32.Parse(Input183.Text);
            int second = Int32.Parse(Input184.Text);
            Output182.Content= MathsFunctions.SubrTractTwoNumbers(first,second);
        }

        private void MultiplyTwoNumbers_CLick(object sender, RoutedEventArgs e)
        {
            MathsFunctions.Multiply_TwoNumbers();
        }

        private void DivideTwoNumbers_Click(object sender, RoutedEventArgs e)
        {

            int first = Int32.Parse(Input51.Text);
            int second = Int32.Parse(Input52.Text);
            Output51.Content= MathsFunctions.Divide_TwoNumbers(first,second);
        }

        private void AddThreeNumbers_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.AddThreeNumbers();

        }

        private void SubtractThreeNumbers_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.SubtractThreeNumbers();
        }

        private void MultiplyThreeNumbers_Click(object sender, RoutedEventArgs e)
        {
            Output81.Content = MathsFunctions.MultiplyThreeNumbers(1, 2, 3);
        }

        private void DivideThreeNumbers_Click(object sender, RoutedEventArgs e)
        {

            MathsFunctions.DivideThreeNumbers();
        }

        private void AverageOfTwo_Click(object sender, RoutedEventArgs e)
        {
            Output101.Content= MathsFunctions.AverageTwoNumbers(Int32.Parse(Input101.Text), Int32.Parse(Input102.Text));
        }

        private void AverageOfThree_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.AverageThreeNumbers();
        }

        private void GetLengthOfString_Click(object sender, RoutedEventArgs e)
        {
            Strings.GetLengthOfString_Click();

        }

        private void GetSquareOfNumber_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.GetSquare();
        }

        private void GetCubeOfNumber_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.GetCUbe();
        }

        private void GetSquareRoot_Click(object sender, RoutedEventArgs e)
        {
            MathsFunctions.GetSquareRoot();
        }

        private void GetSCubeRoot_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Output171.Content = MathsFunctions.GetCubeRoot(Convert.ToDouble(Input171.Text));
            }            
            catch(Exception ex)
            {
                Output171.Content = "Error : " + ex.Message.ToString();
            }
        }

        private void ConcatThreeStrings_Click(object sender, RoutedEventArgs e)
        {
            Output181.Content = Strings.ConcatThreeStrings(Input181.Text, Input182.Text, Input1822.Text);
        }

        private void Grid_Scroll(object sender, System.Windows.Controls.Primitives.ScrollEventArgs e)
        {

        }
    }
}
