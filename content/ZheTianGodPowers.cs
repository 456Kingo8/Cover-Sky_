namespace ZheTian.content;

public class ZheTianGodPowers
{
    public static void init()
    {
        GodPower power = new GodPower();
        power.id = "ZheTianGodPower1";
        power.name = "ZheTian God Power 1";
        AssetManager.powers.add(power);

        power = new GodPower();
        power.id = "ZheTianGodPower2";
        power.name = "ZheTian God Power 2";
        power.toggle_name = "ZheTianGodPowerToggle";
        AssetManager.powers.add(power);
    }
}