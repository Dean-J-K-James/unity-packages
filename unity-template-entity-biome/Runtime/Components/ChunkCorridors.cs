/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class ChunkCorridors : MonoBehaviour, IComponent, ICreated<ChunkData>
{
	/**
     * 
     */
	public void OnCreated(ChunkData cd)
	{
		void cb(int x, int y) { NodeManager.INSTANCE.Set(cd.biome.path, x, y); }

		var cx = cd.x * Biome.SIZEX + Biome.SIZEX / 2;
		var cy = cd.y * Biome.SIZEY + Biome.SIZEY / 2;

		//var hx = Mathf.RoundToInt((float)Math.Round(Biome.SIZEX / 2f, MidpointRounding.AwayFromZero));
		//var hy = Mathf.RoundToInt((float)Math.Round(Biome.SIZEY / 2f, MidpointRounding.AwayFromZero));

        DrawLine.Run(cx, cy, cx, cd.y * Biome.SIZEY + Biome.SIZEY - 1, cb);
        DrawLine.Run(cx, cy, cd.x * Biome.SIZEX + Biome.SIZEX - 1, cy, cb);
        DrawLine.Run(cx, cy, cx, cd.y * Biome.SIZEY, cb);
        DrawLine.Run(cx, cy, cd.x * Biome.SIZEX, cy, cb);

        //return;
		//for (int x = 0; x < room_count_x; x++)
		//	for (int y = 0; y < room_count_y; y++)
		//	{



		//		//Have an ApplyNeighbours function for running a lambda on the NESW positions.
		//		//Could also have another for diagonals too.
		//		if (Mathf.Clamp(x - 1, 0, room_count_x - 1) == x - 1) { DrawLine.Run(x * 16, y * 16, (x - 1) * 16, y * 16, cb); }
		//		if (Mathf.Clamp(x + 1, 0, room_count_x - 1) == x + 1) { DrawLine.Run(x * 16, y * 16, (x + 1) * 16, y * 16, cb); }
		//		if (Mathf.Clamp(y - 1, 0, room_count_y - 1) == y - 1) { DrawLine.Run(x * 16, y * 16, x * 16, (y - 1) * 16, cb); }
		//		if (Mathf.Clamp(y + 1, 0, room_count_y - 1) == y + 1) { DrawLine.Run(x * 16, y * 16, x * 16, (y + 1) * 16, cb); }
		//	}
	}
}