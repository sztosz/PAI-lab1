using System;
using System.Collections.Generic;
using System.Globalization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lab1
{
    public partial class WebForm1 : Page
    {
        String _calculateMethod = "add";
        protected void Page_Load(object sender, EventArgs e)
        {
            PopulateDropdownList();
            Label1.Text = " ";
        }

        void PopulateDropdownList()
        {

            var items = new List<ListItem>
            {
                new ListItem("+", "add"),
                new ListItem("-", "substract"),
                new ListItem("/", "divide"),
                new ListItem("*", "multiply")
            };
            DropDownList1.Items.AddRange(items.ToArray());
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _calculateMethod = sender.ToString();
        }

        protected void Calculate(object sender, EventArgs e)
        {
            switch (_calculateMethod)
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