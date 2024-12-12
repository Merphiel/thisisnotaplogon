namespace Penumbra.GameData;

/// <summary> Offsets in game data in use by Penumbra. </summary>
public static class Offsets
{
    // ActorManager.Data

    // ObjectIdentification
    public const  int DrawObjectGetModelTypeVfunc = 50;
    private const int DrawObjectModelBase         = 0x8E8;
    public const  int DrawObjectModelUnk1         = DrawObjectModelBase;
    public const  int DrawObjectModelUnk2         = DrawObjectModelBase + 0x08;
    public const  int DrawObjectModelUnk3         = DrawObjectModelBase + 0x20;
    public const  int DrawObjectModelUnk4         = DrawObjectModelBase + 0x28;

    // PathResolver.AnimationState
    public const int TimeLinePtr = 0x50;

    // PathResolver.Meta
    public const int UpdateModelSkip = 0x9EC;

    // FontReloader
    public const int ReloadFontsVfunc = 43;

    // ObjectReloader
    public const int EnableDrawVfunc  = 12;
    public const int DisableDrawVfunc = 13;
}
