using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UnityEngine;

namespace ZheTian.content
{
    internal static class BodyTrait
    {
        public static void Init()
        {
            BodyTraitAdd("ShengWangTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });

            BodyTraitAdd("YuanLingTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("XianTianDaoTai", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("HuangGuShengTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("CangTianBaTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("HunDunTi", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("XianTianShengTiDaoTai", 0.01f, new Dictionary<string, float>()
            {
                { S.health,100 }
            });

            BodyTraitAdd("XuKongZhiTi", 10.01f, new Dictionary<string, float>()
            {
                { S.health, 50 },
                { S.speed, 100 },
                { S.intelligence, 50 }
            });

            BodyTraitAdd("TianYaoTi", 0.01f, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd("TaiYangShenTi", 0.01f, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd("TaiYinShenTi", 0.01f, new Dictionary<string, float>()
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

        public static void BodyTraitAdd(string id, float birth, Dictionary<string, float> statDictionary, float inherit = 0,string path_icon = "ui/icons/neomodloader")
        {
            ActorTrait trait = new ActorTrait()
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