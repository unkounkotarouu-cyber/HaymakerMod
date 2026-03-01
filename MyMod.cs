using MelonLoader;
using UnityEngine;

// ここで Mod の情報を定義する（ここが間違ってるとエラーになる）
[assembly: MelonInfo(typeof(MyMod), "Haymaker Musou", "1.0.0", "You")]
[assembly: MelonGame(null, null)]

namespace HaymakerMod
{
    public class MyMod : MelonMod
    {
        public override void OnInitializeMelon()
        {
            LoggerInstance.Msg("Haymaker Musou Initialized!");
        }

        public override void OnUpdate()
        {
            // ここに無双の処理を書く
            // 今はテスト用にログが出るようにしてあるぜ
        }
    }
}
