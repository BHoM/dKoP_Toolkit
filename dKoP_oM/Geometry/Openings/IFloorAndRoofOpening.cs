using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public interface IFloorAndRoofOpening : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        double ClearWidth { get; set; }

        [Length]
        double ClearLength { get; set; }

        ParameterPoint SettingOut { get; set; }

        /***************************************************/
    }
}