using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CommunityToolkit.Mvvm;
using System.Threading.Tasks;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace ColorPicker.MVVM.ViewModels
{
    partial class ColorVM : ObservableObject
    {
        [ObservableProperty]
        public int redValue;

        [ObservableProperty]
        public int blueValue;

        [ObservableProperty]
        public int greenValue;

        [ObservableProperty]
        public string colorChoosen;


        public ColorVM()
        {
            RedValue = 0;
            BlueValue = 0;
            GreenValue = 0;

            GetSelectedColor();
        }

        [RelayCommand]
        public void GetSelectedColor()
        {
            var color = Color.FromRgb(RedValue,GreenValue,BlueValue);

            //Get Hex color
            ColorChoosen = color.ToHex();
        }


        [RelayCommand]
        public void GetRandomColor()
        {
            var random = new Random();

            RedValue = random.Next(0, 255);
            BlueValue = random.Next(0, 255);
            GreenValue = random.Next(0, 255);

            GetSelectedColor();
        }


    }
}
