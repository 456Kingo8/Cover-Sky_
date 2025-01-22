using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NeoModLoader.api.attributes;
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
        public static float GetModTalent(this Actor actor)
        {
            actor.data.get(Stats.mod_talent.id,out float mod_talent);
            return mod_talent + actor.stats[Stats.mod_talent.id];
        }

        public static void IncExp(this Actor actor, float value)
        {
            actor.data.set(exp_key, actor.GetExp() + value);
        }
        [Hotfixable]
        public static void ResetExp(this Actor actor)
        {
            actor.data.set(exp_key, 0f);
        }
        [Hotfixable]
        public static void LevelUp(this Actor actor)
        {
            var level = actor.GetCultisysLevel();
            if (level >= Cultisys.MaxLevel) return;
            level++;
            actor.data.set(cultisys_level_key, level);

            actor.event_full_heal = true;
            actor.setStatsDirty();
        }

        public static void SetLevel(this Actor actor,int level)
        {
            level = Mathf.Clamp(level,0,12);
            actor.data.set(cultisys_level_key, level);
            actor.setStatsDirty();
        }

        public static void SetTalent(this Actor actor,float talent)
        {
            talent = Mathf.Max(talent,0);
            actor.data.set(talent_key, talent);
        }

        public static float GetTalent(this Actor actor)
        {
            actor.data.get(talent_key, out float talent, -1);
            if (talent < 0)
            {
                actor.data.set(Stats.mod_talent.id,1f);
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
                    else if (v < num * (0.1 + 0.001 + 1.899 + 2) * 0.01)
                        talent = 9;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 2 + 4) * 0.01)
                        talent = 7;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 2 + 4 + 7) * 0.01)
                        talent = 5;
                    else if (v < num * (0.1 + 0.001 + 1.899 + 2 + 4 + 7 + 15) * 0.01)
                        talent = 1;
                    else
                        talent = 0;
                }

                actor.data.set(talent_key, talent);
            }

            return talent;
        }

    }
}
