namespace CustomIntercom
{
	using Exiled.API.Enums;
	using Exiled.API.Features;
    using HarmonyLib;
    using System;

    public class IntercomTextUpdate : Plugin<Config>
	{
		public static IntercomTextUpdate Singleton;

		public override string Name => "CustomIntercom";
		public override string Prefix => "CustomIntercom";
		public override string Author => "Yamato#8987";

		private Harmony Harmony = new("dev.Yamato");
		private int patchCounter;

		public override void OnEnabled()
		{
			Singleton = this;

			try
			{
				Harmony = new(Author + "." + Name + ++patchCounter);
				Harmony.PatchAll();
			}
			catch (Exception ex)
			{
				Log.Error($"[RegistPatch] Patching Failed : {ex}");
			}
			base.OnEnabled();
		}
		public override void OnDisabled()
		{
			Harmony.UnpatchAll(Harmony.Id);

			base.OnDisabled();
		}

	}
}