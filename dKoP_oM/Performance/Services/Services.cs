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
using System.Text;
using BH.oM.Quantities.Attributes;

namespace BH.oM.dKoP
{
    public class Services : IdKoPObject
    {
        /***************************************************/
        /**** Properties                                ****/
        /***************************************************/

        public virtual Electrical Electrical { get; set; } = new Electrical();

        public virtual Data Data { get; set; } = new Data();

        public virtual Heating Heating { get; set; } = new Heating();

        public virtual Water Water { get; set; } = new Water();

        public virtual Drainage Drainage { get; set; } = new Drainage();

        public virtual Gas Gas { get; set; } = new Gas();

        public virtual Ventilation Ventilation { get; set; } = new Ventilation();

        public virtual bool ServicesIntegrationConfirmation { get; set; }

        /***************************************************/
    }
}