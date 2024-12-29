using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrantXP : MonoBehaviour, IComponent, IDeleted
{
    public int xp;

    /**
     * 
     */
    public void OnDeleted()
    {
        Player.INSTANCE.AddXP(xp);
    }
}
