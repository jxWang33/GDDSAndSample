using UnityEngine;

public class PressesTimerDeal : Deal
{
    public override void Execute() {
        PressesData pressesData = GetRequire<PressesData>();
        if (pressesData.timer < pressesData.timeInter) {
            pressesData.timer += Time.deltaTime;
        }
        if (pressesData.timer > pressesData.timeInter) {
            pressesData.timerOffset = pressesData.timer - pressesData.timeInter;
            pressesData.timer = pressesData.timeInter;
        }
        else if (pressesData.timer == pressesData.timeInter) {
            pressesData.timer = pressesData.timerOffset;
        }
    }
}
