﻿﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZEngine.Components;
namespace Spelkonstruktionsprojekt.ZEngine.Components
{
    public class GlobalSpawnComponent : IComponent
    {
        public int WaveSize { get; set; } = 500;
        public bool EnemiesDead { get; set; } = true;
        public int MaxLimitWaveSize { get; set; } = 5000;
        public int WaveLevel { get; set; } = 1;

        public int WaveSizeIncreaseConstant = 10;

        public GlobalSpawnComponent()
        {
            Reset();
        }

        public IComponent Reset()
        {
            WaveSize = 3;
            EnemiesDead = true;
            WaveSizeIncreaseConstant = 5;
            return this;
        }
    }
}