using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace handbook.model
{
     public class material
    {

        public string name;
        public string song;
        public string disk;

        public string Info
        {
            get
            {
                return $"Исполнитель: {name} Песня: {song} Диск: {disk}";
            }
        }
        public material(string name, string song, string disk)
        {
            this.name = name;
            this.song = song;
            this.disk = disk;
        }
        public void Add()
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../data/database.xml");
            XmlNode root = doc.DocumentElement;
            XmlElement tag = doc.CreateElement("name");
            XmlElement perf = doc.CreateElement("info");
            tag.InnerText = name;
            perf.AppendChild(tag);

            tag = doc.CreateElement("song");
            tag.InnerText = song;
            perf.AppendChild(tag);
            root.AppendChild(perf);

            tag = doc.CreateElement("disk");
            tag.InnerText = disk;
            perf.AppendChild(tag);

            root.AppendChild(perf);
            doc.Save(@"../../Data/database.xml");
        }
    }
    public class MatList
    {
        public List<material> pr
        {
            get
            {
                List<material> l = new List<material>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/database.xml");
                XmlNode root = doc.DocumentElement;
                for (int i = 0; root.ChildNodes[i] != null; i++)
                {
                    material mat = new material(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText);
                    l.Add(mat);
                }
                return l;
            }
        }
        public List<material> Find(material mat)
        {
            List<material> result = new List<material>();
            for (int i = 0; i < pr.Count; i++)
            {
                if (pr[i].name.ToLower().Contains(mat.name.Trim(' ').ToLower()) && pr[i].song.ToLower().Contains(mat.song.Trim(' ').ToLower()) && pr[i].disk.ToLower().Contains(mat.disk.Trim(' ').ToLower()))
                {
                    result.Add(pr[i]);
                }
            }
            return result;
        }


    }
}
