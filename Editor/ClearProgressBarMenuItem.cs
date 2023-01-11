using UnityEditor;

namespace Kogane.Internal
{
    internal static class ClearProgressBarMenuItem
    {
        [MenuItem( "Kogane/EditorUtility/Clear Progress Bar" )]
        private static void ClearCookieCache()
        {
            var isOk = EditorUtility.DisplayDialog
            (
                title: "",
                message: "EditorUtility の ClearProgressBar を実行しますか？",
                ok: "はい",
                cancel: "いいえ"
            );

            if ( !isOk ) return;

            EditorUtility.ClearProgressBar();

            EditorUtility.DisplayDialog
            (
                title: "",
                message: "EditorUtility の ClearProgressBar を実行しました",
                ok: "OK"
            );
        }
    }
}