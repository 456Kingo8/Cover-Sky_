using System.Collections.Generic;

namespace ZheTian.content;

public static class TraitExtendTools
{
    private static readonly Dictionary<ActorTrait, TraitExtend> _extends = new();

    public static TraitExtend GetExtend(this ActorTrait trait, bool create = true)
    {
        if (!_extends.TryGetValue(trait, out TraitExtend extend) && create)
        {
            extend = new TraitExtend();
            _extends.Add(trait, extend);
        }

        return extend;
    }

    // public static void SetupSkill(this ActorTrait trait, float cooldown, int mana_cost = 40)
    // {
    //     trait.GetExtend().cooldown = cooldown;
    //     trait.GetExtend().mana_cost = mana_cost;
    // }
}