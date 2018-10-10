using MegaDesk_3_KevinThompson;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk_4_KevinThompson
{
    public class FileHelper
    {
        public static void ToCsv(DeskQuote deskQuote, string separator = ",")
        {
            string fileName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\quotes.csv";
            if (!File.Exists(fileName))
            {
                using (TextWriter tw = File.CreateText(fileName))
                {
                    tw.WriteLine(deskQuote.ToString());
                }
            }
            else
            {
                List<DeskQuote> currentQuotes = FromCsv();
                using (TextWriter tw = File.CreateText(fileName))
                {
                    currentQuotes.ForEach(quote =>
                    {
                        tw.WriteLine(quote.ToString());
                   });
                    tw.WriteLine(deskQuote.ToString());
                }
            }
            
        }

        public static List<DeskQuote> FromCsv()
        {
            string fileName = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + @"\quotes.csv";
            List<DeskQuote> deskQuotes = File.ReadAllLines(fileName)
                                           .Select(v => MapFromCsv(v))
                                           .ToList();
            return deskQuotes;
        }

        private static DeskQuote MapFromCsv(string csvLine)
        {
            string[] values = csvLine.Split(',');
            DeskQuote deskQuote = new DeskQuote();
            deskQuote.name = Convert.ToString(values[0]);
            deskQuote.quoteDate = Convert.ToDateTime(values[1]);
            Enum.TryParse<ShippingOption>(values[2].ToString(), out ShippingOption option);
            deskQuote.shippingOption = option;
            deskQuote.price = Convert.ToInt32(values[3]);
            Enum.TryParse<Material>(values[8].ToString(), out Material materialOption);
            Desk desk = new Desk
            {
                width = Convert.ToInt32(values[4]),
                height = Convert.ToInt32(values[5]),
                depth = Convert.ToInt32(values[6]),
                drawers = Convert.ToInt32(values[7]),
                material = materialOption
            };
            deskQuote.desk = desk;
            return deskQuote;
        }
    }
}
