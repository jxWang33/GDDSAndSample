using UnityEngine.SceneManagement;

public class StartDeal : Deal
{
    public override void Execute() {
        StartData startData = GetRequire<StartData>();
        startData.loadingScene = SceneManager.LoadSceneAsync("GameScene");
        startData.loadingScene.allowSceneActivation = false;
        startData.loadingProgress = 0;
    }
}
