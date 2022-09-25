using System;
using System.Xml.Linq;

namespace LINQ2
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument xmlDoc =
            new XDocument(
            new XDeclaration("1.0", "utf-8", "yes"),
            new XComment("Кино"),
            new XElement("Кинотеатры",

           // new XElement("Кинотеатр Мелодия", 


            new XElement("книга", new XAttribute("название", "Мяу"),
            new XElement("Автор",
            new XAttribute("Фамилия", "Мордвинова"),
            new XAttribute("Имя", "Варвара"),
            new XAttribute("Отчество", "Дмитриевна")
            ),

            new XElement("Издание",
            new XAttribute("Наименование_Издательства", "Pavuk"),
            new XAttribute("Год_Издания", "2022"),
            new XAttribute("Количество_Страниц", "123"),
            new XAttribute("Цена", "1000")
            )
            ),

            new XElement("книга", new XAttribute("название", "Вишневый сад"),
            new XElement("Автор",
            new XAttribute("Фамилия", "Красовский"),
            new XAttribute("Имя", "Роман"),
            new XAttribute("Отчество", "Валерьевич")
            ),

            new XElement("Издание",
            new XAttribute("Наименование_Издательства", "Лотос"),
            new XAttribute("Год_Издания", "2016"),
            new XAttribute("Количество_Страниц", "40"),
            new XAttribute("Цена", "500")
            )
            ),

            new XElement("книга", new XAttribute("название", "Война и мир"),
            new XElement("Автор",
            new XAttribute("Фамилия", "Толстой"),
            new XAttribute("Имя", "Лев"),
            new XAttribute("Отчество", "Николаевич")
            ),

            new XElement("Издание",
            new XAttribute("Наименование_Издательства", "Миф"),
            new XAttribute("Год_Издания", "1998"),
            new XAttribute("Количество_Страниц", "400"),
            new XAttribute("Цена", "1500")
            )
            ),

            new XElement("книга", new XAttribute("название", "Герой нашего времени"),
            new XElement("Автор",
            new XAttribute("Фамилия", "Лермонтов"),
            new XAttribute("Имя", "Михаил"),
            new XAttribute("Отчество", "Юрьевич")
            ),

            new XElement("Издание",
            new XAttribute("Наименование_Издательства", "Эпос"),
            new XAttribute("Год_Издания", "2004"),
            new XAttribute("Количество_Страниц", "120"),
            new XAttribute("Цена", "800")
            )
            )

            )
            );
            xmlDoc.Save("C:/Users/romus/Desktop/Cinema.xml");
        }
    }
}