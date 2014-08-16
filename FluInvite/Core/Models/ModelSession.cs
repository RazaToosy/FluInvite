using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FluInvite.Core.Models
{
    public class ModelSession
    {
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public int NoOfSlots { get; set; }
    }
}
