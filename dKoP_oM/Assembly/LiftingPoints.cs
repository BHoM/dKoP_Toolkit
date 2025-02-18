using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class LiftingPoints : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual bool IntegralLiftingPoints { get; set; }

        public virtual bool DirectLift { get; set; }

        public virtual string RequiredLiftingEquipment { get; set; }

        /***************************************************/
    }
}