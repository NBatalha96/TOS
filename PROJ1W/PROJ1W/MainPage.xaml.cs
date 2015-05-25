using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace PROJ1W
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Post> cllist = new List<Post>();
        HttpWebRequest http;
        int flag = 0;

        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            if (list.Items.Count != 0)
                list.Items.Clear();

            http = (HttpWebRequest)WebRequest.Create("http://192.168.2.39/TOSWEB/webservice/service.php");
            http.BeginGetResponse(new AsyncCallback(ReadWebRequestCallBack), http);
        }

        private void ReadWebRequestCallBack(IAsyncResult callbackResult)
        {
            try
            {
                HttpWebRequest myRequest = (HttpWebRequest)callbackResult.AsyncState;
                HttpWebResponse myResponse = (HttpWebResponse)myRequest.EndGetResponse(callbackResult);

                StreamReader httpwebStreamReader = new StreamReader(myResponse.GetResponseStream());
                
                string results = httpwebStreamReader.ReadToEnd();
                string json = results;
                JObject jObject = JObject.Parse(json);
                JToken jUser = jObject["tos_posts"];
                int max = (int)jUser.Count<JToken>();

                for (int x = 0; x < max; x++)
                {
                    Post user = new Post(json, x);
                    cllist.Add(user);

                    Windows.ApplicationModel.Core.CoreApplication.MainView.CoreWindow.Dispatcher.RunAsync(CoreDispatcherPriority.Normal,
                    () =>
                    {
                        list.Items.Add(user.post_title);
                    }
                    );
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
