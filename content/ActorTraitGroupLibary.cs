

using UnityEngine;

namespace ZheTian.content;

public partial class Trait
{
    public void InitActorTraitGroup()
    {
        ActorTraitGroupAsset group = new ActorTraitGroupAsset()
        {
            id = "AuthorityTraitGroup",
            name = "trait_group_Authority2",
            color = Color.cyan
        };

        // 将特性组添加到特性组库
        AssetManager.trait_groups.add(group);
        
        ActorTraitGroupAsset group1 = new ActorTraitGroupAsset()
        {
            id = "BodyTraitGroup",
            name = "trait_group_body",
            color = Color.cyan
        };

        // 将特性组添加到特性组库
        
        AssetManager.trait_groups.add(group1);
        
        ActorTraitGroupAsset group2 = new ActorTraitGroupAsset()
        {
            id = "BornTraitGroup",
            name = "trait_group_born",
            color = Color.cyan
        };

        // 将特性组添加到特性组库
        AssetManager.trait_groups.add(group2);
        
        
    }
}