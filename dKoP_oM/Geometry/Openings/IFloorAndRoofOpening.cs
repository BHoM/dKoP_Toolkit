using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;

namespace BH.oM.dKoP.Geometry
{
    public interface IFloorAndRoofOpening : IdKopObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        double ClearWidth { get; set; }

        double ClearLength { get; set; }

        ParameterPoint SettingOut { get; set; }

        /***************************************************/
    }
}