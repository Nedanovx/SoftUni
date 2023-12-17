﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NauticalCatchChallenge.Models
{
    public class ReefFish : Fish
    {
        private const int ReefFishTimeToCatch = 30;
        public ReefFish(string name, double points) : base(name, points, ReefFishTimeToCatch)
        {
        }
    }
}
