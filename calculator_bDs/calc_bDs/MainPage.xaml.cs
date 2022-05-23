using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calc_bDs
{
    public partial class MainPage : ContentPage
    {
        public Label ResultVie;
        public Button FuncButton;
        public string[] TextButtons = new string[19] {"c", "del", "%", "/",
                                                "7", "8", "9", "*",
                                                "4", "5", "6", "-",
                                                "1", "2", "3", "+",
                                                 "0", ",", "="};
         
        public MainPage()
        {
            InitializeComponent();
            Initialization();
        }
        public void Initialization()
        {
            int row = 1; int column = 0;
            Grid grid = new Grid
            {
                BackgroundColor = Color.Black
            };

            ResultVie = new Label
            {
                Text = "Работает",
                TextColor = Color.LightGray
            };
            Grid.SetRow(ResultVie, 0);
            Grid.SetColumn(ResultVie, 0);
            Grid.SetColumnSpan(ResultVie, 3);
            grid.Children.Add(ResultVie);

            for (int i = 0; i < TextButtons.Length; i++)
            {
                FuncButton = new Button
                {
                    Text = TextButtons[i],
                    BackgroundColor = Color.Orange
                };
                FuncButton.Clicked += DefineButton;
                Grid.SetRow(FuncButton, row);
                Grid.SetColumn(FuncButton, column);
                grid.Children.Add(FuncButton);
                column++;
                if (column > 3)
                {
                    column = 0;
                    row++;
                }
                if (column == 0 && row == 5)
                {
                    column++;
                }
            }

            this.Content = grid;
        }

        public void DefineButton(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            switch (button.Text)
            {
                case "=":
                    ResultVie.Text = "=";
                        break;
                default:
                    break;
            }
        }
    }
}
