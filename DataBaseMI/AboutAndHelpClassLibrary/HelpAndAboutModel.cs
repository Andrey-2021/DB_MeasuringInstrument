using HelpAndAboutModelInterface;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace HelpAndAboutClassLibrary
{
    /// <summary>
    /// Класс Model для окна "Помощь" и "О программе".
    /// Данные берём из XML-файлов
    /// </summary>
    public class HelpAndAboutModel: IHelpAndAboutModel
    {
        /// <summary>
        /// Данные прочитанные из файла
        /// </summary>
        List<HelpDTO> _helpList = new();

        /// <summary>
        /// Конструктор
        /// </summary>
        public HelpAndAboutModel(WorkMode workMode)
        {
            string? fileName=null;
            
            switch (workMode)
            {
                case WorkMode.help:
                    fileName = "Help.xml";
                    break;
                case WorkMode.about:
                    fileName = "About.xml";
                    break;
                default:
                    fileName = "Неизвестное значение "+workMode;
                    break;
            }

            _helpList =LoadInfoFromXML(fileName);
        }

        
        /// <summary>
        /// Читаем данные из XML файла
        /// </summary>
        List<HelpDTO> LoadInfoFromXML(string fileName)
        {
            List<HelpDTO> infoList= new List<HelpDTO>();

            if (!File.Exists(fileName))
            {
                AssembleDTO("Информация", "Файл <" + fileName + "> не найден",ref infoList);
                return infoList;
            }

            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(fileName);

                if (doc.DocumentElement == null)
                {
                    AssembleDTO("Информация", "Файл <" + fileName + "> пустой", ref infoList);
                    return infoList;
                }
                else
                {
                    int i = 1;
                    foreach (XmlNode node in doc.DocumentElement)
                    {
                        var record = new HelpDTO();
                        
                        if (node.Attributes == null) //если нет атрибута
                        {
                            record.Name = "Нет атрибута " + i;
                            i++;
                        }
                        else record.Name = node.Attributes[0].Value;

                        record.Text = node.InnerText;
                        infoList.Add(record);
                    }
                }
            }
            catch (Exception ex)
            {
                AssembleDTO("Информация", 
                    "При чтении файла <" + fileName + "> произошла ошибка: " +ex.Message ,
                    ref infoList);
                return infoList;
            }
            return infoList;
        }


        /// <summary>
        /// Сборка объекта DTO и добавление его в список
        /// </summary>
        /// <param name="name">Значение для поля Name создаваемого объекта DTO</param>
        /// <param name="text">Значение для поля Text создаваемого объекта DTO</param>
        /// <param name="infoList">Список, в который добавляется объект DTO</param>
        void AssembleDTO(string name, string text, ref List<HelpDTO> infoList)
        {
            var record = new HelpDTO()
            {
                Name = name,
                Text = text
            };
            infoList.Add(record);
        }



        public List<string?> GetParagraphNamesList()
        {
            List<string?> paragraphsNames = new List<string?>();
            foreach (var item in _helpList)
            {
                paragraphsNames.Add(item.Name);
            }
            return paragraphsNames;
        }

        public string? GetParagraphText(string? parParagraphName)
        {
            var record= _helpList.Find(x => x.Name == parParagraphName);
            
            if (record == null) return "";
            else return record.Text;
        }
    }
}
