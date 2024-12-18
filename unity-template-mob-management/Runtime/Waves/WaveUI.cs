using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveUI : MonoBehaviour, IChanged<Game>
{
    public StringUI wave; //
    public StringUI enemiesRemaining; //
    public StringUI enemiesOnMap; //

    /**
     * 
     */
    public void OnChanged(Game game)
    {
        wave.Change("Wave: " + WaveManager.INSTANCE.wave);
        enemiesRemaining.Change("Enemies Remaining: " + WaveManager.INSTANCE.enemiesToSpawn);
        enemiesOnMap.Change("Enemies On Map: " + (UnitManager.INSTANCE.transform.childCount - 1));
    }
}
