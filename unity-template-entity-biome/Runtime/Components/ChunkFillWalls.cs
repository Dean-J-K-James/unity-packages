/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class ChunkFillWalls : MonoBehaviour, IComponent, ICreated<ChunkData>
{
    /**
     * 
     */
    public void OnCreated(ChunkData cd)
    {
        for (int x = cd.x * Biome.SIZEX; x < cd.x * Biome.SIZEX + Biome.SIZEX; x++)
        {
            for (int y = cd.y * Biome.SIZEY; y < cd.y * Biome.SIZEY + Biome.SIZEY; y++)
            {
                //if (NodeManager.INSTANCE.Get(x, y, 0) != null && NodeManager.INSTANCE.Get(x, y, 0).node.name == "grass.tile")
                //{
                //	ApplyNeighbours.Run(x, y, true, (i, j) => { if (NodeManager.INSTANCE.Get(i, j, 0) == null) { NodeManager.INSTANCE.Set("dirt.tile", i, j); } });
                //}

                if (NodeManager.INSTANCE.Get(x, y, 0) == null)
                {
                    NodeManager.INSTANCE.Set(cd.biome.wall, x, y);
                }
            }
        }
    }
}