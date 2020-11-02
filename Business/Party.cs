using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RacingAssessment.Business
{
    class Party
    {
        public string PartyName { get; set; }
        public int Travelled { get; set; }
        public PictureBox PartyPB { get; set; }
        public Color PartyColor { get; set; }
    }
}
