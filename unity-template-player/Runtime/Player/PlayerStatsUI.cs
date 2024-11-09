using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStatsUI : SingletonListener, IChanged<Player>
{
    public StringUI health; //

    /**
     * 
     */
    public void OnChanged(Player player)
    {
        health.Change("Health: " + player.GetComponent<Health>().health + "/ " + player.GetComponent<Health>().maxHealth);
    }
}
