using UnityEngine.UI;
using System.Collections.Generic;

public class BackShell : Shell
{
    private Button backButton;

    public AboutData aboutData;

    protected override void Awake() {
        base.Awake();
        backButton = GetComponent<Button>();
        backButton.onClick.AddListener(() => {
            CreateDeal<BackDeal>(new List<Data>() {
                aboutData
            });
        });
    }
}

