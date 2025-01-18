using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ZheTian.content
{
    internal static class AuthorityTrait
    {
        public static void Init()
        {
            AuthorityTraitAdd("帝心",1,new Dictionary<string, float>()
            {
                { S.mod_health,200 }
            });

            AuthorityTraitAdd("帝躯", 1, new Dictionary<string, float>()
            {
                { S.mod_damage,300 }
            });

            AuthorityTraitAdd("帝路争锋", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,10 },
                { S.mod_crit,10 },
                { S.mod_health,10 }
            });

            AuthorityTraitAdd("天心印记", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,20 },
                { S.mod_crit,20 },
                { S.mod_health,10 }
            });

            AuthorityTraitAdd("斗战天地", 10, new Dictionary<string, float>()
            {
                { S.mod_damage,70 },
                { S.mod_armor,5 }
            });

            AuthorityTraitAdd("剑决浮云", 10, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            });

            AuthorityTraitAdd("谪仙", 10, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("破神刃甲", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("时间之光", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("不动明王", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("至死方休", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("神藏", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("不死长春", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("无法无天", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("九天玄师", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("仙雷", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("神临", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("百会", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("幽都神盾", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("圣灵", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("骨肉相连", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("道果", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("搬山", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("三昧真火", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("黄金气血", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("六御", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("仙灵明", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("玉玲珑", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("九窍心", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("玄武盾", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("狂风暴雨", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("百足之虫", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("渡仙曲", 5, new Dictionary<string, float>()
{
   
});

            AuthorityTraitAdd("九死一生", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("七星连珠", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("烛龙", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("无量", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("无尽杀伐", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("大道金丹", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("鸿蒙灵光", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("贤者", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("百界千劫", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("剑神", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("武道通天", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("金刚不坏", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("万劫不磨", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("天符", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("不周风", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("阴阳同源", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("真神", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("六十刹那", 5, new Dictionary<string, float>()
{

});

            AuthorityTraitAdd("谋长节短", 5, new Dictionary<string, float>()
{

});

            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = "AuthorityTraitGroup",
                name = "trait_group_Authority",
                color = Color.cyan
            };

            // 将特性组添加到特性组库
            AssetManager.trait_groups.add(group);
        }

        public static void AuthorityTraitAdd(string id, int birth, Dictionary<string, float> statDictionary, string path_icon = "ui/icons/neomodloader")
        {
            ActorTrait trait = new ActorTrait()
            {
                id = id,
                group_id = "AuthorityTraitGroup",
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
