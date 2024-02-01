using System.Reflection;

namespace BrightTV // Do not change the namespace name
{
    public class TelevisionUtility:Television // Do not change the class name
    {
        //Implement your code here
       
        public bool ValidateSpecification()
        {
            if ((Model == "BR OLED55C" || Model == "BR QN90A") && (ScreenSize == 35 || ScreenSize == 50 || ScreenSize == 65) && (Resolution == "720p" || Resolution == "1080p" || Resolution == "4K") && (PanelType == "LED" || PanelType == "OLED" || PanelType == "QLED") && (OperatingSystem == "Android" || OperatingSystem == "Roku"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double CalculatePrice()
        {
            double basic;
            double sizef;
            double resf;
            double panelt;
            sizef = ScreenSize / 10.0;
            if (Model == "BR OLED55C")
            {
                basic = 8000;
            }
            else
            {
                basic = 12000;
            }
            if (Resolution == "720p" || Resolution == "1080p")
            {
                resf = 1.0;
            }
            else
            {
                resf = 1.5;
            }
            if (PanelType == "LED")
            {
                panelt = 1.0;
            }
            else if (PanelType == "OLED")
            {
                panelt = 2.0;
            }
            else
            {
                panelt = 1.5;
            }
            TotalPrice = basic * sizef * resf * panelt;
            return TotalPrice;
        }
        public double CalculateDiscountedPrice()
        {
            double disc;
            if (TotalPrice < 20000)
            {
                disc = TotalPrice - 0.10 * TotalPrice;
            }
            else if (TotalPrice <= 50000 && TotalPrice >= 20000)
            {
                disc = TotalPrice - 0.15 * TotalPrice;
            }
            else
            {
                disc = TotalPrice - 0.20 * TotalPrice;
            }
            return disc;
        }

    }
}