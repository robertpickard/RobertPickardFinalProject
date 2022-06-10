using System;
using System.Collections.Generic;
using System.Text;

namespace ISfTE.Models.ViewModels
{
    public class ProgressBarVM
    {
        public bool Upload { get; set; }
        public bool Awaiting { get; set; }
        public bool Approved { get; set; }
        public bool Registered { get; set; }
    }
}
