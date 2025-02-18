using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FloorDimensions : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double Width { get; set; }

        public virtual double Length { get; set; }

        [Description("Overall buildup.")]
        public virtual double Thickness { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}