/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteNodeCreated : MonoBehaviour, IComponent, ICreated<Vector2Int>
{
    public int layer; //

    /**
     * 
     */
    public void OnCreated(Vector2Int node)
    {
        TileManager.INSTANCE.map.SetTile(new Vector3Int(node.x, node.y, layer), GetComponent<TileFactory>().tile);

        for (int x = -1; x < 2; x++)
            for (int y = -1; y < 2; y++)
            {
                TileManager.INSTANCE.map.RefreshTile(new Vector3Int(node.x + x, node.y + y, layer));
            }
    }
}
