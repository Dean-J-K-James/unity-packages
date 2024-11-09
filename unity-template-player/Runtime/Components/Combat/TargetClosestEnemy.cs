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
        var enemies = FindObjectsByType<Enemy>(FindObjectsSortMode.None);

        if (enemies.Length == 0)
        {
            return;
        }

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
            this.InvokeFireWpn(source, closest.GetComponent<Unit>());
        }
    }
}
