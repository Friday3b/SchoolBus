using System;
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

namespace FINAL01.View
{
    /// <summary>
    /// Interaction logic for Holiday.xaml
    /// </summary>
    public partial class Holiday : Page
    {
        public Holiday()
        {
            InitializeComponent();
        }

        private void Previous_month(object sender, RoutedEventArgs e)
        {
            if (HolidayCalendar.DisplayDate > HolidayCalendar.DisplayDateStart)
            {
                HolidayCalendar.DisplayDate = HolidayCalendar.DisplayDate.AddMonths(-1);
            }
        }

        private void Next_month(object sender, RoutedEventArgs e)
        {
            if (HolidayCalendar.DisplayDate < HolidayCalendar.DisplayDateEnd)
            {
                HolidayCalendar.DisplayDate = HolidayCalendar.DisplayDate.AddMonths(1);
            }
        }
    }
}
