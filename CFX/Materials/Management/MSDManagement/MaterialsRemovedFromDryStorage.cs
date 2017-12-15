﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Materials.Management.MSDManagement
{
    public class MaterialsRemovedFromDryStorage : CFXMessage
    {
        public MaterialsRemovedFromDryStorage()
        {
            Materials = new List<MaterialPackageDetail>();
        }

        public List<MaterialPackageDetail> Materials
        {
            get;
            set;
        }
    }
}
