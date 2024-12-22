/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class WaveTester : MonoBehaviour, IComponent, ITickerd
{
    /**
     * 
     */
    public void OnTickerd() { var wave = GetComponent<Wave>(); if (wave.enemiesToSpawn == 0) { wave.wave++; wave.enemiesToSpawn = wave.wave * 10; } }
}
