using HarmonyLib;
using UnityEngine;
using Il2Cpp;
using System;
using System.Linq;
using System.Collections.Generic;
using Il2CppInterop.Runtime;
using MelonLoader;
using Il2CppTLD.Gear;
//using Il2CppTLD;

namespace CraftingAnywhere
{
    [HarmonyPatch(typeof(Panel_Crafting), "ItemPassesFilter")]
    internal class ChangeCraftingLocation
    {

        internal static void Postfix(BlueprintData bpi)
        {
            string? name = bpi?.m_CraftedResult?.name?.Substring(5);

            if (name != null)
            {
                if (name == "Arrow" && Settings.options.arrowAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "ArrowHead" && Settings.options.arrowheadAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "ArrowShaft" && Settings.options.arrowShaftAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "BearSkinBedRoll" && Settings.options.bearskinBedrollAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "BearSkinCoat" && Settings.options.bearskinCoatAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "BearskinLeggings" && Settings.options.bearskinLeggingsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "BedRoll" && Settings.options.bedrollAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Bow" && Settings.options.bowAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Bullet" && Settings.options.bulletAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "ClothSheet" && Settings.options.patchworkBlanketAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "DeerSkinBoots" && Settings.options.deerskinBootsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "DeerskinCoat" && Settings.options.deerskinCoatAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "DeerSkinPants" && Settings.options.deerskinPantsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "DeerskinGloves" && Settings.options.deerskinGlovesAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "FlareGunAmmoSingle" && Settings.options.flareShellsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "GunpowderCan" && Settings.options.gunpowderAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "HatchetImprovised" && Settings.options.improvisedHatchetAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Hook" && Settings.options.hookAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "KnifeImprovised" && Settings.options.improvisedKnifeAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Line" && Settings.options.lineAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "MooseHideBag" && Settings.options.moosehideSatchelAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "MooseHideCloak" && Settings.options.moosehideCloakAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "NoiseMaker" && Settings.options.noisemakerAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "RabbitskinHat" && Settings.options.rabbitskinHatAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "RabbitSkinMittens" && Settings.options.rabbitskinMittsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "RevolverAmmoSingle" && Settings.options.revolverAmmunitionAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "RifleAmmoSingle" && Settings.options.rifleAmmunitionAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Snare" && Settings.options.snareAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "Waterskin" && Settings.options.waterskinAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "wolfscarf" && Settings.options.wolfskinScarfAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "WolfskinBoots" && Settings.options.wolfskinBootsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "WolfSkinCape" && Settings.options.wolfskinCoatAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "WolfskinHat" && Settings.options.wolfskinHatAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
                else if (name == "ImprovisedCrampons" && Settings.options.improvisedCramponsAnywhere) bpi.m_RequiredCraftingLocation = CraftingLocation.Anywhere;
            }
        }
    }
}
