using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using OfficeOpenXml;
using OfficeOpenXml.Style;
using System.IO;
using WebApplicationExportExcel.ServiceReference1;

namespace WebApplicationExportExcel
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var students = new[]{
                               new{ Id="101", Name="Vivek", Address="Hyderabad" },
                               new{ Id="102", Name="Ranjeet", Address="Hyderabad" },
                               new{ Id="103", Name="Sharath", Address="Hyderabad" },
                               new{ Id="104", Name="Ganesh", Address="Hyderabad" },
                               new{ Id="105", Name="Gajanan", Address="Hyderabad" },
                               new{ Id="106", Name="Ashish", Address="Hyderabad" }
                      };

            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("Sheet1");


            workSheet.TabColor = System.Drawing.Color.Black;
            workSheet.DefaultRowHeight = 12;


            //Header of table
            //
            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            workSheet.Cells[1, 1].Value = "S.No";
            workSheet.Cells[1, 2].Value = "Id";
            workSheet.Cells[1, 3].Value = "Name";
            workSheet.Cells[1, 4].Value = "Address";

            //Body of table
            //
            int recordIndex = 2;

            foreach (var student in students)
            {
                workSheet.Cells[recordIndex, 1].Value = (recordIndex - 1).ToString();
                workSheet.Cells[recordIndex, 2].Value = student.Id;
                workSheet.Cells[recordIndex, 3].Value = student.Name;
                workSheet.Cells[recordIndex, 4].Value = student.Address;

                recordIndex++;
            }

            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();
            workSheet.Column(4).AutoFit();

            string excelName = "studentsRecord";

            using (var memoryStream = new MemoryStream())
            {
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;  filename=" + excelName + ".xlsx");
                excel.SaveAs(memoryStream);
                memoryStream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.End();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
                string result = client.Calculator(Convert.ToInt32(firstvalue.Text), Convert.ToInt32(secondvalue.Text), operation.Text);
                if (result != "")
                    lbresult.Text = "Result" + result.ToString();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());  // Or Debug.Print, or whatever
                throw; // So exception propagation will continue
            }
            
        }

        protected void ButtonExport_Click(object sender, EventArgs e)
        {
            ServiceReference1.WebService1SoapClient client = new ServiceReference1.WebService1SoapClient();
            string gender = Convert.ToString("Female");

            var result3 = client.Products(gender);
            List<Product> products = new List<Product>();
            foreach (object obj in result3)
                products.Add((Product)obj);

            ExcelPackage excel = new ExcelPackage();
            var workSheet = excel.Workbook.Worksheets.Add("ProductList");

            workSheet.TabColor = System.Drawing.Color.Black;
            workSheet.DefaultRowHeight = 12;

            //Header of table
            //
            workSheet.Row(1).Height = 20;
            workSheet.Row(1).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
            workSheet.Row(1).Style.Font.Bold = true;

            workSheet.Cells[1, 1].Value = "Name";
            workSheet.Cells[1, 2].Value = "LastName";
            workSheet.Cells[1, 3].Value = "Gender";

            //Body of table
            //
            int recordIndex = 2;

            foreach (var productitem in products)
            {
                workSheet.Cells[recordIndex, 1].Value = productitem.Name;
                workSheet.Cells[recordIndex, 2].Value = productitem.LastName;
                workSheet.Cells[recordIndex, 3].Value = productitem.Gender;

                recordIndex++;
            }

            workSheet.Column(1).AutoFit();
            workSheet.Column(2).AutoFit();
            workSheet.Column(3).AutoFit();

            string excelName = "ProductsRecord";

            using (var memoryStream = new MemoryStream())
            {
                Response.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet";
                Response.AddHeader("content-disposition", "attachment;  filename=" + excelName + ".xlsx");
                excel.SaveAs(memoryStream);
                memoryStream.WriteTo(Response.OutputStream);
                Response.Flush();
                Response.End();
            }
        }
    }
}