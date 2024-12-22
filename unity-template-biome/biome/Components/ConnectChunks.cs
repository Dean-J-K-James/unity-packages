/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class ConnectChunks : MonoBehaviour, IComponent, ICreated
{
    public string path;     //
    public int    chunks_x; //
    public int    chunks_y; //

    /**
     * 
     */
    public void OnCreated()
	{
		void cb(int x, int y) { NodeManager.INSTANCE.Set(path, x, y); }

        for (int x = 0; x < chunks_x; x++)
            for (int y = 0; y < chunks_y; y++)
            {
                var cx = x * Biome.SIZEX + Biome.SIZEX / 2;
                var cy = y * Biome.SIZEY + Biome.SIZEY / 2;

                if (y + 1 < chunks_y) { DrawLine.Run(cx, cy, cx, cy + Biome.SIZEY, cb); }
                if (x + 1 < chunks_x) { DrawLine.Run(cx, cy, cx + Biome.SIZEX, cy, cb); }
            }
	}
}