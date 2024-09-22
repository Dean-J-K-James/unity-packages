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
		for (int x = 0; x < room_count_x; x++)
			for (int y = 0; y < room_count_y; y++)
			{
				RandomWalk.Run(x * 16, y * 16, 8, 500, (x, y) => { NodeManager.INSTANCE.Set(path, x, y); });
			}
	}
}
