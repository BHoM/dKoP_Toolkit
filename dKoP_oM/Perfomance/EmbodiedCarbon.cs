using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP.Perfomance
{
    public class EmbodiedCarbon : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [ClimateChange]
        public virtual double A1toA3 { get; set; }

        [ClimateChange]
        public virtual double A4 { get; set; }

        [ClimateChange]
        public virtual double A5 { get; set; }

        [ClimateChange]
        public virtual double B1toB5 { get; set; }

        [ClimateChange]
        public virtual double C1toC4 { get; set; }

        [ClimateChange]
        public virtual double D { get; set; }

        /***************************************************/
    }
}