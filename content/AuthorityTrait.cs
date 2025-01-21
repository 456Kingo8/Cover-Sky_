using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ZheTian.content
{
    public partial class Trait
    {
        public static ActorTrait _di_lu_zheng_feng { get; set; }
        public static ActorTrait _tian_xin_yin_ji { get; set; }
        public static ActorTrait _dou_zhan_tian_di { get; set; }
        public static ActorTrait _jian_jue_fu_yun { get; set; }
        
        public void InitAuthorityTrait()
        {
            TraitAdd(_di_lu_zheng_feng,"DiLuZhengFeng", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,10 },
                { S.mod_crit,10 },
                { S.mod_health,10 }
            },"AuthorityTraitGroup");

            TraitAdd(_tian_xin_yin_ji,"TianXinYinJi", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,20 },
                { S.mod_crit,20 },
                { S.mod_health,10 },
                { Stats.mod_talent.id,1f}
            },"AuthorityTraitGroup");

            TraitAdd(_dou_zhan_tian_di,"DouZhanTianDi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_damage,70 },
                { S.mod_armor,0.01f }
            },"AuthorityTraitGroup");

            TraitAdd(_jian_jue_fu_yun,"JianJueFuYun", 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");

            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = "AuthorityTraitGroup",
                name = "trait_group_Authority2",
                color = Color.cyan
            };

            // 将特性组添加到特性组库
            AssetManager.trait_groups.add(group);
        }

    }
}