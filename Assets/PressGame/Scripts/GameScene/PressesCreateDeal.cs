using System.Collections.Generic;
using UnityEngine;

public class PressesCreateDeal : Deal
{
    public override void Execute() {
        PressesData pressesData = GetRequire<PressesData>();
        for (int i = 0; i < pressesData.createNum; i++) {
            PressedData tempData = Object.Instantiate(pressesData.pbPressed,pressesData.transform).GetComponent<PressedData>();
            pressesData.currentPresses.Add(tempData);

            float tempX = (float)G1Manager.rd.NextDouble();
            float tempY = (float)G1Manager.rd.NextDouble();
            tempX *= 1600;tempX -= 960-160;
            tempY *= 800;tempY -= 540-140;

            tempData.transform.position = new Vector3(tempX/100, tempY/100, 0);
            if (i < 2)
                tempData.SetIsGood(true);
            else
                tempData.SetIsGood(false);
        }

        BGData bgData = GetRequire<BGData>();
        bgData.speed += bgData.speedA;
    }
}
