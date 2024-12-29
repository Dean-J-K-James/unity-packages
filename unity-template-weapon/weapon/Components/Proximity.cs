/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class Proximity : MonoBehaviour, IComponent, IUseItem
{
	public float damage;

	/**
     * 
     */
	public void OnUseItem(Unit s)
	{
		var target = GetComponent<ITarget>().GetTargets(s);

		foreach (var t in target)
		{
			//Move this to a combat manager too.
			t.GetComponent<Health>().ChangeHealth(-damage);

			//The below should be in a CombatManager singleton so that we can calculate modifiers on top of the damage.
			TextEffect.INSTANCE.Create(t.transform.position, damage + "");
		}
	}
}
