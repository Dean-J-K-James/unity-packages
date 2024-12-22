/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class SpawnEnemies : MonoBehaviour, IComponent, ITickerd
{
    /**
     * 
     */
    public void OnTickerd()
    {
        var wave = GetComponent<Wave>();

        if (wave.enemiesToSpawn > 0)
        {
            var angle = Random.Range(0, 360);

            var newx = Player.INSTANCE.transform.position.x + (10f * Mathf.Cos(angle));
            var newy = Player.INSTANCE.transform.position.y + (10f * Mathf.Sin(angle));

            UnitManager.INSTANCE.Create("zombie", newx, newy);

            wave.enemiesToSpawn--;
        }
    }
}
