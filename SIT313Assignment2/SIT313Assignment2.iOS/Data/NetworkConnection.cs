using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreFoundation;
using Foundation;
using SIT313Assignment2.Data;
using SIT313Assignment2.iOS.Data;
using SystemConfiguration;
using UIKit;
using Xamarin.Forms;

[assembly: Dependency(typeof(NetworkConnection))]
namespace SIT313Assignment2.iOS.Data
{
    public class NetworkConnection : INetworkConnection
    {
        public bool IsConnected { get; set; }

        public void CheckNetworkConnection()
        {
            Internetstatus();
        }
        public bool Internetstatus()
        {
            NetworkReachabilityFlags flags;
            bool defaultNetworkAvailable = IsNetworkAvailable(out flags);
            if(defaultNetworkAvailable && ((flags & NetworkReachabilityFlags.IsDirect)!= 0))
            {
                return false;
            }
            else if((flags & NetworkReachabilityFlags.IsWWAN)!= 0)
            {
                return true;
            }
            else if(flags == 0)
            {
                return false;
            }
            return true;
        }
        private event EventHandler ReachabilityChanged;
        private void OnChange(NetworkReachabilityFlags flags)
        {
            var h = ReachabilityChanged;
            if (h != null)
            {
                h(null, EventArgs.Empty);
            }
        }

        private NetworkReachability defaultReachability;
        public bool IsNetworkAvailable(out NetworkReachabilityFlags flags)
        {
            if(defaultReachability == null)
            {
                defaultReachability = new NetworkReachability(new System.Net.IPAddress(0));
                defaultReachability.SetNotification(OnChange);
                defaultReachability.Schedule(CFRunLoop.Current, CFRunLoop.ModeDefault);
            }
            if(!defaultReachability.TryGetFlags(out flags))
            {
                return false;
            }
            return IsReachablewithoutRequiringConnection(flags);
        }

        private bool IsReachablewithoutRequiringConnection(NetworkReachabilityFlags flags)
        {
            bool IsReachable = (flags & NetworkReachabilityFlags.Reachable) != 0;
            bool noConnectionRequired = (flags & NetworkReachabilityFlags.ConnectionRequired) == 0;

            if((flags & NetworkReachabilityFlags.IsWWAN)!= 0)
            {
                noConnectionRequired = true;
            }
            return IsReachable && noConnectionRequired;
        }
    }
}