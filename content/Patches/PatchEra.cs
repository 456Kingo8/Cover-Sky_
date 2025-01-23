using HarmonyLib;
using NeoModLoader.api.attributes;
using NeoModLoader.General.UI.Prefabs;
using UnityEngine;
using ZheTian.content.UI;

namespace ZheTian.content;

public class PatchEra
{
    private static bool _initialized = false;
    
    [HarmonyPrefix]
    [HarmonyPatch(typeof(WorldAgesWindow), "Update")]
    public static bool Update_WorldAgesWindow(WorldAgesWindow __instance)
    {
        foreach(string EraId in ZheTianEra.EraID)
        {
            if (World.world_era == ZheTianEra.Eradict[EraId])
            {
                __instance.selection_effect.gameObject.transform.position = new Vector3(1477777f, 1477777f);
                return false;
            }
        }
        return true;
    }
}