using System.Collections.Generic;
using UnityEngine.UI;

public class AboutShell : Shell
{
    private Button aboutButton;

    public AboutData aboutData;
    public StartData startData;

    protected override void Awake() {
        base.Awake();
        aboutButton = GetComponent<Button>();
        aboutButton.onClick.AddListener(() => {
            if (startData.loadingProgress == 0) {
                CreateDeal<AboutDeal>(new List<Data>() {
                    aboutData
                });
            }
        });
    }
}
