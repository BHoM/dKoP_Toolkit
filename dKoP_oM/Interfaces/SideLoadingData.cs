using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace BH.oM.dKoP.Interfaces
{
    public class SideLoadingData : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double HorizontalOutOfPlaneLoadVariableMax { get; set; }
        
        public virtual double HorizontalOutOfPlaneLoadVariableMin { get; set; }

        /***************************************************/
    }
}