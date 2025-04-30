using System;
using System.Collections.Generic;
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class TemporaryWorks : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual bool PreinstalledInternally { get; set; }

        public virtual bool PreinstalledExternally { get; set; }

        public virtual int Number { get; set; }

        public virtual bool Returnable { get; set; }


        /***************************************************/
    }
}