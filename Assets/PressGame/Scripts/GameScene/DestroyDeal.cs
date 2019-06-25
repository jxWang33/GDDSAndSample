using System.Collections;
public class DestroyDeal : Deal
{
    public override void Execute() {
        foreach (Data i in requireData) {
            if(i)
                i.SetDestroy();
        }
    }
}
