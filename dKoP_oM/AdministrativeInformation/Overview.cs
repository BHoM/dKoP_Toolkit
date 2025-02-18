using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class Overview : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual PartName PartName { get; set; }

        public virtual string PathReference { get; set; }

        public virtual string PartDataTemplateVersion { get; set; }

        public virtual DFMACategory DFMACategory { get; set; }

        //TODO:
        //Image - handle here as well as JsonSchema
        /***************************************************/
    }
}
