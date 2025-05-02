using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BH.oM.dKoP
{
    public class FlatRoofDimensions : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Width { get; set; }

        [Length]
        public virtual double Length { get; set; }

        [Length]
        public virtual double Fall { get; set; }

        [Length]
        public virtual double Overhang { get; set; }

        [Length]
        [Description("Overall buildup.")]
        public virtual double HeightAtFascia { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}