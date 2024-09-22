/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class Biome : MonoBehaviour, IComponent
{
    public float scale; //
    public int octaves; //
    public string defaultTile;
    public TileHeightData[] tiles; //

    //void OnWorldCreated(World data)
    //{
    //    var height = Noise.GenerateChunk(data.sizex, data.sizey, data.seed, scale, octaves);

    //    for (int x = 0; x < data.sizex; x++)
    //        for (int y = 0; y < data.sizey; y++)
    //        {

    //            try {
    //                World.INSTANCE.tilemap.Set(GetBestTile(height[x, y]), x, y);
    //                //NodeFactory.INSTANCE.Create(GetBestTile(height[x, y]), x, y);
    //                //Asset.INSTANCE.Get<Tile>(GetBestTile(height[x, y])).Create(x, y);

    //            }
    //            catch (Exception e)
    //            {
    //                Debug.LogError("ERROR: " + x +  ", " + y + ", " + GetBestTile(height[x, y]) + " :: " + e);
    //            }





    //        }
    //}

    string GetBestTile(float h)
    {
        foreach (var item in tiles)
        {
            if (h <= item.hght)
            {
                return item.tile;
            }
        }

        return defaultTile;
    }
}

[System.Serializable]
public struct TileHeightData
{
    public string tile;
    public float hght; //Just rename this to size.
}