/********************************************************/
/* Dean James * Pangean Flying Cactus * Project Sandbox */
/********************************************************/

using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileTM : TileBaseTM
{
    /**
     * 
     */
    public override void GetTileData(Vector3Int p, ITilemap t, ref TileData d) { base.GetTileData(p, t, ref d); d.sprite = SpriteManager.INSTANCE.Get(name); }
}
