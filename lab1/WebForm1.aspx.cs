using System;
using System.Globalization;
using System.Web.UI;

namespace lab1
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = " ";
        }

        protected void Calculate(object sender, EventArgs e)
        {
            switch (DropDownList1.Text)
            {
                case "add": Add(); break;
                case "substract": Substract(); break;
                case "divide": Divide(); break;
                case "multiply": Multiply(); break;
            }
        }

        void Add()
        {
            try
            {
                var first = Convert.ToDouble(FirstArg.Value);
                var second = Convert.ToDouble(SecondArg.Value);
                Label1.Text = (first + second).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {

                Label1.Text = "Nie można wykonać tej operacji";
            }
        }
        void Substract()
        {
            try
            {
                var first = Convert.ToDouble(FirstArg.Value);
                var second = Convert.ToDouble(SecondArg.Value);
                Label1.Text = (first - second).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {

                Label1.Text = "Nie można wykonać tej operacji";
            }
        }
        void Divide()
        {
            try
            {
                var first = Convert.ToDouble(FirstArg.Value);
                var second = Convert.ToDouble(SecondArg.Value);
                Label1.Text = (first / second).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {

                Label1.Text = "Nie można wykonać tej operacji";
            }
        }
        void Multiply()
        {
            try
            {
                var first = Convert.ToDouble(FirstArg.Value);
                var second = Convert.ToDouble(SecondArg.Value);
                Label1.Text = (first * second).ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception)
            {

                Label1.Text = "Nie można wykonać tej operacji";
            }
        }
         
    }   
}