using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace WorkingWithFileHandling
{
    public partial class MainPage : ContentPage
    {
        string fileName;
        public MainPage()
        {
            InitializeComponent();
        }
        
        void OnButtonSave(object sender, EventArgs e)
        {
            Console.WriteLine("Click me again!\n");
            //loadTxt.Text = enTxt.Text;
            fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "temp.txt");
            Console.WriteLine("Path: " + fileName);
            fileWriter(fileName, enTxt.Text);
        }

        void OnButtonLoad(object sender, EventArgs e)
        {
            Console.WriteLine("Loading Button !\n");

            fileRead(fileName);
        }

        void fileWriter(String fName, string text)
        {
            File.WriteAllText(fName, text);
        }
        
        void fileRead(String fName)
        {
            if (File.Exists(fName))
            {
                string text = File.ReadAllText(fName);
                loadTxt.Text = text;
                Console.WriteLine("File Content:  " + text);
            }

        }
        
    }
}
