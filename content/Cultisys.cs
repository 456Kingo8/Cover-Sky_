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

            _level_exp_required[0] = 500;
            _level_exp_required[1] = 1000;
            _level_exp_required[2] = 2000;
            _level_exp_required[3] = 8000;
            _level_exp_required[4] = 300000;
            _level_exp_required[5] = 1200000;
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


            stats = _level_stats[2];
            stats[Stats.zheTianAir.id] = 60;
            stats[Stats.zheTianAir_regen.id] = 1;
            stats[S.health] = 400;
            stats[S.damage] = 60;


            stats = _level_stats[3];
            stats[Stats.zheTianAir.id] = 100;
            stats[Stats.zheTianAir_regen.id] = 2;
            stats[S.health] = 1000;
            stats[S.damage] = 100;
            stats[S.speed] = 40;


            stats = _level_stats[4];
            stats[Stats.zheTianAir.id] = 400;
            stats[Stats.zheTianAir_regen.id] = 4;
            stats[S.health] = 10000;
            stats[S.damage] = 200;
            stats[S.speed] = 40;
            stats[S.max_age] = 300;


            stats = _level_stats[5];
            stats[Stats.zheTianAir.id] = 2000;
            stats[Stats.zheTianAir_regen.id] = 100;
            stats[S.health] = 100000;
            stats[S.damage] = 1000;
            stats[S.speed] = 40;
            stats[S.max_age] = 750;


            stats = _level_stats[6];
            stats[Stats.zheTianAir.id] = 40000;
            stats[Stats.zheTianAir_regen.id] = 500;
            stats[S.health] = 2000000;
            stats[S.damage] = 2000;
            stats[S.speed] = 80;
            stats[S.max_age] = 4000;
            stats[S.knockback_reduction] = 10000;
        }

        public static ReadOnlyCollection<BaseStats> LevelStats { get; }
        public static ReadOnlyCollection<float> LevelExpRequired { get; }

        public static ReadOnlyCollection<string> TraitsBlacklist { get; } = new(_traits_blacklist);

        public static ReadOnlyCollection<string> StatusesBlacklist { get; } = new(_statuses_blacklist);

        public static string GetName(int level)
        {
            level = Math.Min(MaxLevel, Math.Max(level, 0));
            return LM.Get($"{ModClass.asset_id_prefix}.wudao.{level}");
        }
    }
}
