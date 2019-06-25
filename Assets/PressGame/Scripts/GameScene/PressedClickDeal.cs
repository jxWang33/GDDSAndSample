public class PressedClickDeal : Deal
{
    public bool isDown = true;

    public override void Execute() {
        PressedData pressedData = GetRequire<PressedData>();
        BGData bgData = GetRequire<BGData>();
        if (isDown) {
            pressedData.SetClickedSize();
            pressedData.clicked = true;

            if (pressedData.isGood)
                bgData.targetSize -= pressedData.effect;
            else 
                bgData.targetSize += pressedData.effect;
        }
        else 
            pressedData.targetSize = 0;
    }
}
