using System.Reflection;
using UnityEngine;
using MelonLoader;

namespace CraftingAnywhere
{
    internal sealed class Implementation : MelonMod
    {
        public override void OnInitializeMelon()
        {
            Debug.Log("[CraftingAnywhere] Version " + Assembly.GetExecutingAssembly().GetName().Version);
            Settings.OnLoad();
        }
    }
}

