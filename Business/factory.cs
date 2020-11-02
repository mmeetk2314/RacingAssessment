using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RacingAssessment.Business
{

    static class Factory
    {
        public static int GamblerNumber { get; set; }

        //Decides which punter to instantiate //0, 1, 2, 3?
        public static Gambler GetAGambler(int id)
        {
            switch (id)
            {
                case 0:
                    return new Karen();
                case 1:
                    return new Becky();
                case 2:
                    return new Brad();
                case 3:
                    return new Jordan();
                default:
                    return null;
            }
        }

        public static int SetGamblerNumber(string Name)
        {


            switch (Name)
            {
                case "Karen":
                    GamblerNumber = 0;
                    return GamblerNumber;
                case "Becky":
                    GamblerNumber = 1;
                    return GamblerNumber;
                case "Brad":
                    GamblerNumber = 2;
                    return GamblerNumber;
                case "Jordan":
                    GamblerNumber = 3;
                    return GamblerNumber;
                default:
                    GamblerNumber = 0;
                    return GamblerNumber;
            }
        }
    }
}
