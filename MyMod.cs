using MelonLoader;

[assembly: MelonInfo(typeof(MyMod), "Haymaker Musou", "1.0.0", "You")]
[assembly: MelonGame(null, null)]

public class MyMod : MelonMod
{
    public override void OnInitializeMelon()
    {
        MelonLogger.Msg("Musou Mod Loaded! Let's Go!");
    }

    public override void OnUpdate()
    {
        // ここに「攻撃ボタンを押したら敵が飛ぶ」などの無双処理を書いていく
        // 今はビルドが通ることを優先した構成だぜ！
    }
}
