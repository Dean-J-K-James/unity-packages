/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
 * 
 */
public class TileFactory : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public TileBase tile;        //
    public string   tileType;    //
	public int      randomCount; //
	
    /**
     * 
     */
	public void OnCreated(PrefData pd)
    {
        tile = ScriptableObject.CreateInstance(Type.GetType(tileType)) as TileBase;

        var json = JsonUtility.ToJson(this);
        JsonUtility.FromJsonOverwrite(json, tile);

        tile.name = name;
    }
}
