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

using BH.oM.Base;
using BH.oM.Base.Attributes;
using BH.oM.Quantities.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Reflection;

namespace BH.Engine.dKoP
{
    public static partial class Query
    {
        /***************************************************/
        /**** Public Methods                            ****/
        /***************************************************/

        [Description("Evaluates a class and returns a 2d matric containing all the inner properties and their primitive types.")]
        [Input("", "")]
        [Output("", "")]
        public static object EvaluateClass(Type type, int maxRows = 1000, int maxCols = 100)
        {
            Dictionary<string, Tuple<Type, QuantityAttribute>> data = new Dictionary<string, Tuple<Type, QuantityAttribute>>();
            Evaluate(type, type.Name, data, new HashSet<Type>(), maxRows, maxCols);

            int rows = data.Count;
            int cols = 0;

            foreach (var item in data)
            {
                cols = Math.Max(cols, item.Key.Split('.').Length + 1);
            }

            string[,] result = new string[rows, cols];

            List<string> setKeys = new List<string>();
            int i = 0;
            foreach (var item in data)
            {

                string[] split = item.Key.Split('.');

                for (int j = 0; j < split.Length; j++)
                {
                    if (setKeys.Count > j && setKeys[j] == split[j])
                    {
                        result[i, j] = "";
                    }
                    else
                    {
                        while (setKeys.Count > j)
                        {
                            setKeys.RemoveAt(j);
                        }
                        result[i, j] = split[j];
                        setKeys.Add(split[j]);
                    }
                }

                for (int j = split.Length; j < cols -1; j++)
                {
                    result[i, j] = "";
                }

                result[i, cols - 1] = item.Value.Item1.Name;

                i++;
            }

            return result;
        }

        /***************************************************/
        /**** Private Methods                            ****/
        /***************************************************/

        private static bool Evaluate(Type type, string current, Dictionary<string, Tuple<Type, QuantityAttribute>> data, HashSet<Type> handledTypes, int maxRows, int maxCols)
        {
            if (current.Split('.').Length > maxCols)
            {
                BH.Engine.Base.Compute.RecordWarning("Maxmimum number of columns reached.");
                return false;
            }

            if (handledTypes.Contains(type))
            {
                BH.Engine.Base.Compute.RecordWarning("Stopping evaluation as type already handled to avoid infinite loop.");
                return true;
            }
            else
            {
                handledTypes = new HashSet<Type>(handledTypes);
                handledTypes.Add(type);
            }

            if (typeof(IObject).IsAssignableFrom(type))
            {
                if (type.IsInterface && type != typeof(IFragment) && type != typeof(IObject) && type != typeof(IBHoMObject))
                {
                    int maxTypes = 4;
                    int c = 0;
                    foreach (Type implementingType in GetImplementingTypes(type))
                    {
                        if(!Evaluate(implementingType, $"{current}.{implementingType.Name}", data, handledTypes, maxRows, maxCols))
                            return false;
                        if (c++ > maxTypes)
                            return true;
                    }
                }
                else
                {
                    foreach (PropertyInfo property in type.GetProperties())
                    {
                        if (!Evaluate(property.PropertyType, $"{current}.{property.Name}", data, handledTypes, maxRows, maxCols))
                            return false;
                    }
                }
            }
            else if (type.IsGenericType && (type.GetGenericTypeDefinition() == typeof(List<>)))
            {
                Type itemType = type.GetGenericArguments()[0];
                if(!Evaluate(itemType, $"{current} (Can be more than one)", data, handledTypes, maxRows, maxCols))
                    return false;
            }
            else
            {
                data[current] = new Tuple<Type, QuantityAttribute>(type, null);
                if (data.Count > maxRows)
                {
                    BH.Engine.Base.Compute.RecordWarning("Maxmimum number of rows reached.");
                    return false;
                }
            }


            return true;
        }

        private static List<Type> GetImplementingTypes(Type type)
        { 
            if(m_LinkedTypes.ContainsKey(type))
                return m_LinkedTypes[type];

            m_LinkedTypes[type] = BH.Engine.Base.Query.BHoMTypeList().Where(x => !x.IsInterface && !x.IsAbstract).Where(x => type.IsAssignableFrom(x)).ToList();
            return m_LinkedTypes[type];
        }

        /***************************************************/

        private static Dictionary<Type, List<Type>> m_LinkedTypes = new Dictionary<Type, List<Type>>();
    }
}
