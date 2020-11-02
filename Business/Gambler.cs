using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment.Business
{
    class Gambler
    {
        public string GamblerName { get; set; }
        public string Party { get; set; }
        public Single Balance { get; set; }
        public Single Bet { get; set; }
        public RadioButton GamblerRB { get; set; }
        public Label GamblerLabel { get; set; }
    }
}
