using UnityEngine;

public class PressedSizeDeal : Deal
{
    public override void Execute() {
        PressedData pressedData = GetRequire<PressedData>();
        if (pressedData.currentSize < pressedData.targetSize) {
            pressedData.currentSize += pressedData.sizeSpeed * Time.deltaTime;
            if (pressedData.currentSize > pressedData.targetSize) {
                pressedData.currentSize = pressedData.targetSize;
            }
        }
        else if (pressedData.currentSize > pressedData.targetSize) {
            pressedData.currentSize -= pressedData.sizeSpeed * Time.deltaTime;
            if (pressedData.currentSize < pressedData.targetSize) {
                pressedData.currentSize = pressedData.targetSize;
            }
        }
    }
}
