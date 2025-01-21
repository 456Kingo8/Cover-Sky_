﻿using NeoModLoader.api.attributes;
using UnityEngine;
using ZheTian.content.Abstract;

namespace ZheTian.content;

public partial class Trait  : ExtendLibrary<ActorTrait, Trait>
{
    private const string stat_id_prefix = ModClass.asset_id_prefix;
    
    protected override void OnInit()
    {
        RegisterAssets(stat_id_prefix);
        InitBodyTrait();
        InitAuthorityTrait();
        AddEffects();
    }
    
    private void AddEffects()
    {
        _shen_wang_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a);
        };


    }
    [Hotfixable]
    private BaseStats IsDivineKingBodyUpgraded(Actor actor)
    {
        Debug.Log("调用函数");
        //小成
        if (actor.GetCultisysLevel() > 4 && actor.GetCultisysLevel() < 11)
        {
            Debug.Log("升级成功！1111");
            return new BaseStats()
            {
                [S.mod_damage] = 0.5f,
            };
        }
        else if (actor.GetCultisysLevel() >= 11)
        {
            Debug.Log("升级成功！2222");
            return new BaseStats()
            {
                [S.mod_damage] = 0.7f,
            };
        }
        actor.updateStats(); // 更新角色状态
        return null;
    }


}