﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CFX.Materials.Management
{
    public class MaterialsEmpty : CFXMessage
    {
        public MaterialsEmpty()
        {
            EmptyMaterials = new List<MaterialLocation>();
        }

        public List<MaterialLocation> EmptyMaterials
        {
            get;
            set;
        }
    }
}
