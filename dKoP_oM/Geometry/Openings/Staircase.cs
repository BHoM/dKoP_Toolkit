using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Staircase : IFloorAndRoofOpening, IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double ClearWidth { get; set; }

        [Length]
        public virtual double ClearLength { get; set; }

        public virtual ParameterPoint SettingOut { get; set; } = new ParameterPoint();

        /***************************************************/
    }
}