/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class ChunkRandomWalk : MonoBehaviour, IComponent, ICreated<ChunkData>
{
	/**
     * 
     */
	public void OnCreated(ChunkData cd)
	{
		//Debug.Log("Doing random walk for: " + bd.x + " :: " + bd.y);
        RandomWalk.Run(cd.x * Biome.SIZEX, cd.y * Biome.SIZEY, Biome.SIZEX, Biome.SIZEY, 500, (x, y) => { NodeManager.INSTANCE.Set(cd.biome.path, x, y); });
    }
}
