using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsUI : SingletonListener, IChanged<Player>
{
    public StringUI health; //
    public StringUI xp; //

    /**
     * 
     */
    public void OnChanged(Player player)
    {
        health.Change("Health: " + player.GetComponent<Health>().health + "/ " + player.GetComponent<Health>().maxHealth);
        xp.Change("XP: " + player.xp);
    }
}
