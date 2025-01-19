using NeoModLoader.api;
using ZheTian.content;
using UnityEngine;
using HarmonyLib;

namespace ZheTian
{
    public class ModClass : BasicMod<ModClass>
    {
        internal const string asset_id_prefix = "StartBoard.custommodt001";

        protected override void OnModLoad()
        {
            //两个特质，一个是体质的特质，一个是神通的特质
            //体系升级
            //寿命提升

            BodyTrait.Init();
            AuthorityTrait.Init();
            new Stats().Init();

            Harmony.CreateAndPatchAll(typeof(content.Patches));
            LogInfo(GetConfig()["Default"]["WhatToSay"].GetValue() as string);
        }
    }
}