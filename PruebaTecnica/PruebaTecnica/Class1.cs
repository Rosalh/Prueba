using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PruebaTecnica
{
    internal class Class1
    {
        public partial class Button : UserControl
        {
            private string text;
            public Button(string nom)
            {
                InitializeComponent();
                this.text = nom;
            }
            public string TExt
            {
                get { return text; }
                set { text = value; }
            }
            static async Task RunAsync()
            {
                // Update port # in the following line.
                client.BaseAddress = new Uri(" https://api.github.com/users");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new MediaTypeWithQualityHeaderValue("application/json"));
            }
    }
}
