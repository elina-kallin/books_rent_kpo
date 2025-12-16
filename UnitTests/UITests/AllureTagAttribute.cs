
namespace Tests.UITests
{
    internal class AllureTagAttribute : Attribute
    {
        private string v;

        public AllureTagAttribute(string v)
        {
            this.v = v;
        }
    }
}