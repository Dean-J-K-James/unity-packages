/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public static class RandomWalk
{
	/**
	 * 
	 */
	public static void Run(int sx, int sy, int range, int attempts, Action<int, int> cb)
	{
		int x = sx;
		int y = sy;

		for (int i = 0; i < attempts; i++)
		{
			cb(x, y);

			switch (UnityEngine.Random.Range(0, 4))
			{
				case 0: { y++; break; }
				case 1: { x--; break; }
				case 2: { y--; break; }
				case 3: { x++; break; }
			}

			x = Mathf.Clamp(x, sx - range, sx + range);
			y = Mathf.Clamp(y, sy - range, sy + range);
		}
	}
}