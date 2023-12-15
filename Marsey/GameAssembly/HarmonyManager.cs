using HarmonyLib;
using Marsey.Config;

namespace Marsey.GameAssembly;

public static class HarmonyManager
{
    private static Harmony? _harmony;

    /// <summary>
    /// Sets the _harmony field in the class.
    ///
    /// If debug is enabled - log IL to file on desktop
    /// </summary>
    /// <param name="harmony">A Harmony instance</param>
    public static void Init(Harmony harmony)
    {
        _harmony = harmony;

        if (MarseyVars.DebugAllowed)
            Harmony.DEBUG = true;
    }

    public static Harmony? GetHarmony() => _harmony;
}