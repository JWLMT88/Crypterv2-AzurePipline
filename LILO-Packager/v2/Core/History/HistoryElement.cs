﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LILO_Packager.v2.Core.History
{
    public class HistoryElement
    {

        public int id { get; set; } = 0;
        public String operationType { get; set; } = String.Empty;
        public String mode { get; set; } = String.Empty;
        public String algorithmVersion { get; set; } = String.Empty;
        public String inputFileName { get; set; } = String.Empty;
        public String outputFileName { get; set; } = String.Empty;
    }

}