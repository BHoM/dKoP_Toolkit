/*
 * This file is part of the Buildings and Habitats object Model (BHoM)
 * Copyright (c) 2015 - 2025, the respective contributors. All rights reserved.
 *
 * Each contributor holds copyright over their respective contributions.
 * The project versioning (Git) records all such contribution source information.
 *                                           
 *                                                                              
 * The BHoM is free software: you can redistribute it and/or modify         
 * it under the terms of the GNU Lesser General Public License as published by  
 * the Free Software Foundation, either version 3.0 of the License, or          
 * (at your option) any later version.                                          
 *                                                                              
 * The BHoM is distributed in the hope that it will be useful,              
 * but WITHOUT ANY WARRANTY; without even the implied warranty of               
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the                 
 * GNU Lesser General Public License for more details.                          
 *                                                                            
 * You should have received a copy of the GNU Lesser General Public License     
 * along with this code. If not, see <https://www.gnu.org/licenses/lgpl-3.0.html>.      
 */

using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;
using BH.oM.Geometry;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Window : IWallOpening, IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        [Length]
        public virtual double StructuralWidth { get; set; }

        [Length]
        public virtual double StructuralHeight { get; set; }

        public virtual ParameterPoint PositionAlongWall { get; set; } = new ParameterPoint();

        public virtual bool ConfirmationGeometryRequirementsAreMet { get; set; }

        public virtual DoorAndWindowFire Fire { get; set; } = new DoorAndWindowFire();

        public virtual DoorAndWindowAcoustics AcousticPerformance { get; set; } = new DoorAndWindowAcoustics();

        public virtual DoorAndWindowThermalPerformance ThermalPerformance { get; set; } = new DoorAndWindowThermalPerformance();

        public virtual WindowStyle WindowStyle { get; set; }

        public virtual WindowOpeningType OpeningType { get; set; }

        public virtual OpeningPartFinish InsideFinish { get; set; } = new OpeningPartFinish();

        public virtual OpeningPartFinish OutsideFinish { get; set; } = new OpeningPartFinish();
        
        public virtual string WindowFurniture { get; set; }
        
        public virtual string FinishesStyleAndOpeningDirection { get; set; }

        public virtual string Product { get; set; }

        /***************************************************/
    }
}