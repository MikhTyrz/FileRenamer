/*Класс открытия файла Windows Forms с использованием библиотеки Ookii. Dialogs*/

using System;
using System.Windows.Forms;
using Ookii.Dialogs;

public class VistaDir
{
    public static string path;
    public static void Open()
    {
        path = "";
        VistaFolderBrowserDialog of = new VistaFolderBrowserDialog();
        DialogResult result = of.ShowDialog();
        if (result == DialogResult.OK)
        {
            path = of.SelectedPath;
        }
    }
}
