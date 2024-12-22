/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteInstance : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public int spriteLayer;   //

    /**
     * 
     */
    public void OnCreated(PrefData pd)
    {
        gameObject.AddComponent<SpriteRenderer>().sprite = SpriteManager.INSTANCE.Get(name);
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = spriteLayer;
    }
}
