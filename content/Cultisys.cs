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
            stats[Stats.zheTianAir.id] = 50; // 初始值
            stats[Stats.zheTianAir_regen.id] = 1; // 初始值
            stats[S.health] = 200; // 初始值
            stats[S.damage] = 40; // 初始值
            stats[S.max_age] = 150;
            stats[S.mod_armor] = 0; // 初始值
            stats[S.mod_crit] = 0; // 初始值
            stats[S.mod_damage] = 0; // 初始值
            stats[S.mod_health] = 0; // 初始值
            stats[S.mod_speed] = 0; // 初始值
            stats[S.mod_attack_speed] = 0; // 初始值

            stats = _level_stats[2];
            stats[Stats.zheTianAir.id] = 100;  // 增加 50
            stats[Stats.zheTianAir_regen.id] = 2; // 增加 1
            stats[S.health] = 400; // 翻倍
            stats[S.damage] = 80; // 翻倍
            stats[S.max_age] = 500;
            stats[S.mod_armor] = 5;
            stats[S.mod_crit] = 5;
            stats[S.mod_damage] = 10;
            stats[S.mod_health] = 10;
            stats[S.mod_speed] = 2;
            stats[S.mod_attack_speed] = 0.05f;

            stats = _level_stats[3];
            stats[Stats.zheTianAir.id] = 150; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 3; // 增加 1
            stats[S.health] = 800; // 翻倍
            stats[S.damage] = 160; // 翻倍
            stats[S.max_age] = 800;
            stats[S.mod_armor] = 10;
            stats[S.mod_crit] = 10;
            stats[S.mod_damage] = 20;
            stats[S.mod_health] = 20;
            stats[S.mod_speed] = 4;
            stats[S.mod_attack_speed] = 0.1f;

            stats = _level_stats[4];
            stats[Stats.zheTianAir.id] = 200; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 4; // 增加 1
            stats[S.health] = 1600; // 翻倍
            stats[S.damage] = 320; // 翻倍
            stats[S.max_age] = 1000;
            stats[S.mod_armor] = 15;
            stats[S.mod_crit] = 15;
            stats[S.mod_damage] = 30;
            stats[S.mod_health] = 30;
            stats[S.mod_speed] = 6;
            stats[S.mod_attack_speed] = 0.15f;

            stats = _level_stats[5];
            stats[Stats.zheTianAir.id] = 250; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 5; // 增加 1
            stats[S.health] = 3200; // 翻倍
            stats[S.damage] = 640; // 翻倍
            stats[S.max_age] = 1500;
            stats[S.mod_armor] = 20;
            stats[S.mod_crit] = 20;
            stats[S.mod_damage] = 40;
            stats[S.mod_health] = 40;
            stats[S.mod_speed] = 8;
            stats[S.mod_attack_speed] = 0.2f;

            stats = _level_stats[6];
            stats[Stats.zheTianAir.id] = 300; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 6; // 增加 1
            stats[S.health] = 6400; // 翻倍
            stats[S.damage] = 1280; // 翻倍
            stats[S.max_age] = 2500;
            stats[S.mod_armor] = 25;
            stats[S.mod_crit] = 25;
            stats[S.mod_damage] = 50;
            stats[S.mod_health] = 50;
            stats[S.mod_speed] = 10;
            stats[S.mod_attack_speed] = 0.25f;

            stats = _level_stats[7];
            stats[Stats.zheTianAir.id] = 350; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 7; // 增加 1
            stats[S.health] = 12800; // 翻倍
            stats[S.damage] = 2560; // 翻倍
            stats[S.max_age] = 3000;
            stats[S.mod_armor] = 30;
            stats[S.mod_crit] = 30;
            stats[S.mod_damage] = 60;
            stats[S.mod_health] = 60;
            stats[S.mod_speed] = 12;
            stats[S.mod_attack_speed] = 0.3f;

            stats = _level_stats[8];
            stats[Stats.zheTianAir.id] = 400; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 8; // 增加 1
            stats[S.health] = 25600; // 翻倍
            stats[S.damage] = 5120; // 翻倍
            stats[S.max_age] = 4000;
            stats[S.mod_armor] = 35;
            stats[S.mod_crit] = 35;
            stats[S.mod_damage] = 70;
            stats[S.mod_health] = 70;
            stats[S.mod_speed] = 14;
            stats[S.mod_attack_speed] = 0.35f;

            stats = _level_stats[9];
            stats[Stats.zheTianAir.id] = 450; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 9; // 增加 1
            stats[S.health] = 51200; // 翻倍
            stats[S.damage] = 10240; // 翻倍
            stats[S.max_age] = 5000;
            stats[S.mod_armor] = 40;
            stats[S.mod_crit] = 40;
            stats[S.mod_damage] = 80;
            stats[S.mod_health] = 80;
            stats[S.mod_speed] = 16;
            stats[S.mod_attack_speed] = 0.4f;

            stats = _level_stats[10];
            stats[Stats.zheTianAir.id] = 500; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 10; // 增加 1
            stats[S.health] = 102400; // 翻倍
            stats[S.damage] = 20480; // 翻倍
            stats[S.max_age] = 6800;
            stats[S.mod_armor] = 45;
            stats[S.mod_crit] = 45;
            stats[S.mod_damage] = 90;
            stats[S.mod_health] = 90;
            stats[S.mod_speed] = 18;
            stats[S.mod_attack_speed] = 0.45f;

            stats = _level_stats[11];
            stats[Stats.zheTianAir.id] = 550; // 增加 50
            stats[Stats.zheTianAir_regen.id] = 11; // 增加 1
            stats[S.health] = 204800; // 翻倍
            stats[S.damage] = 40960; // 翻倍
            stats[S.max_age] = 9000;
            stats[S.mod_armor] = 50;
            stats[S.mod_crit] = 50;
            stats[S.mod_damage] = 100;
            stats[S.mod_health] = 100;
            stats[S.mod_speed] = 20;
            stats[S.mod_attack_speed] = 0.5f;
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
