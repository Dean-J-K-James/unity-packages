/*******************************************************/
/* Dean James * Pangean Flying Cactus * Custom Package */
/*******************************************************/

using System;

/**
 * 
 */
public static class ApplyNeighbours
{
	/**
	 * 
	 */
	public static void Run(int x, int y, bool diag, Action<int, int> cb)
	{
		cb(x + 0, y + 1);
		cb(x + 1, y + 0);
		cb(x + 0, y - 1);
		cb(x - 1, y + 0);

		if (diag)
		{
			cb(x + 1, y + 1);
			cb(x + 1, y - 1);
			cb(x - 1, y - 1);
			cb(x - 1, y + 1);
		}
	}
}