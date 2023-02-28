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

namespace VehiclesFuelEconomicCalculator
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

        private void compare_btn_Click(object sender, RoutedEventArgs e)
        {
            Vehicle vehicleA = new Vehicle();
            Vehicle vehicleB = new Vehicle();
            int monthRange = int.Parse(VDistance_tb.Text);
            double fuelPrice = double.Parse(FuelPrice_tb.Text);

            vehicleA.CarMake = VAMake_tb.Text;
            vehicleA.CarModel = VAModel_tb.Text;
            vehicleA.Fuel = double.Parse(VAFuel_tb.Text);
            vehicleA.Insurance = double.Parse(VAInsur_tb.Text);
            vehicleA.Price = double.Parse(VAPrice_tb.Text);
            //vehicleA.Mains = double.Parse(VAMain_tb.Text);

            vehicleB.CarMake = VBMake_tb.Text;
            vehicleB.CarModel = VBModel_tb.Text;
            vehicleB.Fuel = double.Parse(VBFuel_tb.Text);
            vehicleB.Insurance = double.Parse(VBInsur_tb.Text);
            vehicleB.Price = double.Parse(VBPrice_tb.Text);
            //vehicleB.Mains = double.Parse(VBMain_tb.Text);

            double VAMonthlyCost = vehicleA.Insurance + monthRange / 100 * vehicleA.Fuel * fuelPrice;
            double VBMonthlyCost = vehicleB.Insurance + monthRange / 100 * vehicleB.Fuel * fuelPrice;

            double month = (vehicleA.Price - vehicleB.Price) / (VBMonthlyCost - VAMonthlyCost);

            if (month > 0)
            {
                if (vehicleA.Price < vehicleB.Price)
                {
                    Result_tb.Text = $"{vehicleB.CarMake} {vehicleB.CarModel} will payback in {Math.Round(month,2)} months, compare to {vehicleA.CarMake} {vehicleA.CarModel}!!";
                }else if (vehicleA.Price > vehicleB.Price)
                {
                    Result_tb.Text = $"{vehicleA.CarMake} {vehicleA.CarModel} will payback in {Math.Round(month, 2)} months, compare to {vehicleB.CarMake} {vehicleB.CarModel}!!";
                }
            }else if (month < 0)
            {
                if ((vehicleA.Price - vehicleB.Price) < 0)
                {
                    Result_tb.Text = $"{vehicleA.CarMake} {vehicleA.CarModel} is already better than {vehicleB.CarMake} {vehicleB.CarModel}!!";
                }else if (((vehicleA.Price - vehicleB.Price) > 0))
                {
                    Result_tb.Text = $"{vehicleB.CarMake} {vehicleB.CarModel} is already better than {vehicleA.CarMake} {vehicleA.CarModel}!!";
                }
            }

        }
    }
}
