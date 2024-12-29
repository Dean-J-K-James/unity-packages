/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using System.Collections.Generic;
using UnityEngine;

/**
 * 
 */
public class TargetWithinRange : MonoBehaviour, IComponent, ITarget
{
	public string target; //
	public float range; //

	/**
     * 
     */
	public Unit[] GetTargets(Unit source) //Will have to pass the Unit doing the firing to get it's position.
	{
		//Debug.Log("OnUseItem");

		//var enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);
		var enemies = GameObject.FindGameObjectsWithTag(target);

		List<Unit> targets = new();

		//The below can be a utility script, similar to DrawLine.
		//Pass a comparison that returns a weighted integer for priority.
		//Closer enemy, higher priority.
		//Other script will do higher priority for enemy health.

		foreach (var enemy in enemies)
		{
			var dist = Vector2.Distance(source.transform.position, enemy.transform.position);

			if (dist <= range)
			{
				targets.Add(enemy.GetComponent<Unit>());
			}
		}

		return targets.ToArray();
	}
}
