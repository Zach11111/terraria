// Decompiled with JetBrains decompiler
// Type: Terraria.WorldBuilding.WorldGenConfiguration
// Assembly: Terraria, Version=1.4.4.9, Culture=neutral, PublicKeyToken=null
// MVID: CD1A926A-5330-4A76-ABC1-173FBEBCC76B
// Assembly location: C:\Program Files (x86)\Steam\steamapps\common\Terraria\Terraria.exe

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;
using System.Reflection;
using Terraria.IO;

#nullable disable
namespace Terraria.WorldBuilding
{
  public class WorldGenConfiguration : GameConfiguration
  {
    private readonly JObject _biomeRoot;
    private readonly JObject _passRoot;

    public WorldGenConfiguration(JObject configurationRoot)
      : base(configurationRoot)
    {
      this._biomeRoot = (JObject) configurationRoot["Biomes"] ?? new JObject();
      this._passRoot = (JObject) configurationRoot["Passes"] ?? new JObject();
    }

    public T CreateBiome<T>() where T : MicroBiome, new() => this.CreateBiome<T>(typeof (T).Name);

    public T CreateBiome<T>(string name) where T : MicroBiome, new()
    {
      JToken jtoken;
      return this._biomeRoot.TryGetValue(name, out jtoken) ? jtoken.ToObject<T>() : new T();
    }

    public GameConfiguration GetPassConfiguration(string name)
    {
      JToken configurationRoot;
      return this._passRoot.TryGetValue(name, out configurationRoot) ? new GameConfiguration((JObject) configurationRoot) : new GameConfiguration(new JObject());
    }

    public static WorldGenConfiguration FromEmbeddedPath(string path)
    {
      using (Stream manifestResourceStream = Assembly.GetExecutingAssembly().GetManifestResourceStream(path))
      {
        using (StreamReader streamReader = new StreamReader(manifestResourceStream))
          return new WorldGenConfiguration(JsonConvert.DeserializeObject<JObject>(streamReader.ReadToEnd()));
      }
    }
  }
}
