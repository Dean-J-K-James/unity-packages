/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class Combat : MonoBehaviour, IComponent, ICreated<PrefData>, IUpdated
{
    public string defaultWeapon;
    public Item item;
    public float cooldown;

    public void OnCreated(PrefData pd)
    {
        Debug.Log("Combat OnCreated");
		item = Asset.INSTANCE.Get<Item>(defaultWeapon);
    }

    public void OnUpdated()
    {
        cooldown -= Time.deltaTime; //If the player has a perk that increases shooting speed, increase by Time.deltaTime * modifier.

        if (item != null && cooldown <= 0)
        {
            cooldown = item.cooldown;

			item.InvokeUseItem(GetComponent<Unit>());
        }
    }
}
