/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public static class DrawLine
{
	/**
	 * 
	 */
	public static void Run(int sx, int sy, int ex, int ey, Action<int, int> cb)
	{
		int x1 = Mathf.Min(sx, ex);
		int x2 = Mathf.Max(sx, ex);
		int y1 = Mathf.Min(sy, ey);
		int y2 = Mathf.Max(sy, ey);

		for (int x = x1; x <= x2; x++)
		{
			for (int y = y1; y <= y2; y++)
			{
				//create_entity("stone", { x: x, y: y });
				cb(x, y);
				//NodeManager.INSTANCE.Set("grass.tile", x, y); //Change this to a lambda parameter for this function.
			}
		}
	}
}