using System;

namespace LV5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //3. zadatak
            //IDataset data = new Dataset("C:\\Users\\User\\source\\repos\\LV5\\doc.txt");
            //DataConsolePrinter.printData(data);

            //IDataset virtualpd=new VirtualProxyDataset("C:\\Users\\User\\source\\repos\\LV5\\doc.txt");
            //DataConsolePrinter.printData(virtualpd);

            //User user1 = User.GenerateUser("Prvi");
            //User user2 = User.GenerateUser("Drugi");
            //IDataset protectionpd1 = new ProtectionProxyDataset(user1);
            //IDataset protectionpd2 = new ProtectionProxyDataset(user2);
            //DataConsolePrinter.printData(protectionpd1);
            //DataConsolePrinter.printData(protectionpd2);

            ////4. zadatak
            ITheme theme = new myTheme();
            //ReminderNote reminderNote = new ReminderNote("Moja boja", theme);
            //reminderNote.Show();

            ////testiranje 5. zadatka
            //GroupNote group = new GroupNote("poruka", theme);
            //group.AddinGroup("Pinokio");
            //group.AddinGroup("Shrek");
            //group.Show();
            //group.RemovefromGroup("Pinokio");
            //group.Show();

            double[] niz= { 6,2,1,9,3,0};
            SortStrategy bubble = new BubbleSort();
            SortStrategy comb = new CombSort();
            SortStrategy seq = new SequentialSort();
            NumberSequence number = new NumberSequence(niz);
            NumberSequence sequenceSize = new NumberSequence(6);


            number.SetSortStrategy(bubble);
            number.Sort();
            number.ToString();

            number.SetSortStrategy(comb);
            number.Sort();
            number.ToString();

            number.SetSortStrategy(seq);
            number.Sort();
            number.ToString();

            Pretrazivanja pretrazivanja = new LinearnoPretrazivanje();
            number.SetPretrazivanje(pretrazivanja);
            number.pretr();
          

        }
    }
}
