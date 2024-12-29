/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class FollowPlayer : MonoBehaviour, IComponent, IUpdated
{
    public float movementSpeed; //

    /**
     * 
     */
    public void OnUpdated()
    {
        Vector3 direction = Player.INSTANCE.transform.position - transform.position;
        direction.Normalize();
        GetComponent<Rigidbody2D>().velocity = direction * movementSpeed;
        //if (Vector2.Distance(transform.position, Player.INSTANCE.transform.position.position) <= 1f)
        //{
        //    player.GetComponent<Player>().DamagePlayer();
        //    Destroy(gameObject);
        //}
    }
}
