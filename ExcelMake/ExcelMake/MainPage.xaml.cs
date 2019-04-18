using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Syncfusion.XlsIO;
using System.IO;

namespace ExcelMake
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            //Create an instance of ExcelEngine.
            using (ExcelEngine excelEngine = new ExcelEngine())
            {
                //Set the default application version as Excel 2013.
                excelEngine.Excel.DefaultVersion = ExcelVersion.Excel2013;

                //Create a workbook with a worksheet
                IWorkbook workbook = excelEngine.Excel.Workbooks.Create(1);

                //Access first worksheet from the workbook instance.
                IWorksheet worksheet = workbook.Worksheets[0];

                //Adding text to a cell
                worksheet.Range["A1"].Text = "Hello World";

                //Save the workbook to stream in xlsx format. 
                MemoryStream stream = new MemoryStream();
                workbook.SaveAs(stream);

                workbook.Close();

                //Save the stream as a file in the device and invoke it for viewing
                //DependencyService.Get<ISave>().SaveAndView("GettingStared.xlsx", "application/msexcel", stream);

                string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                string filename = Path.Combine(path, "GettingStared.xlsx");

                using (var streamWriter = new StreamWriter(filename, true))
                {
                    streamWriter.WriteLine(DateTime.UtcNow);
                }

                using (var streamReader = new StreamReader(filename))
                {
                    string content = streamReader.ReadToEnd();
                    System.Diagnostics.Debug.WriteLine(content);
                }

                DependencyService.Get<IToastMessage>().Show("Toast Message");
            }
        }
    }
}
