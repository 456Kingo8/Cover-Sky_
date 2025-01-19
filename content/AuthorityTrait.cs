using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace ZheTian.content
{
    internal static class AuthorityTrait
    {
        public static void Init()
        {
            AuthorityTraitAdd("DiXin", 0.001f, new Dictionary<string, float>()
            {
                { S.mod_health,200 }
            });

            AuthorityTraitAdd("DiQu", 0.001f, new Dictionary<string, float>()
            {
                { S.mod_damage,300 }
            });

            AuthorityTraitAdd("DiLuZhengFeng", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,10 },
                { S.mod_crit,10 },
                { S.mod_health,10 }
            });

            AuthorityTraitAdd("TianXinYinJi", 0, new Dictionary<string, float>()
            {
                { S.mod_damage,20 },
                { S.mod_crit,20 },
                { S.mod_health,10 }
            });

            AuthorityTraitAdd("DouZhanTianDi", 0.01f, new Dictionary<string, float>()
            {
                { S.mod_damage,70 },
                { S.mod_armor,0.01f }
            });

            AuthorityTraitAdd("JianJueFuYun", 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            });

            AuthorityTraitAdd("ZheXian", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("PoShenRenJia", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ShiJianZhiGuang", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BuDongMingWang", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ZhiSiFangXiu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ShenCang", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BuSiChangChun", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("WuFaWuTian", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("JiuTianXuanShi", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("XianLei", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ShenLin", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BaiHui", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("YouDuShenDun", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ShengLing", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("GuRouXiangLian", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("DaoGuo", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BanShan", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("SanMeiZhenHuo", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("HuangJinQiXue", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("LiuYu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("XianLingMing", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("YuLingLong", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("JiuQiaoXin", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("XuanWuDun", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("KuangFengBaoYu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BaiZuZhiChong", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("DuXianQu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("JiuSiYiSheng", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("QiXingLianZhu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ZhuLong", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("WuLiang", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("WuJinShaFa", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("DaDaoJinDan", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("HongMengLingGuang", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("XianZhe", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BaiJieQianJie", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("JianShen", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("WuDaoTongTian", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("JinGangBuHuai", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("WanJieBuMo", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("TianFu", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("BuZhouFeng", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("YinYangTongYuan", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("ZhenShen", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("LiuShiChaNa", 0.01f, new Dictionary<string, float>()
            {

            });

            AuthorityTraitAdd("MouChangJieDuan", 0.01f, new Dictionary<string, float>()
            {

            });

            ActorTraitGroupAsset group = new ActorTraitGroupAsset()
            {
                id = "AuthorityTraitGroup",
                name = "trait_group_Authority2",
                color = Color.cyan
            };

            // 将特性组添加到特性组库
            AssetManager.trait_groups.add(group);
        }

        public static void AuthorityTraitAdd(string id, float birth, Dictionary<string, float> statDictionary, string path_icon = "ui/icons/neomodloader")
        {
            ActorTrait trait = new ActorTrait()
            {
                id = id,
                group_id = "AuthorityTraitGroup",
                path_icon = path_icon,
                birth = birth,
                needs_to_be_explored = false
            };
            foreach (var kvp in statDictionary)
            {
                trait.base_stats[kvp.Key] = kvp.Value;
            }

            AssetManager.traits.add(trait);
        }
    }
}