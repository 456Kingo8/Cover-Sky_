using HarmonyLib;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using NeoModLoader.api.attributes;
using UnityEngine.UI;
using UnityEngine;

namespace ZheTian.content
{
    internal class Patches
    {
        private static bool _initialized;

        [Hotfixable]
        private static void addition_stats(Actor actor_base)
        {
            var level = actor_base.a.GetCultisysLevel();
            if (level >= 0) actor_base.stats.mergeStats(Cultisys.LevelStats[level]);
            
            foreach (var trait_id in actor_base.data.s_traits_ids)
            {
                ActorTrait trait = AssetManager.traits.get(trait_id);
                TraitExtend trait_extend = trait.GetExtend();
                BaseStats conditional_stats = trait_extend.conditional_basestats?.Invoke(actor_base.a);
                if (conditional_stats != null) actor_base.stats.mergeStats(conditional_stats);
            }

        }

        [HarmonyTranspiler]
        [HarmonyPatch(typeof(ActorBase), nameof(ActorBase.updateStats))]
        private static IEnumerable<CodeInstruction> ActorBase_updateStats_transpiler(IEnumerable<CodeInstruction> codes)
        {
            var list = codes.ToList();

            var addition_stats_idx = list.FindIndex(x =>
                x.opcode == OpCodes.Callvirt && (x.operand as MemberInfo)?.Name == nameof(BaseStats.normalize)) - 2;
            var add_codes = new List<CodeInstruction>
        {
            new(OpCodes.Ldarg_0),
            new(OpCodes.Call, AccessTools.Method(typeof(Patches), nameof(addition_stats)))
        };
            list[addition_stats_idx].MoveLabelsTo(add_codes[0]);
            list.InsertRange(addition_stats_idx, add_codes);

            return list;
        }

        [Hotfixable]
        [HarmonyPrefix, HarmonyPatch(typeof(WindowCreatureInfo), nameof(WindowCreatureInfo.OnEnable))]
        private static void OnEnable_prefix(WindowCreatureInfo __instance)
        {
            var level = __instance.actor.GetCultisysLevel();
            if (!_initialized)
            {
                _initialized = true;
                var obj = new GameObject("TempInfo", typeof(Text), typeof(ContentSizeFitter));
                obj.transform.SetParent(__instance.transform.Find("Background"));
                //obj.transform.position = new Vector3 (1380,500,300);
                obj.transform.localPosition = new(10180,0,100);
                obj.transform.localScale = Vector3.one;
                obj.GetComponent<RectTransform>().sizeDelta = new Vector2(20000, 100);
            }
            var obj1 = __instance.transform.Find("Background/TempInfo");

            obj1.GetComponent<Text>().text = "当前境界：" + Cultisys.GetName(level) +
                    "\n修炼进度:" + __instance.actor.GetExp() + "/" + Cultisys.LevelExpRequired[level] +
                    "\n天赋：" + __instance.actor.GetTalent() +
                    "\n修炼速度：" + __instance.actor.GetModTalent() * 100 + '%' +
                    "\n最大寿命:" + __instance.actor.stats[S.max_age];
            obj1.GetComponent<Text>().font = LocalizedTextManager.currentFont;
        }
        [Hotfixable]
        [HarmonyPostfix]
        [HarmonyPatch(typeof(Actor), nameof(Actor.updateAge))]
        private static void Actor_updateAge_postfix(Actor __instance)
        {
            var level = __instance.GetCultisysLevel();
            if (level >= Cultisys.MaxLevel) return;
            var talent = __instance.GetTalent();
            var mod_talent = __instance.GetModTalent();
            __instance.IncExp(talent * mod_talent);
            if (__instance.GetExp() >= Cultisys.LevelExpRequired[level] && level < 12)
            {
                __instance.LevelUp();
                __instance.ResetExp();
                Debug.Log($"{__instance.GetExp()} / {Cultisys.LevelExpRequired[level]}");
            }
        }


    }
}
