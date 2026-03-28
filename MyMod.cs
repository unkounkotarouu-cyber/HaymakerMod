using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Player Link Power: READY!");
        }
    }

    [HarmonyPatch(typeof(Rigidbody), "AddForce", new System.Type[] { typeof(Vector3), typeof(ForceMode) })]
    public class LinkPowerPatch
    {
        public static void Prefix(Rigidbody __instance, ref Vector3 force)
        {
            // お前の「コントローラーに連結されている物」を狙い撃ちするぜ
            // プレイヤー自身(Player)や、手(Hand)、コントローラー(Controller)という名前が含まれていれば強化
            if (__instance.gameObject.name.Contains("Player") || 
                __instance.gameObject.name.Contains("Hand") || 
                __instance.gameObject.name.Contains("Controller"))
            {
                // 威力を 100倍 に！
                force *= 100f;
            }
        }
    }
}
