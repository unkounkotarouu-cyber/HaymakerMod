using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("ULTIMATE PUNCH MODE: ACTIVE!");
        }
    }

    [HarmonyPatch(typeof(Rigidbody), "AddForce", new System.Type[] { typeof(Vector3), typeof(ForceMode) })]
    public class PunchPowerPatch
    {
        public static void Prefix(ref Vector3 force)
        {
            // 名前チェックを全部無視して、ゲーム内のあらゆる物理パワーを10倍にするぜ
            // 100倍だと画面がバグるかもだから、まずは10倍でテストだ！
            force *= 10f;
        }
    }
}
