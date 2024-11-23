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
    public Weapon weapon;
    public float cooldown;

    public void OnCreated(PrefData pd)
    {
        weapon = Asset.INSTANCE.Get<Weapon>(defaultWeapon);
    }

    public void OnUpdated()
    {
        cooldown -= Time.deltaTime; //If the player has a perk that increases shooting speed, increase by Time.deltaTime * modifier.

        if (weapon != null && cooldown <= 0)
        {
            cooldown = weapon.cooldown;

            weapon.InvokeUseItem(GetComponent<Unit>());
        }
    }
}
