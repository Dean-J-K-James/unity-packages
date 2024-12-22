/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpawnPlayer : MonoBehaviour, IComponent, ICreated
{
    public string path;     //
    public int    chunks_x; //
    public int    chunks_y; //

    /**
     * 
     */
    public void OnCreated()
    {
        var pos = PickValidPosition.Get(0, 0, chunks_x * Biome.SIZEX, chunks_y * Biome.SIZEY, (x, y) => { return NodeManager.INSTANCE.Get(x, y).name == path; });

        UnitManager.INSTANCE.Create("player", pos.x, pos.y);
    }
}
