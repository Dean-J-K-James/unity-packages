/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

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
	public bool     collision;   //
	
    /**
     * 
     */
	public void OnCreated(PrefData pd)
    {
        tile = ScriptableObject.CreateInstance(TypeFromString.Get(tileType)) as TileBase;

        JsonUtility.FromJsonOverwrite(JsonUtility.ToJson(this), tile);

        tile.name = name;
    }
}
