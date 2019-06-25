using System;
using UnityEngine;
using UnityEngine.UI;

public class StartData : Data
{
    public float loadingProgress = 0;//0-1
    public float currentProgress = 0;
    public Image loadingImage;
    public AsyncOperation loadingScene = null;


    public override Type GetDataType() {
        return GetType();
    }

    protected override void UpdateExpress() {
        loadingProgress = Mathf.Clamp(loadingProgress, 0, 1);
        currentProgress = Mathf.Clamp(currentProgress, 0, 1);
        loadingImage.fillAmount = currentProgress;
    }
}