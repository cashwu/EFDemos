﻿// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Performance.EFCore
{
    public class SalesTaxRate
    {
        public int SalesTaxRateID { get; set; }
        public int StateProvinceID { get; set; }
        public byte TaxType { get; set; }
        public decimal TaxRate { get; set; }
        public string Name { get; set; }
        public Guid rowguid { get; set; }
        public DateTime ModifiedDate { get; set; }

        public virtual StateProvince StateProvince { get; set; }
    }
}
