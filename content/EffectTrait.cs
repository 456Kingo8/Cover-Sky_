﻿using NeoModLoader.api.attributes;
using UnityEngine;
using ZheTian.content.Abstract;

namespace ZheTian.content;

public partial class Trait  : ExtendLibrary<ActorTrait, Trait>
{
    protected override void OnInit()
    {
        AddEffects();
    }
    
    
    private static void AddEffects()
    {
        // 神王体基础效果：血攻加持30%，防御3%
        _shen_wang_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a);
        };


    }
    [Hotfixable]
    private static BaseStats IsDivineKingBodyUpgraded(Actor actor)
    {
        //小成
        if (actor.GetCultisysLevel() > 4 && actor.GetCultisysLevel() < 11)
        {
            Debug.Log("升级成功！");
            return new BaseStats()
            {
                [S.mod_damage] = 0.5f,
            };
        }
        else if (actor.GetCultisysLevel() >= 11)
        {
            Debug.Log("升级成功！");
            return new BaseStats()
            {
                [S.mod_damage] = 0.7f,
            };
        }
        actor.updateStats(); // 更新角色状态
        return null;
    }


}