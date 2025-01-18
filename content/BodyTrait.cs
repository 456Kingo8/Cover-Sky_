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
            BodyTraitAdd("神王体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });

            BodyTraitAdd("元灵体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("先天道胎", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("荒古圣体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("苍天霸体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("混沌体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("先天圣体道胎", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });
            BodyTraitAdd("虚空之体", 5, new Dictionary<string, float>()
            {
                { S.health,100 }
            });

            BodyTraitAdd("虚空之体", 15, new Dictionary<string, float>()
            {
                { S.health, 50 },
                { S.speed, 100 },
                { S.intelligence, 50 }
            });

            BodyTraitAdd("天妖体", 25, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd("太阳神体", 10, new Dictionary<string, float>()
            {

            });

            BodyTraitAdd("太阴神体", 10, new Dictionary<string, float>()
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

        public static void BodyTraitAdd(string id, int birth, Dictionary<string, float> statDictionary, string path_icon = "ui/icons/neomodloader")
        {
            ActorTrait trait = new ActorTrait()
            {
                id = id,
                group_id = "BodyTraitGroup",
                path_icon = path_icon,
                birth = birth,
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
