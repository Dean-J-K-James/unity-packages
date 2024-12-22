/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteNodeDeleted : MonoBehaviour, IComponent, IDeleted<Vector2Int>
{
    public int layer; //

    /**
     * 
     */
    public void OnDeleted(Vector2Int node) => TileManager.INSTANCE.map.SetTile(new Vector3Int(node.x, node.y, layer), null);
}
