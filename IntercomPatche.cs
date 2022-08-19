using HarmonyLib;
using System;
using Exiled.API.Features;

namespace CustomIntercom
{
    [HarmonyPatch(typeof(Intercom), nameof(Intercom.UpdateText))]

    public class IntercomUpdateTextPatches
    {
        public static void Prefix(Intercom __instance)
        {
            try
            {
                __instance.CustomContent = ServerConsole.singleton.NameFormatter.ProcessExpression(IntercomTextUpdate.Singleton.Config.CustomText);
            }
            catch (Exception ex)
            {
                Log.Error($"Intercom::UpdateText Prefix : {ex}\n {ex.StackTrace}");
            }
        }
    }
}

