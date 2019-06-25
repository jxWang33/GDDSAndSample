public class BGSizeShell : Shell
{
    public BGData bgData;

    protected override void Awake() {
        base.Awake();
        bgData = GetComponent<BGData>();
    }
    void Update() {
        CreateDeal<BGSizeDeal>(bgData);
    }
}

