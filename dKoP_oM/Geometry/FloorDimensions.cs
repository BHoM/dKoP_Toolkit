using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class FloorDimensions : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Width { get; set; }

        [Length]
        public virtual double Length { get; set; }

        [Length]
        [Description("Overall buildup.")]
        public virtual double Thickness { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}