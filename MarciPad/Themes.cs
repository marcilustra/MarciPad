using System.Windows.Controls;
using System.Windows.Media;

namespace MarciPad
{
    public static class Themes
    {
       public static void DarkTheme(TextBox textbox)
        {
            LinearGradientBrush myCustom = new LinearGradientBrush();

            GradientStop tops = new GradientStop(Color.FromArgb(255, 32, 32, 35), 0);
            GradientStop bottom = new GradientStop(Color.FromRgb(44, 44, 44), 1);

            myCustom.GradientStops.Add(tops);
            myCustom.GradientStops.Add(bottom);

            TextBox current = textbox;
            current.Background = myCustom; ;
            current.Foreground = Brushes.Ivory;
        }

        public static void LightTheme(TextBox textbox)
        {
            LinearGradientBrush myCustom = new LinearGradientBrush();

            GradientStop tops = new GradientStop(Color.FromArgb(255, 226, 226, 226), 0);
            GradientStop bottom = new GradientStop(Color.FromRgb(255, 255, 255), 1);

            myCustom.GradientStops.Add(tops);
            myCustom.GradientStops.Add(bottom);

            TextBox current = textbox;
            current.Background = myCustom;
            current.Foreground = Brushes.Black;
        }
    }
}
