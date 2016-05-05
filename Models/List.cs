using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Handbook.Models
{
    public class List
    {
        public List<Material> lm
        {
            get
            {
                List<Material> l = new List<Material>();
                XmlDocument doc = new XmlDocument();
                doc.Load(@"../../Data/database.xml");
                XmlNode root = doc.DocumentElement;
                for (int i=0;root.ChildNodes[i]!= null; i++)
                {
                    l.Add(new Material(root.ChildNodes[i].ChildNodes[0].InnerText, root.ChildNodes[i].ChildNodes[1].InnerText, root.ChildNodes[i].ChildNodes[2].InnerText));
                }
                return l;
            }
        }

        public List<Disk> lcd
        {
            get
            {
                List<Disk> l = new List<Disk>();
                int k = 0;
                bool c;
                for (int i = 0; i < lm.Count; i++)
                {
                    c = true;
                    for (int n = 0; n < l.Count; n++)
                    {
                        if (lm[i].cd == l[n].name)
                        {
                            c = false;
                            break;
                        }
                    }
                    if (c)
                    {
                        l.Add(new Disk(lm[i].cd));
                        for (int j = i; j < lm.Count; j++)
                        {
                            if (lm[j].cd == l[k].name)
                            {
                                l[k].ld.Add(lm[j]);
                            }
                        }
                        k++;
                    }

                }
                return l;
            }
        }

        public void Delete(int a)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"../../Data/database.xml");
            XmlNode root = doc.DocumentElement;
            root.RemoveChild(root.ChildNodes[a]);
            doc.Save(@"../../Data/database.xml");
        }

        public List<Material> Find(Material m)
        {
            List<Material> fn = new List<Material>();
            for (int i = 0; i < lm.Count; i++)
            {
                if (lm[i].author.ToLower().Trim(' ').Contains(m.author.ToLower().Trim(' ')) && lm[i].song.ToLower().Trim(' ').Contains(m.song.ToLower().Trim(' ')) && lm[i].cd.ToLower().Trim(' ').Contains(m.cd.ToLower().Trim(' ')))
                {
                    fn.Add(lm[i]);
                }
            }
            return fn;
        }

        public int FindIndex(string s)
        {
            for (int i = 0; i < lm.Count; i++)
            {
                if (lm[i].ToString() == s)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
