using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class WallDimensions : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Width { get; set; }

        [Length]
        public virtual double Length { get; set; }

        [Length]
        public virtual double Height { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}