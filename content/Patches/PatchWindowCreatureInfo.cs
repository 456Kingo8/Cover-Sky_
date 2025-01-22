using HarmonyLib;
using NeoModLoader.api.attributes;
using NeoModLoader.General.UI.Prefabs;
using UnityEngine;
using ZheTian.content.UI;

namespace ZheTian.content;

public class PatchWindowCreatureInfo
{
    private static bool _initialized = false;
    
    [Hotfixable]
    [HarmonyPrefix, HarmonyPatch(typeof(WindowCreatureInfo), nameof(WindowCreatureInfo.OnEnable))]
    private static void OnEnable_prefix(WindowCreatureInfo __instance)
    {
        // if (!(__instance.actor?.isAlive() ?? false)) return;
        // SimpleButton button = Object.Instantiate(SimpleButton.Prefab, __instance.transform.Find("Background"));
        // button.transform.localPosition = new Vector3(-250, 0);
        // button.transform.localScale = Vector3.one;
        // button.Setup(WindowNewCreatureInfo.Show, SpriteTextureLoader.getSprite("cultiway/icons/iconCultivation"));

    }
}