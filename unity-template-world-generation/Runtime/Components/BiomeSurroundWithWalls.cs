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
		var bounds = TilemapManager.INSTANCE.map.localBounds;

		var minx = Mathf.RoundToInt(bounds.min.x);
		var miny = Mathf.RoundToInt(bounds.min.y);
		var maxx = Mathf.RoundToInt(bounds.max.x);
		var maxy = Mathf.RoundToInt(bounds.max.y);

		for (int x = minx; x < maxx; x++)
		{
			for (int y = miny; y < maxy; y++)
			{
				if (NodeManager.INSTANCE.Get(x, y, 0) != null && NodeManager.INSTANCE.Get(x, y, 0).node.name == "grass.tile")
				{
					ApplyNeighbours.Run(x, y, true, (i, j) => { if (NodeManager.INSTANCE.Get(i, j, 0) == null) { NodeManager.INSTANCE.Set("dirt.tile", i, j); } });
				}
			}
		}
	}
}