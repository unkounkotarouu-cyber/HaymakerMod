using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(Mod.PunchMod), "GodPunch", "1.0.0", "Me")]
[assembly: MelonGame("Console Studios", "Haymaker")]

namespace Mod {
    public class PunchMod : MelonLoaderMod {
        public override void OnUpdate() {
            // これが成功すれば「パンチの吹っ飛び」を改造できるぜ！
            if (Input.GetKeyDown(KeyCode.Space)) {
                MelonLogger.Msg("God Mode Active!");
            }
        }
    }
}
