using AngelSix.SolidDna;
using System.Collections.Generic;
using System.Windows;

namespace SolidDna.CustomCommands
{
    /// <summary>
    /// Register as a SolidWorks Add-in
    /// </summary>
    public class SolidDnaAddinIntegration : AddInIntegration
    {
        /// <summary>
        /// Specific application start-up code
        /// </summary>
        /// <param name="solidWorks"></param>
        public override void ApplicationStartup()
        {

        }

        public override void PreLoadPlugIns()
        {

        }
    }

    /// <summary>
    /// Register as SolidDna Plugin
    /// </summary>
    public class MySolidDnaPlugin : SolidPlugIn
    {
        #region Public Properties

        /// <summary>
        /// My Add-in description
        /// </summary>
        public override string AddInDescription {  get { return "An example of Command Items and exporting by RE"; } }

        /// <summary>
        /// My Add-in title
        /// </summary>
        public override string AddInTitle { get { return "SolidDNA Custom Commands by RE"; } }

      

        #endregion

        #region Connect To SolidWorks

        public override void ConnectedToSolidWorks()
        {
            
            var partGroup = Dna.Application.CommandManager.CreateCommands(
                title: "Custom commands by RE",
                items: new List<CommandManagerItem>(new[] {

                   new CommandManagerItem {
                       Name = "Export XXX",
                       Tooltip = "Export XXX",
                       VisibleForDrawings = true,
                       VisibleForAssemblies = true,
                       VisibleForParts = true,

                       OnClick = () =>
                       {
                           //FileExporting.ExportPartAsDxf();
                           MessageBox.Show("Hello!!! !!! ");
                       }
                   },



               }),
               iconListsPath: ""
               );


        }

        public override void DisconnectedFromSolidWorks()
        {
            
        }

        //public override void DisconnetedFromSolidWorks()
        //{

        //}

        #endregion
    }
}
