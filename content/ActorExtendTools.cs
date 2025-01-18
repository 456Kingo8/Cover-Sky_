using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZheTian.content
{
    public static class ActorExtendTools
    {
        //目前用不到
        private const string key_prefix = ModClass.asset_id_prefix;

        private const string cultisys_level_key = $"{key_prefix}.zhetian_level";

        private const string exp_key = $"{key_prefix}.zhetian_exp";

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

            var trait_list = actor.data.traits;
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

            if (level >= 5)
            {
                foreach (var blacklist_trait_id in Cultisys.TraitsBlacklist) actor.removeTrait(blacklist_trait_id);

                foreach (var blacklist_status_id in Cultisys.StatusesBlacklist)
                    actor.finishStatusEffect(blacklist_status_id);
            }

            actor.event_full_heal = true;
            actor.setStatsDirty();
        }

    }
}
