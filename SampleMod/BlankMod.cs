using ICities;
using UnityEngine;

namespace TemplateMod
{

    public class BlankMod : IUserMod
    {

        public string Name
        {
            get { return "Blank Mod"; }
        }

        public string Description
        {
            get { return "This mod does nothing. Just making sure things are visible. :D"; }
        }
    }
}