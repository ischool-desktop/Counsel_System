﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CounselTools
{
    public class ClassStudent
    {
        public string StudentID { get; set; }
        public string StudentNumber { get; set; }
        public string ClassName { get; set; }
        public string SeatNo { get; set; }
        public string StudentName { get; set; }

        public Dictionary<string, string> NonInputCompleteDict = new Dictionary<string, string>();
    }
}