/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class Melee : MonoBehaviour, IComponent, IFireWpn
{
    public float damage;

    /**
     * 
     */
    public void OnFireWpn(Unit source, Unit target)
    {
        target.GetComponent<Health>().ChangeHealth(-damage);

        //The below should be in a CombatManager singleton so that we can calculate modifiers on top of the damage.
        PopupManager.INSTANCE.CreatePopup(target.transform.position, damage + "");

        Debug.Log("OnFireWpn");
    }
}
