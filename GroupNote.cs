using System;
using System.Collections.Generic;
using System.Text;

namespace LV5
{
    class GroupNote : Note
    {
        public List<string> list;
        
        public GroupNote(string message, ITheme theme) : base(message, theme)
        {
            list = new List<string>();
        }
        public void AddinGroup(string name)
        {
            list.Add(name);
        }
        public void RemovefromGroup(string name)
        {
            list.Remove(name);
        }

        public static String Builder(List<string> lista)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (string s in lista)
            {
                stringBuilder.Append(s).Append(", ");
            }
            return stringBuilder.ToString();
        }

        public override void Show()
        {
            this.ChangeColor();
            Console.WriteLine("Grupa: ");
            string framedMessage = Builder(list);
            Console.WriteLine(framedMessage);
            Console.ResetColor();

        }






    }
}
