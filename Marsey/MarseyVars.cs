namespace Marsey;

public abstract class MarseyVars
{

    /// <summary>
    ///
    /// Namespace identifier for Harmony
    /// </summary>
    public const string Identifier = "com.validhunters.marseyloader";

    /// <summary>
    /// Max amount of loops allowed to catch game assemblies
    /// </summary>
    public const int MaxLoops = 50;

    /// <summary>
    /// Cooldown to try the loop again, in ms
    /// </summary>
    public const int LoopCooldown = 200;

    /// <summary>
    /// Marseypatches are saved to this one
    /// </summary>
    public const string MarseyPatchFolder = "Marsey";

    /// <summary>
    /// Should code side-loading be enabled
    /// This is only true if any subverter patch is enabled
    /// <see cref="Subversion.Subverse.CheckEnabled"/>
    /// </summary>
    public static bool Subverter;
    
    /// <summary>
    /// Log DEBG messages
    /// <see cref="Utility.SetupFlags"/>
    /// </summary>
    public static bool DebugAllowed;

    /// <summary>
    /// Log messages sent from patches
    /// <see cref="Utility.SetupFlags"/>
    /// </summary>
    public static bool PatchLogAllowed;

    /// <summary>
    /// Throws an exception on client if any patch had failed applying.
    /// <see cref="Utility.SetupFlags"/>
    /// </summary>
    public static bool ThrowOnFail;
}
