using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BH.oM.dKoP
{
    public class FlatRoofDimensions : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double Width { get; set; }

        public virtual double Length { get; set; }

        public virtual double Fall { get; set; }

        public virtual double Overhang { get; set; }

        [Description("Overall buildup.")]
        public virtual double HeightAtFascia { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}