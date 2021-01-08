using Syncfusion.Data;
using Syncfusion.SfDataGrid.XForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyXamarinApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //dataGrid.GroupColumnDescriptions.Add(new GroupColumnDescription()
            //{
            //    ColumnName = "Freight",
            //    Converter = new GroupConverter()
            //});
        }
    }

    public class GroupConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var orderInfo = value as OrderInfo;
            if (orderInfo.Freight > 0 && orderInfo.Freight <= 100)
                return "<=100";
            else if (orderInfo.Freight > 100 && orderInfo.Freight <= 250)
                return "<=250";
            else if (orderInfo.Freight > 250 && orderInfo.Freight <= 500)
                return ">250 & <=500";
            else if (orderInfo.Freight > 500 && orderInfo.Freight <= 750)
                return ">500 & <=750";
            else
                return ">750";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}
