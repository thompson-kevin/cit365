using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KevinThompson
{
    class DeskQuote
    {
        public string name;
        public Desk desk;
        public double price;
        public DateTime quoteDate;
        public OrderOption orderOption;

        public double CalcPrice()
        {
            double basePrice = 200;
            if (desk != null)
            {
                double surfaceArea = CalcSurfaceArea(desk.width, desk.depth);
                double drawerCost = CalcDrawerCost(desk.drawers);
                double materialCost = CalcMaterialCost(desk.material);
                double rushOrderCost = 0;
                if (orderOption != OrderOption.StandardShipping)
                {
                    rushOrderCost = CalcRushOrderCost(orderOption, surfaceArea);
                }
                return basePrice + drawerCost + materialCost + rushOrderCost;
            }
            return -1;
        }

        private double CalcSurfaceArea(double width, double depth)
        {
            return width * depth;
        }

        private double CalcDrawerCost(int numberOfDrawers)
        {
            double baseDrawerPrice = 50;
            return baseDrawerPrice * numberOfDrawers;
        }

        private double CalcMaterialCost(Material material)
        {
            switch (material)
            {
                case Material.Oak:
                    return 200;
                case Material.Lamenant:
                    return 100;
                case Material.Pine:
                    return 50;
                case Material.Rosewood:
                    return 300;
                case Material.Veneer:
                    return 125;
            }
            return -1;
        }

        private double CalcRushOrderCost(OrderOption orderOption, double surfaceArea)
        {
            switch (orderOption)
            {
                case OrderOption.ThreeDay:
                    if (surfaceArea < 1000)
                    {
                        return 60;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 70;
                    }
                    else if (surfaceArea > 2000)
                    {
                        return 80;
                    }
                    break;
                case OrderOption.FiveDay:
                    if (surfaceArea < 1000)
                    {
                        return 40;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 50;
                    }
                    else if (surfaceArea > 2000)
                    {
                        return 60;
                    }
                    break;
                case OrderOption.SevenDay:
                    if (surfaceArea < 1000)
                    {
                        return 30;
                    }
                    else if (surfaceArea >= 1000 && surfaceArea <= 2000)
                    {
                        return 35;
                    }
                    else if (surfaceArea > 2000)
                    {
                        return 40;
                    }
                    break;
                default:
                    return 0;
            }
            return -1;
        }
    }
}
