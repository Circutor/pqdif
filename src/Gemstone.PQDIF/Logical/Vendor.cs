﻿//******************************************************************************************************
//  Vendor.cs - Gbtc
//
//  Copyright © 2014, Grid Protection Alliance.  All Rights Reserved.
//
//  Licensed to the Grid Protection Alliance (GPA) under one or more contributor license agreements. See
//  the NOTICE file distributed with this work for additional information regarding copyright ownership.
//  The GPA licenses this file to you under the MIT License (MIT), the "License"; you may
//  not use this file except in compliance with the License. You may obtain a copy of the License at:
//
//      http://www.opensource.org/licenses/MIT
//
//  Unless agreed to in writing, the subject software distributed under the License is distributed on an
//  "AS-IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied. Refer to the
//  License for the specific language governing permissions and limitations.
//
//  Code Modification History:
//  ----------------------------------------------------------------------------------------------------
//  05/07/2014 - Stephen C. Wills
//       Generated original version of source code.
//
//******************************************************************************************************

using System;
using System.Collections.Generic;
using System.Linq;

namespace Gemstone.PQDIF.Logical
{
    /// <summary>
    /// Vendors for power quality hardware.
    /// </summary>
    public static class Vendor
    {
        /// <summary>
        /// The ID for vendor SATEC.
        /// </summary>
        public static Guid SATEC { get; } = new("e2da5081-7fdb-11d3-9b39-0040052c2d28");

        /// <summary>
        /// The ID for vendor WPT.
        /// </summary>
        public static Guid WPT { get; } = new("e2da5082-7fdb-11d3-9b39-0040052c2d28");

        /// <summary>
        /// The ID representing no vendor.
        /// </summary>
        public static Guid None { get; } = new("e6b51701-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor BMI.
        /// </summary>
        public static Guid BMI { get; } = new("e6b51702-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor BPA.
        /// </summary>
        public static Guid BPA { get; } = new("e6b51702-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor CESI.
        /// </summary>
        public static Guid CESI { get; } = new("e6b51704-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Cooper.
        /// </summary>
        public static Guid Cooper { get; } = new("e6b51705-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor DCG.
        /// </summary>
        public static Guid DCG { get; } = new("e6b51706-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Dranetz.
        /// </summary>
        public static Guid Dranetz { get; } = new("e6b51707-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor EDF.
        /// </summary>
        public static Guid EDF { get; } = new("e6b51708-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Electric Power Research Institute.
        /// </summary>
        public static Guid EPRI { get; } = new("e6b51709-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Electrotek.
        /// </summary>
        public static Guid Electrotek { get; } = new("e6b5170a-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Fluke.
        /// </summary>
        public static Guid Fluke { get; } = new("e6b5170b-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Hydro-Quebec.
        /// </summary>
        public static Guid HydroQuebec { get; } = new("e6b5170c-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor IEEE.
        /// </summary>
        public static Guid IEEE { get; } = new("e6b5170d-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Kreiss Johnson.
        /// </summary>
        public static Guid KreissJohnson { get; } = new("e6b5170e-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Metrosonic.
        /// </summary>
        public static Guid Metrosonic { get; } = new("e6b5170f-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor PML.
        /// </summary>
        public static Guid PML { get; } = new("e6b51710-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor PSI.
        /// </summary>
        public static Guid PSI { get; } = new("e6b51711-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor PTI.
        /// </summary>
        public static Guid PTI { get; } = new("e6b51712-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for public domain hardware.
        /// </summary>
        public static Guid PublicDomain { get; } = new("e6b51713-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor RPM.
        /// </summary>
        public static Guid RPM { get; } = new("e6b51714-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Square D PowerLogic.
        /// </summary>
        public static Guid SquareDPowerLogic { get; } = new("e6b51715-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor Telog.
        /// </summary>
        public static Guid Telog { get; } = new("e6b51716-f747-11cf-9d89-0080c72e70a3");

        /// <summary>
        /// The ID for vendor PMI.
        /// </summary>
        public static Guid PMI { get; } = new("609acec0-993d-11d4-a4b3-444553540000");

        /// <summary>
        /// The ID for vendor Met One.
        /// </summary>
        public static Guid MetOne { get; } = new("b5b5da61-e2e1-11d4-82d9-00e09872a094");

        /// <summary>
        /// The ID for vendor Trinergi.
        /// </summary>
        public static Guid Trinergi { get; } = new("0fd5a3a8-d73a-11d2-ac3e-444553540000");

        /// <summary>
        /// The ID for vendor General Electric.
        /// </summary>
        public static Guid GE { get; } = new("5202bd00-245c-11d5-a4b3-444553540000");

        /// <summary>
        /// The ID for vendor LEM.
        /// </summary>
        public static Guid LEM { get; } = new("80c4a722-2816-11d4-8ab4-004005698d26");

        /// <summary>
        /// The ID for vendor ACTL.
        /// </summary>
        public static Guid ACTL { get; } = new("80c4a761-2816-11d4-8ab4-004005698d26");

        /// <summary>
        /// The ID for vendor AdvanTech.
        /// </summary>
        public static Guid AdvanTech { get; } = new("650f988f-378c-47b8-baed-cccb3f959ad7");

        /// <summary>
        /// The ID for vendor ELCOM.
        /// </summary>
        public static Guid ELCOM { get; } = new("f7e9eb70-6f1d-11d6-9cb3-0020e010453b");

        /// <summary>
        /// Gets information about the vendor identified by the given ID.
        /// </summary>
        /// <param name="vendorID">Globally unique identifier for the vendor.</param>
        /// <returns>The information about the vendor.</returns>
        public static Identifier? GetInfo(Guid vendorID) => 
            VendorLookup.TryGetValue(vendorID, out Identifier? identifier) ? identifier : null;

        /// <summary>
        /// Converts the given vendor ID to a string containing the name of the vendor.
        /// </summary>
        /// <param name="vendorID">The ID of the vendor to be converted to a string.</param>
        /// <returns>A string containing the name of the vendor with the given ID.</returns>
        public static string ToString(Guid vendorID) =>
            GetInfo(vendorID)?.Name ?? vendorID.ToString();

        private static Dictionary<Guid, Identifier> VendorLookup
        {
            get
            {
                Tag? vendorTag = Tag.GetTag(DataSourceRecord.VendorIDTag);

                if (s_vendorTag != vendorTag)
                {
                    s_vendorTag = vendorTag;
                    s_vendorLookup = vendorTag?.ValidIdentifiers.ToDictionary(id => Guid.Parse(id.Value));
                }

                return s_vendorLookup ?? new Dictionary<Guid, Identifier>();
            }
        }

        private static Tag? s_vendorTag;
        private static Dictionary<Guid, Identifier>? s_vendorLookup;
    }
}
