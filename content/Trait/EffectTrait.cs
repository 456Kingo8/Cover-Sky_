using NeoModLoader.api.attributes;
using UnityEngine;
using ZheTian.content.Abstract;

namespace ZheTian.content;

public partial class Trait  : ExtendLibrary<ActorTrait, Trait>
{
    private const string stat_id_prefix = ModClass.asset_id_prefix;
    
    protected override void OnInit()
    {
        RegisterAssets(stat_id_prefix);
        InitActorTraitGroup();
        InitBodyTrait();
        InitAuthorityTrait();
        AddEffects();
    }
    
    private void AddEffects()
    {
        //C级体质实现了基础:血攻加持30%，防御3%（小成，大成）
        _shen_wang_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,0.5f,0.7f,0.03f,0.03f);
        };
        _yuan_lin_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a, 0.5f, 0.7f, 0.03f, 0.03f);
        };
        
        //B级体质实现了基础:血攻加持50%，防御5%（小成，大成）
        _xu_kong_zhi_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,0.7f,0.9f,0.05f,0.05f);
        };
        _tian_yao_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,0.7f,0.9f,0.05f,0.05f);
        };
        _tai_yang_shen_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,0.7f,0.9f,0.05f,0.05f);
        };
        _tai_yin_shen_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,0.7f,0.9f,0.05f,0.05f);
        };
        
        //A级体质实现了基础:血攻80%，防御7%（小成，大成）
        _xian_tian_dao_tai.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,1f,1.5f,0.07f,0.07f);
        };
        _cang_tian_ba_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,1f,1.5f,0.07f,0.07f);
        };
        _huang_gu_sheng_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,1f,1.5f,0.07f,0.07f);
        };
        
        //S级体质实现了基础:血攻120%，防御10%（小成，大成）
        _hun_dun_ti.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,1.5f,2f,0.1f,0.1f);
        };
        _xian_tian_sheng_ti_dao_tai.GetExtend().conditional_basestats = a =>
        {
            return IsDivineKingBodyUpgraded(a,1.5f,2f,0.1f,0.1f);
        };
        
        
        //神王体，对比自己低的境界有5%概率秒杀
        _shen_wang_ti.action_attack_target = (actor, target, tile) =>
        {
            if (!target.isActor()) return true;
            if (actor.a.GetCultisysLevel() > target.a.GetCultisysLevel())
            {
                if (Toolbox.randomChance(0.05f))
                {
                    target.a.attackedBy = actor;
                    target.a.killHimself(true, pLaunchCallbacks: false);
                }
                return true;
            }
            return false;
        };
        
        
        
        //天妖体，战斗中变大，攻速加10%，伤害减免10%
        _tian_yao_ti.action_attack_target = (actor, target, tile) =>
        {
            return false;
        };
        
        //太阳神体，攻击附有灼烧
        _tai_yang_shen_ti.action_attack_target = (actor, target, tile) =>
        {
            ActionLibrary.addBurningEffectOnTarget(actor, target, tile);
            return false;
        };
        
        //太阴神体，攻击附有冰冻
        _tai_yin_shen_ti.action_attack_target = (actor, target, tile) =>
        {
            if(target.isAlive() && target.isActor() && !target.a.hasTrait("freeze_proof"))
            {
                target.addStatusEffect("frozen");
            }
            return false;
        };
        
        //荒古圣体，攻击附有攻速延缓
        _huang_gu_sheng_ti.action_attack_target = (actor, target, tile) =>
        {
            if(target.isAlive() && target.isActor())
            {
                target.addStatusEffect("slowness");
            }
            return false;
        };
        //苍天霸体，攻击可能（10%）引发地震
        _cang_tian_ba_ti.action_attack_target = (actor, target, tile) =>
        {
            if(Toolbox.randomChance(0.1f))
            {
                World.world.earthquakeManager.startQuake(tile);
            }
            return false;
        };
    }
    [Hotfixable]
    private BaseStats IsDivineKingBodyUpgraded(Actor actor,float damage,float damage2,float armor = 0f,float armor2 = 0f)
    {
        //小成
        if (actor.GetCultisysLevel() > 4 && actor.GetCultisysLevel() < 11)
        {
            return new BaseStats()
            {
                [S.mod_damage] = damage,
                [S.mod_armor] = armor,
            };
        }
        else if (actor.GetCultisysLevel() >= 11)
        {
            return new BaseStats()
            {
                [S.mod_damage] = damage2,
                [S.mod_armor] = armor2,
            };
        }
        actor.updateStats(); // 更新角色状态
        return null;
    }
}