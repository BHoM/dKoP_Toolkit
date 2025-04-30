using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP
{
    public class SideLoadingData : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double HorizontalOutOfPlaneLoadVariableMax { get; set; }
        
        public virtual double HorizontalOutOfPlaneLoadVariableMin { get; set; }

        /***************************************************/
    }
}