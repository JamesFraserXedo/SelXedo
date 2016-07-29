namespace Core.Model.TestObjects.Bases
{
    public abstract class PopupControlBase : ControlBase
    {
        protected PopupControlBase(TestSettings testSettings) : base(testSettings)
        {
        }

        public abstract bool Active { get; }
    }
}
