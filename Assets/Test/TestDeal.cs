public class TestDeal : Deal
{
    public override void Execute() {
        GetRequire<TestData>().num ++;
    }
}
