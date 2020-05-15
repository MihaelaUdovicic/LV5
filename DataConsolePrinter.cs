using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class DataConsolePrinter
    {
        

        public static void printData(IDataset dataset) { 
            try
            {
                List<List<string>> print = new List<List<string>>(dataset.GetData());
                foreach (List<string> list in print)
                {

                    foreach (string s in list)
                    {
                        Console.WriteLine(s);
                    }
                    Console.WriteLine("/n");
                }
            }catch(Exception e)
            {
                throw new ArgumentException("Unkown type");
            }
            

        }

    }
}
