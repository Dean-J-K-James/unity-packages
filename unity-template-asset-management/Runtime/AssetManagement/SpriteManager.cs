/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteManager : Singleton<SpriteManager>
{
    public SpriteAtlasResource atlas; //

    /**
	 * 
	 */
    public Sprite Get(string k)
    {
        var em = new GameObjectMetaData(k);

        Sprite sprite;

        if (sprite = atlas.resource.GetSprite(em.slug + "." + em.type + "_" + em.variation)) { return sprite; }
        if (sprite = atlas.resource.GetSprite(em.slug + "_" + em.variation)) { return sprite; }
        if (sprite = atlas.resource.GetSprite(em.slug + "." + em.type)) { return sprite; }
        if (sprite = atlas.resource.GetSprite(em.slug)) { return sprite; }

        return atlas.resource.GetSprite("untitled");
    }
}
