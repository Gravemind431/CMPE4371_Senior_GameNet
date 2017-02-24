using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Photon.SocketServer;
using ExitGames.Logging;
using ExitGames.Logging.Log4Net;
using log4net.Config;
using System.IO;


class NoiresApplication : ApplicationBase
{
    private static ILogger log { get; set; }

    protected override PeerBase CreatePeer(InitRequest initRequest)
    {
        log.InfoFormat("Creating client peer!");
        return new NoiresPeer(initRequest);
    }

    protected override void Setup()
    {
        LogManager.SetLoggerFactory(Log4NetLoggerFactory.Instance);
        log = LogManager.GetCurrentClassLogger();
        log4net.GlobalContext.Properties["LogFileName"] = ApplicationName;
        log4net.GlobalContext.Properties["Photon:ApplicationLogPath"] = Path.Combine(this.ApplicationRootPath, "log");

        XmlConfigurator.ConfigureAndWatch(new FileInfo(Path.Combine(BinaryPath, "log4net.config")));

        log.InfoFormat("Test!");
    }

    protected override void TearDown()
    {
        log.InfoFormat("Called TearDown():");
        throw new NotImplementedException();
    }
}
