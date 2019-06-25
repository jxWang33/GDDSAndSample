using System;
using UnityEngine.UI;

public class TestData : Data
{
    public int num;
    public Text text;

    protected override void Awake()
    {
        base.Awake();
        num = 0;
    }

    public override Type GetDataType() {
        return GetType();
    }

    protected override void UpdateExpress() {
        text.text = num.ToString();
    }
}
