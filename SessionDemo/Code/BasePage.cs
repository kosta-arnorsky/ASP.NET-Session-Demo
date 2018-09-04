using FakeBackend;
using System.Web.UI;

namespace SessionDemo
{
    public class BasePage : Page
    {
        private Repository _repository;

        protected Repository Repository
        {
            get
            {
                if (_repository == null)
                {
                    _repository = new Repository(new { someoption = "somevalue" });
                }

                return _repository;
            }
        }
    }
}