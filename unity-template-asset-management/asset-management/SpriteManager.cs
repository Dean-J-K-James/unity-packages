/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteManager : Singleton<SpriteManager>
{
    public SpriteAtlasResourceAsset atlas;    //
    public Sprite                   untitled; //

    /**
	 * 
	 */
    public Sprite Get(string k) { Sprite sprite = atlas.resource.GetSprite(k); return sprite != null ? sprite : untitled; }
}
