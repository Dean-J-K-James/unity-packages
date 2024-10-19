/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeSurroundWithWalls : MonoBehaviour, IComponent, ICreated<BiomeData>
{
    public string wall; //

    /**
     * 
     */
    public void OnCreated(BiomeData bd)
    {
        for (int x = bd.x * Biome.SIZEX; x < bd.x * Biome.SIZEX + Biome.SIZEX; x++)
        {
            for (int y = bd.y * Biome.SIZEY; y < bd.y * Biome.SIZEY + Biome.SIZEY; y++)
            {
                //if (NodeManager.INSTANCE.Get(x, y, 0) != null && NodeManager.INSTANCE.Get(x, y, 0).node.name == "grass.tile")
                //{
                //	ApplyNeighbours.Run(x, y, true, (i, j) => { if (NodeManager.INSTANCE.Get(i, j, 0) == null) { NodeManager.INSTANCE.Set("dirt.tile", i, j); } });
                //}

                if (NodeManager.INSTANCE.Get(x, y, 0) == null)
                {
                    NodeManager.INSTANCE.Set(wall, x, y);
                }
            }
        }
    }
}