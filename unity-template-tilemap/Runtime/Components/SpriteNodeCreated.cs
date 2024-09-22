/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteTileCreated : MonoBehaviour, IComponent, ICreated<NodeData>
{
    public int layer; //

    /**
     * 
     */
    public void OnCreated(NodeData nd)
    {
        TilemapManager.INSTANCE.map.SetTile(new Vector3Int(nd.x, nd.y, layer), GetComponent<TileFactory>().tile);

        for (int x = -1; x < 2; x++)
            for (int y = -1; y < 2; y++)
            {
				TilemapManager.INSTANCE.map.RefreshTile(new Vector3Int(nd.x + x, nd.y + y, layer));
            }
    }
}
