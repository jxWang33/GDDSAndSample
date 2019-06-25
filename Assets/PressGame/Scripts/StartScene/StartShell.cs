using UnityEngine.UI;
using System.Collections.Generic;

public class StartShell : Shell
{
    private Button startButton;

    public StartData startData;

    protected override void Awake() {
        base.Awake();
        startButton = GetComponent<Button>();
        startButton.onClick.AddListener(() => {
            if (startData.loadingProgress == 0) {
                CreateDeal<StartDeal>(startData);
            }
        });
    }

    private void Update() {
        if (startData.loadingScene != null) {
            CreateDeal<LoadingDeal>(startData);
        }
    }
}

