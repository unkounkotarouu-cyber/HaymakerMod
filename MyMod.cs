using MelonLoader;
using HarmonyLib;

[assembly: MelonInfo(typeof(HaymakerMod.MyMod), "Haymaker Musou", "1.0.0", "You")]
[assembly: MelonGame(null, null)]

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Punch Power x100 Mod: Active!");
        }

        // ここに「パンチの威力を上書きする」処理を書き足していくぜ
        // ※まずはビルドを通すための安全な構造だ
    }

    [HarmonyPatch] // ゲーム内の特定の処理を狙い撃ちするぜ
    public class PunchPowerPatch
    {
        // ここに「敵を殴った時のダメージ計算」を横取りするコードを書く準備
    }
}
