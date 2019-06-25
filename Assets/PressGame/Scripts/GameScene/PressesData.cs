using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressesData : Data
{
    public float timeInter = 2;
    public float timer = 2;
    public float timerOffset = 0;
    public int createNum = 5;

    public GameObject pbPressed;
    public List<PressedData> currentPresses;

    protected override void Awake() {
        base.Awake();
        currentPresses = new List<PressedData>();
    }

    protected override void UpdateExpress() {

    }
    public override Type GetDataType() {
        return GetType();
    }
}
