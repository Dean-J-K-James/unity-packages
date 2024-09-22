/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteTileDeleted : MonoBehaviour, IComponent, IDeleted<NodeData>
{
    public int layer; //

    /**
     * 
     */
    public void OnDeleted(NodeData nd) => TilemapManager.INSTANCE.map.SetTile(new Vector3Int(nd.x, nd.y, layer), null);
}
