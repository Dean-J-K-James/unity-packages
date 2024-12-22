/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SurroundWithWall : MonoBehaviour, IComponent, ICreated
{
    public string wall;     //
    public int    chunks_x; //
    public int    chunks_y; //

    /**
     * 
     */
    public void OnCreated()
    {
        for (int x = -1; x <= chunks_x * Biome.SIZEX; x++)
            for (int y = -1; y <= chunks_y * Biome.SIZEY; y++)
                if (NodeManager.INSTANCE.Get(x, y) == null)
                {
                    NodeManager.INSTANCE.Set(wall, x, y);
                }
    }
}
