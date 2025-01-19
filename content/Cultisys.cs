using NeoModLoader.General;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZheTian.content
{
    internal class Cultisys
    {
        public const int MaxLevel = 15;
        private static readonly BaseStats[] _level_stats;
        private static readonly float[] _level_exp_required;

        private static readonly string[] _traits_blacklist =
        {
        "eyepatch", "crippled", "cursed", "tumorInfection", "mushSpores", "plague", "skin_burns"
        };

        private static readonly string[] _statuses_blacklist =
        {
        "cough", "ash_fever"
        };

        static Cultisys()
        {
            _level_stats = new BaseStats[MaxLevel + 1];
            _level_exp_required = new float[MaxLevel];
            for (var i = 0; i <= MaxLevel; i++) _level_stats[i] = new BaseStats();

            _level_exp_required[0] = 100;
            _level_exp_required[1] = 200;
            _level_exp_required[2] = 400;
            _level_exp_required[3] = 1000;
            _level_exp_required[4] = 2000;
            _level_exp_required[5] = 2000;
            _level_exp_required[6] = 3000;
            _level_exp_required[7] = 3000;
            _level_exp_required[8] = 4000;
            _level_exp_required[9] = 5000;
            _level_exp_required[10] = 10000;
            _level_exp_required[11] = 100000;
            LevelExpRequired = new ReadOnlyCollection<float>(_level_exp_required);
            LevelStats = new ReadOnlyCollection<BaseStats>(_level_stats);

            BaseStats stats = _level_stats[0];
            stats[Stats.zheTianAir.id] = 40;
            stats[Stats.zheTianAir_regen.id] = 0.5f;


            stats = _level_stats[1];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 150;

            stats = _level_stats[2];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 500;

            stats = _level_stats[3];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 800;

            stats = _level_stats[4];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 1000;

            stats = _level_stats[5];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 1500;

            stats = _level_stats[6];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 2500;

            stats = _level_stats[7];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 3000;

            stats = _level_stats[8];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 4000;

            stats = _level_stats[9];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 5000;

            stats = _level_stats[10];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 6800;

            stats = _level_stats[11];
            stats[Stats.zheTianAir.id] = 50;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 200;
            stats[S.damage] = 40;
            stats[S.max_age] = 9000;
        }

        public static ReadOnlyCollection<BaseStats> LevelStats { get; }
        public static ReadOnlyCollection<float> LevelExpRequired { get; }



        public static string GetName(int level)
        {
            level = Math.Min(MaxLevel, Math.Max(level, 0));
            return LM.Get($"{ModClass.asset_id_prefix}.zhetian.{level}");
        }
    }
}
