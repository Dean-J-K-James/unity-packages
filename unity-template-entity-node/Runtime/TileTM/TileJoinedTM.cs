/********************************************************/
/* Dean James * Pangean Flying Cactus * Project Sandbox */
/********************************************************/

using System;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileJoinedTM : TileBaseTM
{
    /**
     * 
     */
    public override void GetTileData(Vector3Int p, ITilemap t, ref TileData d)
    {
        base.GetTileData(p, t, ref d);

        int mask = 0;

        var NN = t.GetTile(new Vector3Int(p.x + 0, p.y + 1)) == this;
        var NE = t.GetTile(new Vector3Int(p.x + 1, p.y + 1)) == this;
        var EE = t.GetTile(new Vector3Int(p.x + 1, p.y + 0)) == this;
        var SE = t.GetTile(new Vector3Int(p.x + 1, p.y - 1)) == this;
        var SS = t.GetTile(new Vector3Int(p.x + 0, p.y - 1)) == this;
        var SW = t.GetTile(new Vector3Int(p.x - 1, p.y - 1)) == this;
        var WW = t.GetTile(new Vector3Int(p.x - 1, p.y + 0)) == this;
        var NW = t.GetTile(new Vector3Int(p.x - 1, p.y + 1)) == this;

        if (!(NN && EE)) { NE = false; }
        if (!(NN && WW)) { NW = false; }
        if (!(SS && EE)) { SE = false; }
        if (!(SS && WW)) { SW = false; }

        if (NN) { mask += 1; }
        if (NE) { mask += 2; }
        if (EE) { mask += 4; }
        if (SE) { mask += 8; }
        if (SS) { mask += 16; }
        if (SW) { mask += 32; }
        if (WW) { mask += 64; }
        if (NW) { mask += 128; }

        d.sprite = SpriteManager.INSTANCE.Get(name + "_" + GetIndex(mask));
    }

    /**
     * 
     */
    int GetIndex(int mask)
    {
        int[] a = new int[] { 16, 20, 84, 80, 213, 92, 116, 87, 28, 125, 124, 112, 17, 21, 85, 81, 29, 127, 253, 113, 31, 119, 245, 1, 5, 69, 65, 23, 223, 247, 209, 95, 255, 221, 241, 0, 4, 68, 64, 117, 71, 197, 93, 7, 199, 215, 193 };

        return Array.IndexOf(a, mask);
    }
}
