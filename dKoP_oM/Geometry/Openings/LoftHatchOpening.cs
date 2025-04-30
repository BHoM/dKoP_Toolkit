using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP
{
    public class LoftHatchOpening : IFloorAndRoofOpening, IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual double ClearWidth { get; set; }

        public virtual double ClearLength { get; set; }

        public virtual ParameterPoint SettingOut { get; set; } = new ParameterPoint();

        /***************************************************/
    }
}