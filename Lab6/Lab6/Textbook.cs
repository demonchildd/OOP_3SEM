﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab4
{
    internal partial class Textbook : PrintedEdition
    {
        internal int forclass;
        public int ForClass
        {
            get { return forclass; }
            set 
            {
                if (value <= 0 || value > 11)
                {
                    throw new TextBookException("Kласс должен быть от 1 до 11", value);
                } 
                else
                {
                    forclass = value;
                }
            }
        }
        internal Textbook(string name, int cost, int countPage, int forclass) : base(name, cost, countPage)
        {
            ForClass = forclass;
        }

        internal override bool Evaluation()
        {
            if (Cost > 100)
                return true;
            return false;
        }
        
    }
}
