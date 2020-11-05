﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace POS_System.ViewModal
{
    public class SubItem
    {
        public SubItem(string name, UserControl screen = null)
        {
            Name = name; //submit this item
            Screen = screen;
        }
        public string Name { get; private set; }
        public UserControl Screen { get; private set; }
    }
}
