/******************************************************/
/* Dean James * Pangean Flying Cactus * Unity Project */
/******************************************************/

using UnityEngine;

/**
 * 
 */
public class WaveUI : MonoBehaviour, IChanged
{
    public StringUI wave; //
    public StringUI enemiesRemaining; //
    public StringUI enemiesOnMap; //

    /**
     * 
     */
    public void OnChanged()
    {
        wave.Change("Wave: " + Wave.INSTANCE.wave);
        enemiesRemaining.Change("Enemies Remaining: " + Wave.INSTANCE.enemiesToSpawn);
        enemiesOnMap.Change("Enemies On Map: " + (UnitManager.INSTANCE.transform.childCount - 1));
    }
}
