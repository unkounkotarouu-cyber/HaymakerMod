using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(Mod.PunchMod), "GodPunch", "1.0.0", "Me")]
[assembly: MelonGame("Console Studios", "Haymaker")]

namespace Mod {
public class PunchMod : MelonLoaderMod {
public override void OnUpdate() {
if (Input.GetKeyDown(KeyCode.Space)) {
MelonLogger.Msg("God Mode Ready!");
}
}
}
}
