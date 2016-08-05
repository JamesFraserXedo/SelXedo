namespace Core.Contexts
{
    public class Context
    {
        public CollectionContext Collection { get; set; }
        public CommonContext Common { get; set; }
        public LoadTimeContext LoadTime { get; set; }
        public QuickTryOnContext QuickTryOn { get; set; }
        public UserJourneyContext UserJourney { get; set; }
        public TryOnContext TryOn { get; set; }
        
        public Context()
        {
            Collection = new CollectionContext();
            Common = new CommonContext();
            LoadTime = new LoadTimeContext();
            QuickTryOn = new QuickTryOnContext();
            TryOn = new TryOnContext();;
            UserJourney = new UserJourneyContext();
        }

        public class CollectionContext
        {
            public string Name { get; set; }
            public string Price { get; set; }
            public string ImageSource { get; set; }
        }

        public class CommonContext
        {
            public string CreatedMemberEmail { get; set; }
            public string CreatedMemberPassword { get; set; }
        }

        public class LoadTimeContext
        {
            public long PageLoadTime { get; set; }
            public long PageContentLoadTime { get; set; }
        }

        public class QuickTryOnContext
        {
            public string EnteredAddress1 { get; set; }
            public string EnteredAddress2 { get; set; }
            public string EnteredCity { get; set; }
            public string EnteredState { get; set; }
            public string EnteredStateCode { get; set; }
            public string EnteredZip { get; set; }
            public string ThePocketSquareColour { get; set; }
            public string FedexSuggestedAddress { get; set; }
        }

        public class TryOnContext
        {
            public string OrderNumber { get; set; }
        }

        public class UserJourneyContext
        {
            public string GroomOutfitPrice { get; set; }
        }

        

    }
}
