/********************************************************/
/* Dean James * Pangean Flying Cactus * Project Sandbox */
/********************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileBaseTM : TileBase
{
    public bool collision; //

    /**
     * 
     */
    public override void GetTileData(Vector3Int p, ITilemap t, ref TileData d) { d.colliderType = collision ? Tile.ColliderType.Grid : Tile.ColliderType.None; }
}
