﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game.Domain
{
    public class SpecialMove
    {
        public int Id { get; set; }
        public string Name { get; set; }
        // 1 or 3.
        public int Level { get; set; }
    }
}
