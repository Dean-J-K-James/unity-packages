using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>, IChanged
{
    public int xp; //

    public void AddXP(int xp)
    {
        this.xp += xp;
        this.InvokeChanged();
    }

    public void OnChanged()
    {
        this.GlobalChanged(this);
    }
}
