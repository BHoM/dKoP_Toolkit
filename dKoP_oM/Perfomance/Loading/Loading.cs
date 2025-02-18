using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Loading : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double SelfWeight { get; set; }

        public virtual double VariableLoad { get; set; }

        public virtual WindLoad WindLoad { get; set; }

        public virtual SnowLoad SnowLoad { get; set; }

        public virtual bool StructuralConfirmation { get; set; }

        public virtual string StructuralVerificationMethod { get; set; }

        public virtual bool ContinuousHeadRestraint { get; set; }

        [Length]
        public virtual double MaxUnrestrainedLength { get; set; }

        /***************************************************/
    }
}