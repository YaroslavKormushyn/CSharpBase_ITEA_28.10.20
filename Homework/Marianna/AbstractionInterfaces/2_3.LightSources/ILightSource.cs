using System;
using System.Collections.Generic;
using System.Text;

namespace _2_3.LightSources
{
    interface ILightSource
    {
        void TurnOn();
        void TurnOff();
        public double AreaSize { get; set; }
        public double PowerUsage { get; set; }
    }
}
