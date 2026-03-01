using MelonLoader;

[assembly: MelonInfo(typeof(MyMod), "Haymaker Musou", "1.0.0", "You")]
[assembly: MelonGame(null, null)]

public class MyMod : MelonMod
{
    public override void OnInitializeMelon()
    {
        MelonLogger.Msg("Musou Build Success!");
    }
}
