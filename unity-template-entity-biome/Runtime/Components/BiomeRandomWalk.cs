/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeRandomWalk : MonoBehaviour, IComponent, ICreated<BiomeData>
{
	public string path; //
	public int room_count_x; //
	public int room_count_y; //

	/**
     * 
     */
	public void OnCreated(BiomeData bd)
	{
		Debug.Log("Doing random walk for: " + bd.x + " :: " + bd.y);
        RandomWalk.Run(bd.x * Biome.SIZEX, bd.y * Biome.SIZEY, Biome.SIZEX, Biome.SIZEY, 500, (x, y) => { NodeManager.INSTANCE.Set(path, x, y); });
    }
}
