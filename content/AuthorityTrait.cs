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
        
        public static ActorTrait _zhe_xian { get; set; }
        public static ActorTrait _dao_po_ren_jia { get; set; }
        public static ActorTrait _shi_jian_zhi_guang { get; set; }
        public static ActorTrait _bu_dong_ming_wang { get; set; }
        public static ActorTrait _zhi_si_fang_xiu { get; set; }
        public static ActorTrait _shen_zang { get; set; }
        public static ActorTrait _bu_si_chang_chun { get; set; }
        public static ActorTrait _wu_fa_wu_tian { get; set; }
        public static ActorTrait _jiu_tian_xuan_shi { get; set; }
        public static ActorTrait _xian_lei { get; set; }
        public static ActorTrait _shen_ling { get; set; }
        public static ActorTrait _bai_hui { get; set; }
        public static ActorTrait _you_du_shen_dun { get; set; }
        public static ActorTrait _sheng_ling { get; set; }
        public static ActorTrait _gu_rou_xiang_lian { get; set; }
        public static ActorTrait _dao_guo { get; set; }
        public static ActorTrait _ban_shan { get; set; }
        public static ActorTrait _san_mei_zhen_huo { get; set; }
        public static ActorTrait _huang_jin_qi_xue { get; set; }
        public static ActorTrait _liu_yu { get; set; }
        public static ActorTrait _xian_ling_ming { get; set; }
        public static ActorTrait _yu_lin_long { get; set; }
        public static ActorTrait _jiu_qiao_xin { get; set; }
        public static ActorTrait _xuan_wu_dun { get; set; }
        public static ActorTrait _kuang_feng_bao_yu { get; set; }
        public static ActorTrait _bai_zu_zhi_chong { get; set; }
        public static ActorTrait _du_xian_qu { get; set; }
        public static ActorTrait _jiu_si_yi_sheng { get; set; }
        public static ActorTrait _qi_xing_lian_zhu { get; set; }
        public static ActorTrait _zhu_long { get; set; }
        public static ActorTrait _wu_liang { get; set; }
        public static ActorTrait _wu_jing_sha_fa { get; set; }
        public static ActorTrait _da_dao_jin_dan { get; set; }
        public static ActorTrait _hong_meng_ling_guang { get; set; }
        public static ActorTrait _xian_zhe { get; set; }
        public static ActorTrait _bai_jie_qian_jie { get; set; }
        public static ActorTrait _jian_shen { get; set; }
        public static ActorTrait _wu_dao_tong_tian { get; set; }
        public static ActorTrait _jing_gang_bu_huai { get; set; }
        public static ActorTrait _wan_jie_bu_fu { get; set; }
        public static ActorTrait _tian_fu { get; set; }
        public static ActorTrait _bu_zhou_feng { get; set; }
        public static ActorTrait _ying_yang_tong_yuan { get; set; }
        public static ActorTrait _zhen_shen { get; set; }
        public static ActorTrait _liu_shi_cha_na { get; set; }
        public static ActorTrait _mou_chang_jie_duan { get; set; }
        
        public void InitAuthorityTrait()
        {
            TraitAdd(_di_lu_zheng_feng,0, new Dictionary<string, float>()
            {
                { S.mod_damage,10 },
                { S.mod_crit,10 },
                { S.mod_health,10 }
            },"AuthorityTraitGroup");

            TraitAdd(_tian_xin_yin_ji, 0, new Dictionary<string, float>()
            {
                { S.mod_damage,20 },
                { S.mod_crit,20 },
                { S.mod_health,10 },
                { Stats.mod_talent.id,1f}
            },"AuthorityTraitGroup");

            TraitAdd(_dou_zhan_tian_di,0.01f, new Dictionary<string, float>()
            {
                { S.mod_damage,70 },
                { S.mod_armor,0.01f }
            },"AuthorityTraitGroup");

            TraitAdd(_jian_jue_fu_yun, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            
            TraitAdd(_zhe_xian, 0.001f, new Dictionary<string, float>()
            {
                {Stats.mod_talent.id,90f }
            },"BornTraitGroup");
            
            TraitAdd(_dao_po_ren_jia, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_shi_jian_zhi_guang, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bu_dong_ming_wang, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_zhi_si_fang_xiu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_shen_zang, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bu_si_chang_chun, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_wu_fa_wu_tian, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_jiu_tian_xuan_shi, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_xian_lei, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_shen_ling, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bai_hui, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_you_du_shen_dun, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            
            TraitAdd(_sheng_ling, 0.001f, new Dictionary<string, float>()
            {
                {Stats.mod_talent.id,50f}
            },"BornTraitGroupBornTraitGroup");
            
            TraitAdd(_gu_rou_xiang_lian, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_dao_guo, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_ban_shan, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_san_mei_zhen_huo, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_huang_jin_qi_xue, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_liu_yu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_xian_ling_ming, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_yu_lin_long, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_jiu_qiao_xin, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_xuan_wu_dun, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_kuang_feng_bao_yu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bai_zu_zhi_chong, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_du_xian_qu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_jiu_si_yi_sheng, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_qi_xing_lian_zhu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_zhu_long, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_wu_liang, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_wu_jing_sha_fa, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_da_dao_jin_dan, 0.001f, new Dictionary<string, float>()
            {
                
            },"BornTraitGroup");
            TraitAdd(_hong_meng_ling_guang, 0.001f, new Dictionary<string, float>()
            {
                {Stats.mod_talent.id,100f}
            },"AuthorityTraitGroup");
            TraitAdd(_xian_zhe, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bai_jie_qian_jie, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_jian_shen, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_wu_dao_tong_tian, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_jing_gang_bu_huai, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_wan_jie_bu_fu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_tian_fu, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_bu_zhou_feng, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_ying_yang_tong_yuan, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_zhen_shen, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_liu_shi_cha_na, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
            TraitAdd(_mou_chang_jie_duan, 0.01f, new Dictionary<string, float>()
            {
                { S.armor,10 },
                { S.dodge,10 }
            },"AuthorityTraitGroup");
        }

    }
}