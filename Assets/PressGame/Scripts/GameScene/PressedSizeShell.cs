public class PressedSizeShell : Shell
{
    public PressedData pressedData;

    protected override void Awake() {
        base.Awake();
        pressedData = GetComponent<PressedData>();
    }
    void Update()
    {
        if (pressedData.currentSize != pressedData.targetSize) {
            CreateDeal<PressedSizeDeal>(pressedData);
        }
    }
}
