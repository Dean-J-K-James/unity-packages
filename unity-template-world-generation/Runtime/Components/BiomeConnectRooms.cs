/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public class BiomeConnectRooms : MonoBehaviour, IComponent, ICreated<BiomeData>
{
	public string path; //
	public int room_count_x; //
	public int room_count_y; //

	/**
     * 
     */
	public void OnCreated(BiomeData bd)
	{
		void cb(int x, int y) { NodeManager.INSTANCE.Set(path, x, y); }

		for (int x = 0; x < room_count_x; x++)
			for (int y = 0; y < room_count_y; y++)
			{



				//Have an ApplyNeighbours function for running a lambda on the NESW positions.
				//Could also have another for diagonals too.
				if (Mathf.Clamp(x - 1, 0, room_count_x - 1) == x - 1) { DrawLine.Run(x * 16, y * 16, (x - 1) * 16, y * 16, cb); }
				if (Mathf.Clamp(x + 1, 0, room_count_x - 1) == x + 1) { DrawLine.Run(x * 16, y * 16, (x + 1) * 16, y * 16, cb); }
				if (Mathf.Clamp(y - 1, 0, room_count_y - 1) == y - 1) { DrawLine.Run(x * 16, y * 16, x * 16, (y - 1) * 16, cb); }
				if (Mathf.Clamp(y + 1, 0, room_count_y - 1) == y + 1) { DrawLine.Run(x * 16, y * 16, x * 16, (y + 1) * 16, cb); }
			}
	}
}