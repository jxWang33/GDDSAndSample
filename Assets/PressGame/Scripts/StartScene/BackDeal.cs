using UnityEngine;

public class BackDeal : Deal
{
    public override void Execute() {
        AboutData aboutData = GetRequire<AboutData>();
        aboutData.isShowAboutPanel = !aboutData.isShowAboutPanel;
        GetRequire<AboutData>().aboutPanel.SetActive(aboutData.isShowAboutPanel);
    }
}
