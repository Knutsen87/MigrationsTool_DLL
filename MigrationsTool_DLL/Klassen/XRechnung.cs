using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;

namespace CSVDemo
{
    class XWriter
    {
        internal void MakeXML(String FilePath, List<String[]> varList)
        {
            // Falls die Datei nicht existiert - dann:
            if (!File.Exists(FilePath))
            {
                //Wenn die varList Zählung 2 Elemente enthält - dann:
                if (varList.Count() == 2)
                {
                    /* Speichert die XML Datei im angegeben Pfad
                     * Die Liste ElementAt beginnt mit dem 2ten Eintrag.
                     * 0 Wäre die Kopfzeile - dies sagt nicht aus ob in unsere
                     * XML Datei Daten enthalten sind, sondern erst mit dem 
                     * zweiten Eintrag. 
                     */
                    XmlWriter xw = XmlWriter.Create(FilePath);
                    WriteXml(xw, varList.ElementAt(1));
                }

                /* Wenn die obigen IF-Anweisungen nicht durchgeführt werden können, 
                 * wird geprüft ob die Liste mehr als 2 Elemente enthält
                 */
                else if (varList.Count() > 2)
                {
                    /* Eine Schleife: Int Wert beträgt 1. Solange i gleich oder kleiner als
                     * die varList ist, wird i um jeweils 1 erhöht. So wird die Datei abgerufen
                     * und beim Speichern der Dateiname um den Wert 1 erhöht. Beim nächsten speichern
                     * dann um 2. Bsp.: Dateiname1, Dateiname2, Dateiname3 usw. 
                     */
                    for (int i = 1; i <= varList.Count(); i++)
                    {
                        XmlWriter xw = XmlWriter.Create(FilePath + i.ToString());
                        WriteXml(xw, varList.ElementAt(i));
                    }
                }
            }
        }

        private void WriteXml(XmlWriter xw, String[] content)
        {
            xw.WriteStartDocument();
            xw.WriteStartElement("Test");

            xw.WriteStartElement(content[0]);
            xw.WriteAttributeString(content[1], content[2]);
            xw.WriteEndElement();

            xw.WriteEndElement();
            xw.WriteEndDocument();
        }
    }
}
