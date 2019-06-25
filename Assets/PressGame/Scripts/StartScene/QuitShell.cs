using UnityEngine;
using UnityEngine.UI;

public class QuitShell : Shell
{
    private Button quitButton;

    protected override void Awake() {
        base.Awake();
        quitButton = GetComponent<Button>();
        quitButton.onClick.AddListener(() => {
            CreateDeal<QuitDeal>();
        });
    }
}
