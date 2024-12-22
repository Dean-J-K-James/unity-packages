/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeRandomWalk : MonoBehaviour, IComponent, ICreated
{
    public string path;     //
    public int    chunks_x; //
    public int    chunks_y; //

    /**
     * 
     */
    public void OnCreated()
	{
        for (int x = 0; x < chunks_x; x++)
            for (int y = 0; y < chunks_y; y++)
            {
                RandomWalk.Run(x * Biome.SIZEX, y * Biome.SIZEY, Biome.SIZEX, Biome.SIZEY, 500, (x, y) => { NodeManager.INSTANCE.Set(path, x, y); });
            }
    }
}
