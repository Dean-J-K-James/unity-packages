/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

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
	public static void Run(int sx, int sy, int sizex, int sizey, int attempts, Action<int, int> cb)
	{
		int x = sx + sizex / 2;
		int y = sy + sizey / 2;

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

			x = Mathf.Clamp(x, sx, sx + sizex - 1);
			y = Mathf.Clamp(y, sy, sy + sizey - 1);
		}
	}
}
