/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using System;
using UnityEngine;

/**
 * 
 */
public static class PickValidPosition
{
	/**
	 * 
	 */
	public static Vector2Int Get(int sx, int sy, int ex, int ey, Func<int, int, bool> cb)
	{
        while (true)
        {
            var x = UnityEngine.Random.Range(sx, ex);
            var y = UnityEngine.Random.Range(sy, ey);

            if (cb(x, y))
            {
                return new Vector2Int(x, y);
            }
        }
    }
}
