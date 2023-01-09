using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Grocki
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            string l1 = Label1.Text;
            string l2 = Label2.Text;
            string l3 = Label3.Text;
            Device.StartTimer(TimeSpan.FromSeconds(1), () =>
            {
                var utcTime = DateTime.UtcNow.ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                var hongKongTime = TimeZoneInfo.ConvertTimeBySystemTimeZoneId(DateTime.UtcNow, "Hongkong").ToString("HH:mm:ss", CultureInfo.InvariantCulture);
                var localTime = DateTime.Now.ToString("HH:mm:ss", CultureInfo.InvariantCulture);

                Label1.Text = l1 + utcTime;
                Label2.Text = l2 + hongKongTime;
                Label3.Text = l3 + localTime;
                return true;
            });
            
        }

        
    }
}
