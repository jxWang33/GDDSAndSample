public class QuitDeal : Deal
{
#if UNITY_EDITOR
    public override void Execute() {
        UnityEditor.EditorApplication.isPlaying = false;
    }
#else
    public override void Execute() {
        Application.Quit();
    }
#endif
}
