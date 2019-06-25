public class TestDeal1 : Deal
{
    public override void Execute() {
        GetRequire<TestData>().num+=10;
    }
}
