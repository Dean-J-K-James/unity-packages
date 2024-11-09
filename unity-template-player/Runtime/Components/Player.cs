using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Singleton<Player>, IChanged
{
    public void OnChanged()
    {
        this.GlobalChanged(this);
    }
}
