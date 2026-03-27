using MelonLoader;
using HarmonyLib;
using UnityEngine;

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            MelonLogger.Msg("Haymaker Musou: God Mode Initialized!");
        }
    }

    [HarmonyPatch(typeof(Rigidbody), "AddForce", new System.Type[] { typeof(Vector3), typeof(ForceMode) })]
    public class PunchPowerPatch
    {
        // Prefixで力を上書きするぜ
        public static void Prefix(Rigidbody __instance, ref Vector3 force)
        {
            // VRの自分の手（GloveやHand）が関わっているかチェック
            // 物理演算の名前（gameObject.name）に「Hand」や「Glove」が含まれる場合のみ発動
            if (__instance.gameObject.name.ToLower().Contains("hand") || 
                __instance.gameObject.name.ToLower().Contains("glove"))
            {
                // 100倍はマジで宇宙まで飛ぶから、まずは100倍で設定
                // もしゲームが落ちるならここを 20f くらいに下げて調整してくれ
                force *= 100f; 
                
                // 成功したらログに出す（これであとで「ログ」フォルダで確認できる）
                MelonLogger.Msg($"[Haymaker] SMASH! Applied 100x Force to: {__instance.gameObject.name}");
            }
        }
    }
}
