using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Impact : MonoBehaviour, IComponent
{
	public float damage; //

	private void OnTriggerEnter2D(Collider2D t)
	{
		Destroy(gameObject);

		//Move this to a combat manager too.
		t.GetComponent<Health>().ChangeHealth(-damage);

		//The below should be in a CombatManager singleton so that we can calculate modifiers on top of the damage.
		TextEffect.INSTANCE.Create(t.transform.position, damage + "");
	}
}
