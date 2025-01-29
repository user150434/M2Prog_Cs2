using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Rijschool.auto;
using static Rijschool.Rijleraar;

namespace Rijschool
{
    internal class LesUur
    {
        public class lesUur
        {
            public TimeSpan StartTijd { get; set; }
            public TimeSpan EindTijd { get; set; }
            public RijLeraar Leraar { get; set; }
            public Student Leerling { get; set; }
            public Auto GebruikteAuto { get; set; }
        }

    }
}
