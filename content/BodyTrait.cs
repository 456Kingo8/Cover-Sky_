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
        
        private static ActorTrait _yuan_ling_ti { get; set; }

        private static ActorTrait _Hun_dun_ti { get; set; }

        private static ActorTrait _xian_tian_sheng_ti_dao_tai { get; set; }

        private static ActorTrait _xu_kong_zhi_ti { get; set; }

        private static ActorTrait _tian_yao_ti { get; set; }

        private static ActorTrait _tai_yang_shen_ti { get; set; }

        private static ActorTrait _tai_yin_shen_ti { get; set; }
        
        [Hotfixable]
        public void InitBodyTrait()
        {
            TraitAdd(_fan_gu,"FanGu", 0.80f, new Dictionary<string, float>()
            {
                { S.mod_health,0.05f },
                { S.mod_health,0.05f },
                { S.mod_armor,0.01f },
            },"BodyTraitGroup");
            
            TraitAdd(_shen_wang_ti,"ShengWangTi", 0.03f, new Dictionary<string, float>()
            {
                { S.mod_damage,0.3f },
                { S.mod_armor,0.03f },
            },"BodyTraitGroup");

            TraitAdd(_yuan_ling_ti,"YuanLingTi", 0.03f, new Dictionary<string, float>()
            {
                { Stats.mod_talent.id,10f }
            },"BodyTraitGroup");
            
            TraitAdd(_xian_tian_dao_tai,"XianTianDaoTai", 0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f },
                { Stats.mod_talent.id, 0.3f }
            },"BodyTraitGroup");
            
            TraitAdd(_huang_gu_sheng_ti,"HuangGuShengTi", 0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f }
            },"BodyTraitGroup");
            
            TraitAdd(_cang_tian_ba_ti,"CangTianBaTi", 0.005f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.8f },
                { S.mod_damage, 0.8f },
                { S.mod_armor, 0.07f }
            },"BodyTraitGroup");
            
            TraitAdd(_Hun_dun_ti,"HunDunTi", 0.0001f, new Dictionary<string, float>()
            {
                { S.mod_health, 1.2f },
                { S.mod_damage, 1.2f },
                { S.mod_armor, 0.1f }
            },"BodyTraitGroup");
            
            TraitAdd(_xian_tian_sheng_ti_dao_tai,"XianTianShengTiDaoTai", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            },"BodyTraitGroup");

            TraitAdd(_xu_kong_zhi_ti,"XuKongZhiTi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup");

            TraitAdd(_tian_yao_ti,"TianYaoTi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup");

            TraitAdd(_tai_yang_shen_ti,"TaiYangShenTi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup");

            TraitAdd(_tai_yin_shen_ti,"TaiYinShenTi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_health, 0.5f },
                { S.mod_damage, 0.5f },
                { S.mod_armor, 0.05f }
            },"BodyTraitGroup");

            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = "BodyTraitGroup",
                name = "trait_group_body",
                color = Color.cyan
            };

            // 将特性组添加到特性组库
            AssetManager.trait_groups.add(group);
        }

        public static void TraitAdd(ActorTrait trait,string id, float birth, Dictionary<string, float> statDictionary,string group, float inherit = 0,string path_icon = "ui/icons/neomodloader")
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