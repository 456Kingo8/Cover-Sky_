using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.InteropServices;
using NeoModLoader.api.attributes;
using NeoModLoader.General;
using NeoModLoader.General.UI.Tab;
using UnityEngine;
using ZheTian.content;

public class ZheTianEra
{
    public static Dictionary<string, EraAsset> Eradict = new Dictionary<string, EraAsset>();
    public static List<string> EraID = new List<string>();

    public static void init()
    {
        EraAsset _hei_an_dong_luan = AssetManager.era_library.clone("age_hei_an_dong_luan",S.age_chaos);
        _hei_an_dong_luan.rate = 0;
        _hei_an_dong_luan.years_max = 1000;
        _hei_an_dong_luan.years_min = 1000;
        _hei_an_dong_luan.special_effect_action = DarkChaos;
        _hei_an_dong_luan.era_disaster_rage_brings_demons = false;
        _hei_an_dong_luan.bonus_loyalty = +55;
		_hei_an_dong_luan.bonus_opinion = +35;
        _hei_an_dong_luan.path_icon = "ui/icons/neomodloader";
        AssetManager.era_library.add(_hei_an_dong_luan);
    }

    public static List<Actor> DarkChaosActor = new List<Actor>();
    public static int DarkChaosPopulationLimit = 0;

    public static void DarkChaosStart()
    {
        World.world.eraManager.setEra("age_hei_an_dong_luan");
        DarkChaosPopulationLimit = World.world.getCivWorldPopulation() / 10;
        int num = Random.Range(8,12);
        for(int i = 0;i < num;i++)
        {
            WorldTile randomTile = MapBox.instance.tilesList.GetRandom();
            Actor a = World.world.units.createNewUnit(SA.unit_human,randomTile);
            a.addTrait("madness");
            a.addTrait(Trait._zhi_zun.id);
            a.data.age_overgrowth = Random.Range(4000,6000);
            a.SetLevel(12);
            a.SetTalent(Random.Range(10,30));
            a.event_full_heal = true;
            a.setStatsDirty();
            DarkChaosActor.Add(a);
        }
        MonoBehaviour.print("population" + DarkChaosPopulationLimit);
    }
    public static void DarkChaos()
    {
        List<Actor> remove = new List<Actor>();
        foreach(Actor a in DarkChaosActor)
        {
            if(a == null || !a.hasTrait("madness")) remove.Add(a);
        }
        foreach(Actor a in remove) DarkChaosActor.Remove(a);
        if(DarkChaosActor.Count == 0 || DarkChaosPopulationLimit > World.world.getCivWorldPopulation())
        {
            World.world.eraManager.startNextEra();
            foreach(Actor a in DarkChaosActor)
            {
                a.removeTrait("madness");
            }
        }
    }
}