using System;
using System.Diagnostics;
using System.Xml.Linq;

namespace LINQ2
{
    class Program
    {

        public static void createXML (string path) {
            XDocument xmlDoc = new XDocument(
                new XDeclaration("1.0", "utf-8", "yes"),
                new XComment("Кино"),
                new XElement("Кинотеатр_Мелодия",

                        new XElement("Сеансы",

                            new XElement("Сеанс",
                                new XAttribute("Дата", "19.09.2022"),
                                new XAttribute("Время", "08:00"),
                                new XAttribute("Цена_билета", "250"),
                                new XAttribute("ID_Фильма", "1"),
                                new XElement("Места",
                                    new XElement("Место", new XAttribute("Номер", "1"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "2"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "3"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "4"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "5"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "6"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "7"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "8"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "9"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "10"), new XAttribute("Занято", "1"))
                                )
                            ),
                            new XElement("Сеанс",
                                new XAttribute("Дата", "19.09.2022"),
                                new XAttribute("Время", "10:00"),
                                new XAttribute("Цена_билета", "270"),
                                new XAttribute("ID_Фильма", "2"),
                                new XElement("Места",
                                    new XElement("Место", new XAttribute("Номер", "1"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "2"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "3"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "4"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "5"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "6"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "7"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "8"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "9"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "10"), new XAttribute("Занято", "1"))
                                )
                            ),
                            new XElement("Сеанс",
                                new XAttribute("Дата", "19.09.2022"),
                                new XAttribute("Время", "13:00"),
                                new XAttribute("Цена_билета", "300"),
                                new XAttribute("ID_Фильма", "3"),
                                new XElement("Места",
                                    new XElement("Место", new XAttribute("Номер", "1"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "2"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "3"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "4"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "5"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "6"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "7"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "8"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "9"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "10"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "11"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "12"), new XAttribute("Занято", "0"))
                                )
                            ),
                            new XElement("Сеанс",
                                new XAttribute("Дата", "19.09.2022"),
                                new XAttribute("Время", "15:00"),
                                new XAttribute("Цена_билета", "270"),
                                new XAttribute("ID_Фильма", "1"),
                                new XElement("Места",
                                    new XElement("Место", new XAttribute("Номер", "1"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "2"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "3"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "4"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "5"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "6"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "7"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "8"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "9"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "10"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "11"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "12"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "13"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "14"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "15"), new XAttribute("Занято", "1"))
                                )
                            ),
                            new XElement("Сеанс",
                                new XAttribute("Дата", "19.09.2022"),
                                new XAttribute("Время", "18:00"),
                                new XAttribute("Цена_билета", "270"),
                                new XAttribute("ID_Фильма", "2"),
                                new XElement("Места",
                                    new XElement("Место", new XAttribute("Номер", "1"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "2"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "3"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "4"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "5"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "6"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "7"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "8"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "9"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "10"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "11"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "12"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "13"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "14"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "15"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "16"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "17"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "18"), new XAttribute("Занято", "0")),
                                    new XElement("Место", new XAttribute("Номер", "19"), new XAttribute("Занято", "1")),
                                    new XElement("Место", new XAttribute("Номер", "20"), new XAttribute("Занято", "1"))
                                )
                            )

                        ),

                        new XElement("Фильмы",
                            new XElement("Фильм", new XAttribute("Название", "Чужой"), new XAttribute("id", "1"),
                                new XElement("Режиссер",
                                    new XAttribute("Фамилия", "Скотт"),
                                    new XAttribute("Имя", "Ридли")
                                ),
                                new XElement("Издание",
                                    new XAttribute("Год", "1979"),
                                    new XAttribute("Длительность", "116")
                                )
                            ),
                            new XElement("Фильм", new XAttribute("Название", "Аватар"), new XAttribute("id", "2"),
                                new XElement("Режиссер",
                                    new XAttribute("Фамилия", "Кэмерон"),
                                    new XAttribute("Имя", "Джеймс")
                                ),
                                new XElement("Издание",
                                    new XAttribute("Год", "2009"),
                                    new XAttribute("Длительность", "162")
                                )
                            ),
                            new XElement("Фильм", new XAttribute("Название", "Назад в будущее"), new XAttribute("id", "3"),
                                new XElement("Режиссер",
                                    new XAttribute("Фамилия", "Земекис"),
                                    new XAttribute("Имя", "Роберт")
                                ),
                                new XElement("Издание",
                                    new XAttribute("Год", "1985"),
                                    new XAttribute("Длительность", "116")
                                )
                            )
                        )
                    )
            );
            xmlDoc.Save(path);
        }

        static void NameAndAuthorWithPrice(XDocument doc, int price)
        {
            //Console.WriteLine(doc);
            var rez = from book in doc.Descendants("книга")
                      from izdanie in book.Elements("Издание")
                      from author in book.Elements("Автор")
                      where (int)izdanie.Attribute("Цена") <= price
                      select new
                      {
                          name = book.Attribute("название").Value,
                          fstname = book.Element("Автор").Attribute("Имя").Value,
                          lstname = book.Element("Автор").Attribute("Фамилия").Value,
                      };

            foreach (var r in rez)
            {
                Console.WriteLine("Название: " + r.name + ", Автор: " + r.lstname + " " + r.fstname);
            }
        }

        static void SumPriceFromDistrubutor(XDocument doc, String distributor)
        {
            //Console.WriteLine(doc);
            var rez1 = from book in doc.Descendants("книга")
                       from izdanie in book.Elements("Издание")
                       where izdanie.Attribute("Наименование_Издательства").Value == distributor
                       select int.Parse(izdanie.Attribute("Цена").Value);
            int sum = rez1.Sum();

            foreach (var r in rez1)
            {
                Console.WriteLine("Цена = " + r);
                //XElement test = r.Element("Автор");
                //Console.WriteLine("Название: " + r.Attribute("название") + ", Автор: " + test.Attribute("Фамилия") + " " + test.Attribute("Имя"));
            }
        }

        //  Данные о занятых местах, сгруппированные по сеансам. 
        public static void closedPlaces(XDocument doc)
        {
            var groups = from sessions in doc.Descendants("Сеансы")
                      from session in sessions.Elements("Сеанс")
                      from places in session.Elements("Места")
                      from place in places.Elements("Место")
                      where place.Attribute("Занято").Value == "1"
                      group session by session;

            foreach (var group in groups)
            {
                Console.WriteLine("Сеанс " + group.Key);
                //XElement test = r.Element("Автор");
                //Console.WriteLine("Название: " + r.Attribute("название") + ", Автор: " + test.Attribute("Фамилия") + " " + test.Attribute("Имя"));
                foreach (var gr in group)
                {
                    //Console.WriteLine("Строка в группе = " + gr);

                }
            }
        }

        static void Main(string[] args)
        {
            // Создаем XML, чтобы было с чем работать
            //createXML("C:/Users/romus/Desktop/Cinema.xml");
            XDocument xmlDoc = XDocument.Load("C:/Users/romus/Desktop/Cinema.xml");
            // 3 часть задания
            closedPlaces(xmlDoc);



        }
    }
}