using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp2
{
    internal class ExplainedButton:Button
    {
        public string Explanation { get; set; }
        public bool WasClicked { get; set; } = false;
    }
}
