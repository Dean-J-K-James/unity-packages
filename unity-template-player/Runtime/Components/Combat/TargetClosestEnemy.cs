/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class TargetClosestEnemy : MonoBehaviour, IComponent, IUseItem
{
    public float range;

    /**
     * 
     */
    public void OnUseItem(Unit source) //Will have to pass the Unit doing the firing to get it's position.
    {
        //Debug.Log("OnUseItem");

        var enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);

        if (enemies.Length == 0)
        {
            return;
        }

        //The below can be a utility script, similar to DrawLine.
        //Pass a comparison that returns a weighted integer for priority.
        //Closer enemy, higher priority.
        //Other script will do higher priority for enemy health.

        Enemy closest = null;
        float closestDistance = Mathf.Infinity;

        foreach (Enemy enemy in enemies)
        {
            var dist = Vector2.Distance(source.transform.position, enemy.transform.position);

            if (dist < closestDistance)
            {
                closest = enemy;
                closestDistance = dist;
            }
        }

        if (closest != null && closestDistance <= range)
        {
            //Debug.Log("Firing Weapon");
            this.InvokeFireWpn(source, closest.GetComponent<Unit>());
        }
    }
}
