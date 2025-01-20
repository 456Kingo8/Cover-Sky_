using System;

namespace ZheTian.content;

public delegate BaseStats ConditionalBaseStatsDelegate(Actor actor);

public enum TraitType
{
    None,
    Active,
    Passive
}

public class TraitExtend
{
    public ConditionalBaseStatsDelegate conditional_basestats;
    
    public float                        cooldown = 0;
    /// <summary>
    ///     作用于最终结算，先使用所有最终结算的modifier，再使用所有最终结算的固定数值
    /// </summary>
    public BaseStats final_basestats = new();
    
    public int  mana_cost = 0;
    public bool HasCooldown => cooldown > 0;
    public TraitType trait_type;

    public void SetConditionalBaseStats(BaseStats stats, Func<Actor, bool> condition, bool expected_value = true)
    {
        conditional_basestats = actor =>
        {
            if (condition(actor) == expected_value) return stats;

            return null;
        };
    }

}