/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class BiomeSurroundWithWall : MonoBehaviour, IComponent, ICreated<BiomeData>
{
    public string wall; //

    /**
     * 
     */
    public void OnCreated(BiomeData bd)
    {
        var bounds = TilemapManager.INSTANCE.map.localBounds;

        var minx = Mathf.RoundToInt(bounds.min.x) - 1;
        var miny = Mathf.RoundToInt(bounds.min.y) - 1;
        var maxx = Mathf.RoundToInt(bounds.max.x) + 1;
        var maxy = Mathf.RoundToInt(bounds.max.y) + 1;

        for (int x = minx; x < maxx; x++)
            for (int y = miny; y < maxy; y++)
            {
                if (NodeManager.INSTANCE.Get(x, y, 0) == null)
                {
                    NodeManager.INSTANCE.Set(wall, x, y);
                }
            }
    }
}
