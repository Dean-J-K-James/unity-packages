/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class SpriteInstance : MonoBehaviour, IComponent, ICreated<PrefData>
{
    public int layer;   //

    /**
     * 
     */
    public void OnCreated(PrefData pd)
    {
        gameObject.AddComponent<SpriteRenderer>();
        gameObject.GetComponent<SpriteRenderer>().sprite = SpriteManager.INSTANCE.Get(name);
        gameObject.GetComponent<SpriteRenderer>().sortingOrder = layer;
    }
}
