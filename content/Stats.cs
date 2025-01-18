﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZheTian.content.Abstract;

namespace ZheTian.content
{
    internal class Stats : ExtendLibrary<BaseStatAsset, Stats>
    {
        private const string stat_id_prefix = ModClass.asset_id_prefix;

        public static BaseStatAsset zheTianAir;

        public static BaseStatAsset zheTianAir_regen;

        public static BaseStatAsset stats_stacked_effect;

        protected override void OnInit()
        {
            RegisterAssets(stat_id_prefix);
            //stats_stacked_effect.show_as_percents = true;
            //stats_stacked_effect.tooltip_multiply_for_visual_number = 100;
        }
    }
}
