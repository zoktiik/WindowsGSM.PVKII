using System;
using System.Diagnostics;
using System.Threading.Tasks;
using WindowsGSM.Functions;
using WindowsGSM.GameServer.Query;
using WindowsGSM.GameServer.Engine;
using System.IO;
using System.Linq;
using System.Net;

namespace WindowsGSM.Plugins
{
    public class PVKII : Source
    {
        // - Plugin Details
        public Plugin Plugin = new Plugin
        {
            name = "WindowsGSM.PVKII", // WindowsGSM.XXXX
            author = "zoktiik",
            description = "WindowsGSM plugin for Pirates, Vikings, and Knights II Dedicated Server support",
            version = "1.0",
            url = "https://github.com/zoktiik/WindowsGSM.PVKII", // Github repository link (Best practice)
            color = "#ffffff" // Color Hex
        };
    
        public string FullName = "Pirates, Vikings, and Knights II Dedicated Server"; 
        public override string Defaultmap { get { return "bt_glacier"; } }
        public override string Additional { get { return "-tickrate 64 -nocrashdialog +clientport {{clientport}}"; } }
        public override string Game { get { return "pvkii"; } }
        public override string AppId { get { return "17575"; } }

        public PVKII(Functions.ServerConfig serverData) : base(serverData)
        {
            base.serverData = serverData;
        }
    }
}