using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AboutData : Data
{
    public bool isShowAboutPanel = false;
    public GameObject aboutPanel;

    public override Type GetDataType() {
        return GetType();
    }

    protected override void UpdateExpress() {
//
    }
}
