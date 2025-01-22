using System.Collections.Generic;
using System.Diagnostics;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using NeoModLoader.General.UI.Tab;
using UnityEngine;

namespace ZheTian.content;

public class ZheTianTab
{
    public const string INFO = "info";
    public const string DISPLAY = "display";
    public const string CREATURE = "creature";
    public static PowersTab tab;
    
    [Hotfixable]
    public static void Init()
    {
        tab = TabManager.CreateTab("zhe_tian", "tab_zhe_tian", "hotkey_tip_tab_other",
            SpriteTextureLoader.getSprite("ui/icons/iconSteam"));
        // 设置标签页的布局. 布局是一个字符串列表, 每个字符串是一个分类. 每个分类的名字不重要.
        tab.SetLayout(new List<string>()
        {
            INFO,
            DISPLAY,
            CREATURE
        });
        
        // 向标签页添加按钮.
        _addButtons();
        // 更新标签页的布局.
        tab.UpdateLayout();
    }

    private static void _addButtons()
    {
        tab.AddPowerButton(DISPLAY,PowerButtonCreator.CreateSimpleButton("_hei_an_dong_luan",ZheTianEra.DarkChaosStart,SpriteTextureLoader.getSprite("ui/icons/neomodloader") ) );
    }


}