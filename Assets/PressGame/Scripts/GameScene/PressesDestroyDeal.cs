using System.Collections.Generic;

public class PressesDestroyDeal : Deal
{
    public override void Execute() {
        PressesData pressesData = GetRequire<PressesData>();
        foreach (PressedData i in pressesData.currentPresses) {
            if (i)
                i.SetDestroy();
        }
        pressesData.currentPresses = new List<PressedData>();
    }
}
