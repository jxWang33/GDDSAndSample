public class LoadingDeal : Deal
{
    public override void Execute() {
        StartData startData = GetRequire<StartData>();
        startData.loadingProgress = startData.loadingScene.progress;
        if (startData.loadingProgress >= 0.9f) {
            startData.loadingProgress = 1;
        }
        if (startData.currentProgress < startData.loadingProgress) {
            startData.currentProgress += 0.01f;
        }
        if (startData.currentProgress >= 1) {
            G1Manager.Clear();
            startData.loadingScene.allowSceneActivation = true;
            startData.loadingScene = null;
        }
    }
}
