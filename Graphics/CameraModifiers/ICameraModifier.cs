// Decompiled with JetBrains decompiler
// Type: Terraria.Graphics.CameraModifiers.ICameraModifier
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

#nullable disable
namespace Terraria.Graphics.CameraModifiers
{
  public interface ICameraModifier
  {
    string UniqueIdentity { get; }

    void Update(ref CameraInfo cameraPosition);

    bool Finished { get; }
  }
}
