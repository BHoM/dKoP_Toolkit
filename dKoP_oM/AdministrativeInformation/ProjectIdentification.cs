using BH.oM.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace BH.oM.dKoP
{
    public class ProjectIdentification : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual string ProjectReference { get; set; } = "";

        public virtual string ProjectName { get; set; } = "";

        public virtual string ProjectLocation { get; set; } = "";

        public virtual string AdditionalReferences { get; set; } = "";

        /***************************************************/
    }
}
