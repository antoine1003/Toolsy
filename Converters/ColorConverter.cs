using System;
using System.Windows.Data;
using System.Windows.Media;
using Toolsy.Models;

namespace Toolsy
{
    public class ColorConverter : IValueConverter
    {
        public object Convert(object entity, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            var tile = entity as Tile;
            if (tile.Type == "link")
            {
                return Brushes.LightGreen;
            }
            else if (tile.Type == "file")
            {
                return Brushes.LightSkyBlue;
            }
            else if (tile.Type == "folder")
            {
                return Brushes.LightPink;
            }
            else
                return Brushes.LightSeaGreen;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
