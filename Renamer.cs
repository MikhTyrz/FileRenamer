using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileRenamer
{
    class Renamer
    {
        public static void Rename()     //И здесь жопа, я пытаюсь вернуть массив, чтобы проверить 
        {
            string [] filesToRename = Directory.GetFiles(VistaDir.path);
            foreach (string file in filesToRename)
            {
                string fe = Path.GetExtension(file);
                char[] a = Path.GetFileNameWithoutExtension(file).ToCharArray();    //Разобрали строку на символы, выдернув из нее имя файла без расширения
                for(int i = 0; i < a.Length; i++)
                {
                    if(Char.IsLetter(a[i]) == true)
                    {
                        continue;
                    }
                    else if (Char.IsNumber(a[i]) == true)
                    {
                        continue;
                    }
                    else
                    {
                        a[i] = '_';    //Поменяли все, что требуется
                    }
                }

                string fn = new string(a);    //Типа собрали массив обратно и дальше магия
                string newFileName = $@"{fn}{fe}";
                string newFileFullPath = Path.Combine(VistaDir.path, newFileName);
                File.Move(file, newFileFullPath);
            }

            
        }
    }
}
