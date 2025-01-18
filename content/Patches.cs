using HarmonyLib;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ZheTian.content
{
    internal class Patches
    {
        private static void addition_stats(Actor actor_base)
        {
            var level = actor_base.a.GetCultisysLevel();
            if (level >= 0) actor_base.stats.mergeStats(Cultisys.LevelStats[level]);

        }

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

        
    }
}
