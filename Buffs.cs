﻿using System;
using System.Collections.Generic;
using System.Text;
using RoR2;

namespace BetterAPI
{
    public class Buffs
    {
        internal static List<BuffDef> buffDefs;
        static Buffs()
        {
            buffDefs = new List<BuffDef>();
        }
        public static void Add(BuffDef buffDef)
        {
            buffDefs.Add(buffDef);
        }

    }
}
