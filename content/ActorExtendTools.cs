using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ZheTian.content
{
    public static class ActorExtendTools
    {
        //目前用不到
        private const string key_prefix = ModClass.asset_id_prefix;

        private const string cultisys_level_key = $"{key_prefix}.zhetian_level";

        private const string exp_key = $"{key_prefix}.zhetian_exp";

        private const string talent_key = $"{key_prefix}.talent";

        public static int GetCultisysLevel(this Actor actor)
        {
            actor.data.get(cultisys_level_key, out int level);
            return level;
        }

        public static float GetExp(this Actor actor)
        {
            actor.data.get(exp_key, out float exp);
            return exp;
        }

        public static void IncExp(this Actor actor, float value)
        {
            actor.data.set(exp_key, actor.GetExp() + value);
        }

        public static void ResetExp(this Actor actor)
        {
            actor.data.set(exp_key, 0);
        }

        public static void LevelUp(this Actor actor)
        {
            var level = actor.GetCultisysLevel();
            if (level >= Cultisys.MaxLevel) return;
            level++;
            actor.data.set(cultisys_level_key, level);

 
            switch (level)
            {
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                    
                    break;
                case 5:
                    
                    break;
                case 6:
                   
                    break;
            }

            

            actor.event_full_heal = true;
            actor.setStatsDirty();
        }

        public static float GetTalent(this Actor actor)
        {
            actor.data.get(talent_key, out float talent, -1);
            if (talent < 0)
            {
                if (actor.asset.isBoat)
                {
                    talent = 0;
                }
                else
                {
                    const int num = 100000;
                    int v = UnityEngine.Random.Range(0,100000);
                    if (v < num * 0.001 * 0.01)
                        talent = 50;
                    else if (v < num * (0.1 + 0.001) * 0.01)
                        talent = 30;
                    else if (v < num * (0.1 + 0.001 + 1.899) * 0.01)
                        talent = 15;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 3) * 0.01)
                        talent = 9;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 3 + 5) * 0.01)
                        talent = 7;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 3.5 + 10) * 0.01)
                        talent = 5;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 3.5 + 10 + 20) * 0.01)
                        talent = 1;
                    else
                        talent = 0;
                    //资质
                    //无才0，彻彻底底的普通人，60 %
                    //庸才5，每年获取5，20 %
                    //普通10，每年获得10，10 %
                    //中人15，每年获得15，5 %
                    //天才20，每年，3 %
                    //妖孽30，每年，1.899 %
                    //帝资35，每年，0.1 %
                    //仙姿50，每年，0.001 %
                }

                actor.data.set(talent_key, talent);
            }

            return talent;
        }

    }
}
