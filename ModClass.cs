﻿using System;
using System.IO;
using System.Reflection;
using NeoModLoader.api;
using ZheTian.content;
using UnityEngine;
using HarmonyLib;
using NeoModLoader.General;
using NeoModLoader.utils;

namespace ZheTian
{
    public class ModClass : BasicMod<ModClass>, IReloadable
    {
        internal const string asset_id_prefix = "StartBoard.custommodt001";

        protected override void OnModLoad()
        {
            //两个特质，一个是体质的特质，一个是神通的特质
            //体系升级
            //寿命提升
            Config.isEditor = true;
            
            new Stats().Init();
            Trait.Init();
            AuthorityTrait.Init();
            
            

            Harmony.CreateAndPatchAll(typeof(content.Patches));
            LogInfo(GetConfig()["Default"]["WhatToSay"].GetValue() as string);
        }

        public void Reload()
        {
            LoadLocales();
            typeof(ResourcesPatch).GetMethod("LoadResourceFromFolder", BindingFlags.Static | BindingFlags.NonPublic)
                ?.Invoke(null,
                    new object[] { Path.Combine(GetDeclaration().FolderPath, "GameResources") });
        }
        private void LoadLocales()
        {
            var folder = GetLocaleFilesDirectory(GetDeclaration());

            if (!Directory.Exists(folder))
                return;

            var files = Directory.GetFiles(folder, "*", SearchOption.AllDirectories);
            foreach (var locale_file in files)
            {
                try
                {
                    if (locale_file.EndsWith(".json"))
                    {
                        LM.LoadLocale(Path.GetFileNameWithoutExtension(locale_file), locale_file);
                    }
                    else if (locale_file.EndsWith(".csv"))
                    {
                        LM.LoadLocales(locale_file);
                    }
                }
                catch (FormatException e)
                {
                    LogWarning(e.Message);
                }
            }

            LM.ApplyLocale();
        }
    }
}