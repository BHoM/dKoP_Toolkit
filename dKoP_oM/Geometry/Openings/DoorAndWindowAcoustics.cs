using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using BH.oM.dKoP.Perfomance;
using BH.oM.Geometry;

namespace BH.oM.dKoP.Geometry
{
    public class DoorAndWindowAcoustics : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Description("Weighted sound reduction index, Rw.")]
        public virtual double AirborneSoundInsulation { get; set; }

        /***************************************************/
    }
}