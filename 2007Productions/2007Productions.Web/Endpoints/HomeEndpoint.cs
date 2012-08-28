namespace _2007Productions.Web.Endpoints
{
    public class HomeEndpoint
    {
        public HomeViewModel Index(HomeRequest input)
        {
            return new HomeViewModel();
        }
    }

    public class HomeViewModel
    {
    }

    public class HomeRequest
    {
    }
}