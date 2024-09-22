/********************************************************/
/* Dean James * Pangean Flying Cactus * Project Sandbox */
/********************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileRandomTM : TileBase
{
    public int randomCount; //

    /**
     * 
     */
    public override void GetTileData(Vector3Int p, ITilemap t, ref TileData d) { d.sprite = SpriteManager.INSTANCE.Get(name + "_" + Random.Range(0, randomCount)); }
}
