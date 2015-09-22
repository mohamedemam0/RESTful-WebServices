using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RESTful_WebServices.Model;
using Windows.Web.Http;

namespace RESTful_WebServices.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {

        public MainViewModel()
        {
            GetFacebookPagePosts();
        }
        private List<Datum> _FacebookPosts;
        public List<Datum> FacebookPosts
        {
            get { return _FacebookPosts; }
            set { _FacebookPosts = value;
                if (PropertyChanged != null)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs("FacebookPosts"));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        async void GetFacebookPagePosts()
        {
            HttpClient client = new HttpClient();
            string token = await client.GetStringAsync(new Uri("https://graph.facebook.com/oauth/access_token?client_id=364363933754883&client_secret=7d72f56490cf8b0a7075a99cb791037f&grant_type=client_credentials"));
            var posts = await client.GetStringAsync(new Uri("https://graph.facebook.com/ZSCOfficial/posts?limit=15&access_token=" + token.Split('=')[1]));
            var FbPosts = Newtonsoft.Json.JsonConvert.DeserializeObject<Rootobject>(posts);
            //myGridview.ItemsSource = FacebookPosts.data;
            FacebookPosts = new List<Datum>(FbPosts.data);
        }
    }
}
