using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NeoModLoader.api.attributes;
using UnityEngine;
using Debug = UnityEngine.Debug;

namespace ZheTian.content
{
    public partial class Trait
    {
        private static ActorTrait _shen_wang_ti { get; set; }
        private static ActorTrait _fan_gu { get; set; }
        
        private static ActorTrait _xian_tian_dao_tai { get; set; }

        private static ActorTrait _huang_gu_sheng_ti { get; set; }

        private static ActorTrait _cang_tian_ba_ti { get; set; }
        
        private static ActorTrait _yuan_lin_ti { get; set; }

        private static ActorTrait _hun_dun_ti { get; set; }

        private static ActorTrait _xian_tian_sheng_ti_dao_tai { get; set; }

        private static ActorTrait _xu_kong_zhi_ti { get; set; }

        private static ActorTrait _tian_yao_ti { get; set; }

        private static ActorTrait _tai_yang_shen_ti { get; set; }

        private static ActorTrait _tai_yin_shen_ti { get; set; }
        
        [Hotfixable]
        public void InitBodyTrait()
        {
            TraitAdd(_fan_gu, 0.80f, new Dictionary<string, float>()
            {
                { S.mod_health,0.05f },
                { S.mod_armor,0.01f },
            },"BodyTraitGroup",0.8f,"trait/body/C--凡骨");
            
            TraitAdd(_shen_wang_ti, 0.03f, new Dictionary<string, float>()
            {
                { S.mod_damage,0.3f },
                { S.mod_armor,0.03f },
            },"BodyTraitGroup",0.01f,"trait/body/C--神王体");

            TraitAdd(_yuan_lin_ti,0.03f, new Dictionary<string, float>()
            {
                { Stats.mod_talent.id,0.1f }
            },"BodyTraitGroup",0.001f,"trait/body/C--元灵体");
            
            TraitAdd(_xian_tian_dao_tai,0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f },
                { Stats.mod_talent.id, 0.3f }
            },"BodyTraitGroup",0.001f,"trait/body/C--先天道胎");
            
            TraitAdd(_huang_gu_sheng_ti, 0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f }
            },"BodyTraitGroup",0.001f,"trait/body/C--荒古圣体");
            
            TraitAdd(_cang_tian_ba_ti,0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f }
            },"BodyTraitGroup",0.001f,"trait/body/C--苍天霸体");
            
            TraitAdd(_hun_dun_ti, 0.0001f, new Dictionary<string, float>()
            {
                { S.mod_health, 1.2f },
                { S.mod_damage, 1.2f },
                { S.mod_armor, 0.1f }
            },"BodyTraitGroup",0.001f,"trait/body/C--混沌体");
            
            TraitAdd(_xian_tian_sheng_ti_dao_tai, 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            },"BodyTraitGroup",0.001f,"trait/body/C--先天圣体道胎");

            TraitAdd(_xu_kong_zhi_ti,0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup", 0.001f,"trait/body/C--虚空体");

            TraitAdd(_tian_yao_ti,0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup",0.001f,"trait/body/C--天妖体");

            TraitAdd(_tai_yang_shen_ti, 0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup",0.001f,"trait/body/C--太阳神体");

            TraitAdd(_tai_yin_shen_ti,0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup",0.001f,"trait/body/C--太阴神体");
        }

        public static void TraitAdd(ActorTrait trait, float birth, Dictionary<string, float> statDictionary,string group, float inherit = 0,string path_icon = "ui/icons/neomodloader")
        {
            trait.group_id = group;
            trait.birth = birth;
            trait.inherit = inherit;
            trait.needs_to_be_explored = false;
            trait.path_icon = path_icon;
            foreach (var kvp in statDictionary)
            {
                trait.base_stats[kvp.Key] = kvp.Value;
            }
        }
        
        
    }
}