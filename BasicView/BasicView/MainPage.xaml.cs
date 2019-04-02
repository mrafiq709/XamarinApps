using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BasicView
{
    public partial class MainPage : ContentPage
    {
        int cnt = 0;
        public MainPage()
        {
            InitializeComponent();
        }
        void OnButtonClicked(object sender, EventArgs e)
        {
            string str = Convert.ToString(cnt++);
            (sender as Button).Text = "Click me again! " + str;
            Console.WriteLine("Click me again! " + str);

        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

            Console.WriteLine("Entry Old Text: " + oldText);
            Console.WriteLine("Entry New Text: " + newText);

        }

        void OnEntryCompleted(object sender, EventArgs e)
        {
            string text = ((Entry)sender).Text;
            Console.WriteLine("Entry Text: " + text);
        }

        void OnEditorTextChanged(object sender, TextChangedEventArgs e)
        {
            string oldText = e.OldTextValue;
            string newText = e.NewTextValue;

            Console.WriteLine("Editor Old Text: " + oldText);
            Console.WriteLine("Editor New Text: " + newText);
        }

        void OnEditorCompleted(object sender, EventArgs e)
        {
            string text = ((Editor)sender).Text;
            Console.WriteLine("Editor Completed Text: " + text);
        }
    }
}
