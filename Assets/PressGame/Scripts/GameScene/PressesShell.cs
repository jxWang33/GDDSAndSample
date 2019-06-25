using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressesShell : Shell
{
    public PressesData pressesData;
    public BGData bgData;

    protected override void Awake() {
        base.Awake();
        pressesData = GetComponent<PressesData>();
    }
    private void Update() {
        if (pressesData.timer == pressesData.timeInter) {
            if (pressesData.currentPresses.Count == 0) {
                CreateDeal<PressesCreateDeal>(new List<Data>() {
                    pressesData,bgData
                });
            }
            else {
                CreateDeal<PressesDestroyDeal>(pressesData);
            }
        }
        CreateDeal<PressesTimerDeal>(pressesData);
    }
}
