using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Handbook.Models
{
    public class Material
    {
        public string author;
        public string song;
        public string cd;
        // Конструктор для заполнения данных про композицию
        public Material(string a,string s, string c)
        {
            author = a;
            song = s;
            cd = c;
        }
        // Переопределение метода ToString
        public override string ToString()
        {
            return $"Исполнитель: {author} Песня: {song} Диск: {cd}";
        }
        // Метод добавления композиции
        public void Add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/database.xml");
            XmlNode root = doc.DocumentElement;
            XmlElement mat = doc.CreateElement("material");

            XmlElement tag = doc.CreateElement("author");            
            tag.InnerText = author;
            mat.AppendChild(tag);

            tag = doc.CreateElement("song");
            tag.InnerText = song;
            mat.AppendChild(tag);

            tag = doc.CreateElement("disk");
            tag.InnerText = cd;
            mat.AppendChild(tag);

            root.AppendChild(mat);
            doc.Save(@"../../Data/database.xml");
        }


    }
}
