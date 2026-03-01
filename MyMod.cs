using MelonLoader;
using UnityEngine;

[assembly: MelonInfo(typeof(HaymakerMod.MyFirstMod), "GodHand", "1.0.0", "YourName")]
[assembly: MelonGame("Console Studios", "Haymaker")]

namespace HaymakerMod {
    public class MyFirstMod : MelonLoaderMod {
        public override void OnStart() {
            GameObject button = GameObject.CreatePrimitive(PrimitiveType.Cube);
            button.transform.position = new Vector3(0, 1.5f, 1f);
            button.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
