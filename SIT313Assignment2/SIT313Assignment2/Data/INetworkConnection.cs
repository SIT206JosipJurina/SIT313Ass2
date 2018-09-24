using System;
using System.Collections.Generic;
using System.Text;

namespace SIT313Assignment2.Data
{
    public interface INetworkConnection
    {
        bool IsConnected { get; }
        void CheckNetworkConnection();
    }
}
