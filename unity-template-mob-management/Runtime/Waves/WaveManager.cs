/***************************************************************/
/* Dean James * Pangean Flying Cactus * Project Dungeon Trials */
/***************************************************************/


using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

/**
* 
*/
public class WaveManager : Singleton<WaveManager>
{
    public int wave = 0; //
    public int enemiesToSpawn; //

    /*
     * 
     */
    public void NextWave()
    {
        //Maybe this should be calculated in Biome.OnTickerd, at the end.
        wave++;
        enemiesToSpawn = wave * 10;
    }
}
