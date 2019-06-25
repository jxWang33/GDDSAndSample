using System.Collections.Generic;
using UnityEngine.UI;

public class TestShell : Shell
{
    public TestData testData;

    private Button button;

    protected override void Awake() {
        base.Awake();
        button = GetComponent<Button>();
        button.onClick.AddListener(()=> {
            CreateDeal<TestDeal>(new List<Data>() {
                testData
            });
        });
    }

    void Update()
    {
        if (testData.num>=20) {
            CreateDeal<TestDeal1>(new List<Data>() {
                testData
            });
        }
    }
}
