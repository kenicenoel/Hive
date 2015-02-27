using System;

using Windows.ApplicationModel;

namespace AppStudio.ViewModels
{
    public class AboutThisAppViewModel
    {
        public string Publisher
        {
            get
            {
                return "Kenice Noel";
            }
        }

        public string AppVersion
        {
            get
            {
                return string.Format("{0}.{1}.{2}.{3}", Package.Current.Id.Version.Major, Package.Current.Id.Version.Minor, Package.Current.Id.Version.Build, Package.Current.Id.Version.Revision);
            }
        }

        public string AboutText
        {
            get
            {
                return "Hive is the unofficial eBanking application for Windows devices that allows custo" +
    "mers of the Grenada Co-operative Bank to manage their account, transfer funds, p" +
    "ay bills and more online.";
            }
        }
    }
}

