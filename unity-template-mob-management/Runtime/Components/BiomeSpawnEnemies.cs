/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/

using UnityEngine;

/**
 * 
 */
public class BiomeSpawnEnemies : MonoBehaviour, IComponent, ITickerd<BiomeData>
{
    /**
     * 
     */
    public void OnTickerd(BiomeData bd)
    {
        //Each wave has a number of enemies to spawn.
        //Each wave has an array of enemy slugs to spawn.
        //On update, check what wave it is. If 


        //Have as WaveChecker script that counts enemiesRemaining + enemiesOnMap.
        //If total is 0, increment the wave.

        //WaveSpawner checks enemiesLeftToSpawn[wave].
        //If greater than 0, spawn an enemy.

        if (WaveManager.INSTANCE.enemiesToSpawn > 0)
        {
            var angle = Random.Range(0, 360);

            var newx = Player.INSTANCE.transform.position.x + (10f * Mathf.Cos(angle));
            var newy = Player.INSTANCE.transform.position.y + (10f * Mathf.Sin(angle));

            UnitManager.INSTANCE.Create("zombie", newx, newy);

            WaveManager.INSTANCE.enemiesToSpawn--;

            //var e = Instantiate(enemies[Random.Range(0, enemies.Length)], transform);
            //e.name = "enemy-" + enemyCount++;

            //e.transform.position = new Vector2(newx, newy);
        }
    }
}
