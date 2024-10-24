/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeSpawnPlayer : MonoBehaviour, IComponent, ICreated<BiomeData>
{
    public int chunks_x; //
    public int chunks_y; //
    public string path; //

    /**
     * 
     */
    public void OnCreated(BiomeData bd)
    {
        while (true)
        {
            var x = Random.Range(0, chunks_x * Biome.SIZEX);
            var y = Random.Range(0, chunks_y * Biome.SIZEY);

            if (NodeManager.INSTANCE.Get(x, y, 0).node.name == path)
            {
                UnitManager.INSTANCE.Create("player.unit", x, y);
                return;
            }
        }
    }
}
