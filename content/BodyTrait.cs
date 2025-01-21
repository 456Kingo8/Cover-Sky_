using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using NeoModLoader.api.attributes;
using UnityEngine;

namespace ZheTian.content
{
    public partial class Trait
    {
        private static ActorTrait _shen_wang_ti { get; set; }
        
        private static ActorTrait _Xian_tian_dao_tai { get; set; }

        private static ActorTrait _Huang_gu_sheng_ti { get; set; }

        private static ActorTrait _Cang_tian_ba_ti { get; set; }
        
        private static ActorTrait _yuan_ling_ti { get; set; }

        private static ActorTrait _Hun_dun_ti { get; set; }

        private static ActorTrait _Xian_tian_sheng_ti_dao_tai { get; set; }

        private static ActorTrait _Xu_kong_zhi_ti { get; set; }

        private static ActorTrait _Tian_yao_ti { get; set; }

        private static ActorTrait _Tai_yang_shen_ti { get; set; }

        private static ActorTrait _Tai_yin_shen_ti { get; set; }
        
        [Hotfixable]
        public static void Init()
        {
            BodyTraitAdd(_shen_wang_ti,"ShengWangTi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_damage,0.3f },
                { S.mod_armor,0.03f },
                { Stats.mod_talent.id,100000f}
            });

            BodyTraitAdd(_yuan_ling_ti,"YuanLingTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd(_Xian_tian_dao_tai,"XianTianDaoTai", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd(_Huang_gu_sheng_ti,"HuangGuShengTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd(_Cang_tian_ba_ti,"CangTianBaTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd(_Hun_dun_ti,"HunDunTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd(_Xian_tian_sheng_ti_dao_tai,"XianTianShengTiDaoTai", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });

            BodyTraitAdd(_Xu_kong_zhi_ti,"XuKongZhiTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health, 50 },
                { S.speed, 100 },
                { S.intelligence, 50 }
            });

            BodyTraitAdd(_Tian_yao_ti,"TianYaoTi", 0.01f, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd(_Tai_yang_shen_ti,"TaiYangShenTi", 0.01f, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd(_Tai_yin_shen_ti,"TaiYinShenTi", 0.01f, new Dictionary<string, float>()
            {

            });

            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = "BodyTraitGroup",
                name = "trait_group_body",
                color = Color.cyan
            };

            // 将特性组添加到特性组库
            AssetManager.trait_groups.add(group);
        }

        public static void BodyTraitAdd(ActorTrait trait,string id, float birth, Dictionary<string, float> statDictionary, float inherit = 0,string path_icon = "ui/icons/neomodloader")
        {
            trait = new ActorTrait()
            {
                id = id,
                group_id = "BodyTraitGroup",
                path_icon = path_icon,
                birth = birth,
                inherit = inherit,
                needs_to_be_explored = false
            };
            foreach (var kvp in statDictionary)
            {
                trait.base_stats[kvp.Key] = kvp.Value;
            }

            AssetManager.traits.add(trait);
        }
        
        
    }
}