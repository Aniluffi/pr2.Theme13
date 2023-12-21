using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Software
    {
        string name;
        string manufacturer;
        string access;

        

        public string Name { get => name; set => name = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Access 
        { 
            get => access; 
            set
            {
                if (value == "p") access = "платное";
                else if (value == "b") access = "бесплатное";
                else
                {
                   
                    access = "ошибка";
                }
            } 
        }

        public Software(string manufacturer, string access,string name)
        {
            this.Name = name;
            this.Manufacturer = manufacturer;
            this.Access = access;
        }

        public void ChangeAccess(string ch)
        {
            Access = ch;
        }

        public void J(string d)
        {
             Console.WriteLine($"Софт {name} является {access}\n");

        }

        public void ShowInf()
        {
            Console.WriteLine($"Название - {name}\n" +
                $"Производитель - {manufacturer}\n" +
                $"Доступ - {access}\n");
        }
    }
}
