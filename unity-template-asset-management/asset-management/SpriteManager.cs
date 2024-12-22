/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;
using UnityEngine.U2D;

/**
 * 
 */
public class SpriteManager : Singleton<SpriteManager>
{
    public SpriteAtlas atlas;    //

    /**
	 * 
	 */
    public Sprite Get(string k) { Sprite sprite = atlas.GetSprite(k); return sprite != null ? sprite : atlas.GetSprite("untitled"); }
}
