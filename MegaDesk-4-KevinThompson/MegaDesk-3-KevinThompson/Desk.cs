using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_3_KevinThompson
{
    public class Desk
    {
        public int width, height, depth, drawers;
        //public int drawers;
        public Material material;

        public int ValidateIntInput(string input)
        {
            int result;
            try
            {
                result = Convert.ToInt32(input);
            }
            catch (FormatException e)
            {
                Console.WriteLine("Input string is not a sequence of digits.");
                return -1;
            }
            catch (OverflowException e)
            {
                Console.WriteLine("The number cannot fit in an Int32.");
                return -1;
            }
            return result;
        }

        //public double ValidateDoubleInput(string input)
        //{
        //    double result;
        //    try
        //    {
        //        result = Convert.ToDouble(input);
        //    }
        //    catch (FormatException e)
        //    {
        //        Console.WriteLine("Input number is not a sequence of digits.");
        //        return -1;
        //    }
        //    catch (OverflowException e)
        //    {
        //        Console.WriteLine("The number cannot fit in a Double.");
        //        return -1;
        //    }
        //    return result;
        //}

        public bool ValidateWidth(int width)
        {
            return width >= 24 && width <= 96;
        }

        public bool ValidateDepth(int depth)
        {
            return depth >= 12 && depth <= 48;
        }

        public override string ToString()
        {
            return string.Join(",",
                this.width,
                this.height,
                this.depth,
                this.drawers,
                this.material);
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
