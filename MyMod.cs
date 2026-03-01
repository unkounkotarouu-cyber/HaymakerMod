using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Haymaker Musou: Punch Power x100 Active!");
        }
    }

    // ゲーム内の「衝突判定（Collision）」をフックして威力を爆上げするぜ
    [HarmonyPatch(typeof(Rigidbody), "AddForce", new System.Type[] { typeof(Vector3), typeof(ForceMode) })]
    public class PunchPowerPatch
    {
        public static void Prefix(ref Vector3 force)
        {
            // ここで力を100倍に増幅させる！
            force *= 100f;
        }
    }
}
