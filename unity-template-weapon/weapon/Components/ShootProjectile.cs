/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class ShootProjectile : MonoBehaviour, IComponent, IUseItem, ICreated<PrefData>
{
	public Projectile proj; //
	public string projectile; //

	public void OnCreated(PrefData param)
	{
		proj = Asset.INSTANCE.Get<Projectile>(projectile);
	}

	/**
     * 
     */
	public void OnUseItem(Unit s)
	{
		var target = GetComponent<ITarget>().GetTargets(s);


		foreach (var t in target)
		{
			//Spawn projectile.
			//Set it's target position to the target.

			//Have a ProjectileManager for creating the projectile. This lets the transform parent be set correctly.
			var p = Instantiate(proj);
			p.transform.position = s.transform.position;
			p.gameObject.SetActive(true);

			//The below will be set according to a srting.
			//For now it is manually done.
			//Weapon is set in the projectile so it knows the speed, damage, and so on...
			p.gameObject.GetComponent<MoveToTarget>().target = t.transform.position;

			//Some projectiles move to a fixed position target.
			//Some move to a dynamic target (Unit that is moving).
			//Some move in a random direction. (This could be similar to the fixed position target. Set the random offset in this script.


			//Projectile entities just have their sprite and effects.
			//The weapon script adds the component it needs and sets the target.
		}
	}
}
