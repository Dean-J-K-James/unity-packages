/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class TargetPlayer : MonoBehaviour, IComponent, IUseItem
{
    public float range;

    /**
     * 
     */
    public void OnUseItem(Unit source)
    {
        if (Vector2.Distance(source.transform.position, Player.INSTANCE.transform.position) <= range)
        {
            this.InvokeFireWpn(source, Player.INSTANCE.GetComponent<Unit>());
        }
    }
}
