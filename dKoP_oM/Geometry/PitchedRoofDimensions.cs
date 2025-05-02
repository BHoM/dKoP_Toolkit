using BH.oM.Quantities.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Security.Principal;
using System.Text;
using System.Threading;

namespace BH.oM.dKoP
{
    public class PitchedRoofDimensions : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double Width { get; set; }

        [Length]
        public virtual double Span { get; set; }

        public virtual Pitch Pitch { get; set; }

        [Length]
        public virtual double Overhang { get; set; }

        [Length]
        [Description("Overall buildup.")]
        public virtual double HeightAtFascia { get; set; }

        public virtual InternalSpandrelPanel InternalSpandrelPanel { get; set; } = new InternalSpandrelPanel();
        
        public virtual GableEndPanel GableEndPanel { get; set; } = new GableEndPanel();

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }


        /***************************************************/
    }
}