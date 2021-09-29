using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MigrationsTool_DLL
{
    class DatevRead
    {
        // String Array Namens Content mit Inhalt der CSV Datei
        private String[] content;

        // internal damit Semi nicht darauf zugreifen kann, Filepath ist der Übergabeparameter
        internal void Read(String FilePath)
        {
            /*  Liest die CSV Datein ein. 
                Eine Zeile ist ein String Element des Arrays */
            content = File.ReadAllLines(FilePath);
        }

        // Gibt als Rückgabewert eine List aus String Arrays zurück 
        internal List<String[]> getVarList()
        {
            // Die zurückgegebene Strings werden in einer neuen Liste initialisiert.
            List<String[]> tempList = new List<string[]>();

            /* Für jeden String im Array "content" unterteilt die Methode
             * den String nach dem Split Parameter ( Semicolon ) und speichert dieses als
             * neues Array und fügt es der tempListe hinzu.
             */
            foreach(String Rows in content)
            {
                tempList.Add(Rows.Split(';'));
            }
            // Gibt die gefüllte tempList als Rückgabeparameter
            return tempList;
        }


    }
}
