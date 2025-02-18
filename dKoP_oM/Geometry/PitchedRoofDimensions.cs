using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BH.oM.dKoP.Geometry
{
    public class PitchedRoofDimensions : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double Width { get; set; }

        public virtual double Span { get; set; }

        public virtual Pitch Pitch { get; set; }

        public virtual double Overhang { get; set; }

        [Description("Overall buildup.")]
        public virtual double HeightAtFascia { get; set; }

        public virtual InternalSpandrelPanel InternalSpandrelPanel { get; set; }
        
        public virtual GableEndPanel GableEndPanel { get; set; }

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}