﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Packages.tour_creator.Editor.Protocol
{
    [Serializable]
    class Tour
    {
        public string firstStateId;
        public List<State> states;
        public Color[] colorSchemes;
    }
}
