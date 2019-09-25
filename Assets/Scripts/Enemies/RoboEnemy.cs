using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboEnemy : Enemy
{
    // use for initalization
    public override void Init()
    {
        base.Init();
    }

    public override void Update()
    {
        base.Update();

        if (enumHealth.currentHealth < enumHealth.fullHealth)
        {
            isHit = true;
            anim.SetBool("InCombat", true);
        }
    }
}
