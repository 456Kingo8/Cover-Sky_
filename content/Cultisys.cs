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
        private const int pai = 3;
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
            _level_exp_required[3] = 4000;
            _level_exp_required[4] = 9000;
            _level_exp_required[5] = 4000;
            _level_exp_required[6] = 4000;
            _level_exp_required[7] = 25000;
            _level_exp_required[8] = 9000;
            _level_exp_required[9] = 9000;
            _level_exp_required[10] = 10000;
            _level_exp_required[11] = 50000;
            _level_exp_required[12] = 100000;
            LevelExpRequired = new ReadOnlyCollection<float>(_level_exp_required);
            LevelStats = new ReadOnlyCollection<BaseStats>(_level_stats);

            BaseStats stats = _level_stats[0];
            stats[Stats.zheTianAir.id] = 40;
            stats[Stats.zheTianAir_regen.id] = 0.5f;


            stats = _level_stats[1];
            stats[Stats.zheTianAir.id] = 50; 
            stats[Stats.zheTianAir_regen.id] = 1; 
            stats[S.health] = 200; 
            stats[S.damage] = 50; 
            stats[S.max_age] = 150;
            stats[S.mod_armor] = 0;
            stats[S.mod_crit] = 0; 
            stats[S.mod_damage] = 0; 
            stats[S.mod_health] = 0; 
            stats[S.mod_speed] = 0; 
            stats[S.mod_attack_speed] = 0; 

            stats = _level_stats[2];
            stats[Stats.zheTianAir.id] = 100;  
            stats[Stats.zheTianAir_regen.id] = 2; 
            stats[S.health] =1000; 
            stats[S.damage] = 100;
            stats[S.max_age] = 300;


            stats = _level_stats[3];
            stats[Stats.zheTianAir.id] = 150; 
            stats[Stats.zheTianAir_regen.id] = 3; 
            stats[S.health] =1500; 
            stats[S.damage] = 200; 
            stats[S.max_age] = 500;


            stats = _level_stats[4];
            stats[Stats.zheTianAir.id] = 200; 
            stats[Stats.zheTianAir_regen.id] = 4; 
            stats[S.health] = Factorial(4) + 2500; 
            stats[S.damage] = 600; 
            stats[S.max_age] = 800;


            stats = _level_stats[5];
            stats[Stats.zheTianAir.id] = 250; 
            stats[Stats.zheTianAir_regen.id] = 5; 
            stats[S.health] = Factorial(1) * 1000; 
            stats[S.damage] = 1200; 
            stats[S.max_age] = 1000;


            stats = _level_stats[6];
            stats[Stats.zheTianAir.id] = 300; 
            stats[Stats.zheTianAir_regen.id] = 6; 
            stats[S.health] = Factorial(2) * 1000; 
            stats[S.damage] = 2000; 
            stats[S.max_age] = 1500;

            stats = _level_stats[7];
            stats[Stats.zheTianAir.id] = 350; 
            stats[Stats.zheTianAir_regen.id] = 7; 
            stats[S.health] = Factorial(3) * 2000; 
            stats[S.damage] = 3600; 
            stats[S.max_age] = 2500;


            stats = _level_stats[8];
            stats[Stats.zheTianAir.id] = 400; 
            stats[Stats.zheTianAir_regen.id] = 8; 
            stats[S.health] = Factorial(4) * 2000; 
            stats[S.damage] = 5000; 
            stats[S.max_age] = 3000;
            
            stats = _level_stats[9];
            stats[Stats.zheTianAir.id] = 450; 
            stats[Stats.zheTianAir_regen.id] = 9; 
            stats[S.health] = Factorial(5) * 1000;
            stats[S.damage] = 7000;
            stats[S.max_age] = 4000;

            stats = _level_stats[10];
            stats[Stats.zheTianAir.id] = 500; 
            stats[Stats.zheTianAir_regen.id] = 10; 
            stats[S.health] = Factorial(6) * 1000; 
            stats[S.damage] = 10000;
            stats[S.max_age] = 5000;
            
            stats = _level_stats[11];
            stats[Stats.zheTianAir.id] = 550; 
            stats[Stats.zheTianAir_regen.id] = 11; 
            stats[S.health] = Factorial(7) * 50; 
            stats[S.damage] = 20000; 
            stats[S.max_age] = 6800;

            stats = _level_stats[12];
            stats[Stats.zheTianAir.id] = 550; 
            stats[Stats.zheTianAir_regen.id] = 11; 
            stats[S.health] = Factorial(8) * 100; 
            stats[S.damage] = 100000; 
            stats[S.max_age] = 9000;
        }

        public static int Factorial(int value)
        {
            if (value < 0)
                return -1;
            if(value == 1)
                return 1;
            return value * Factorial(value - 1);
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
