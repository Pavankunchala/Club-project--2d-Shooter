using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoboEnemy : Enemy
{

    public GameObject bullet;
    // use for initalization
    public override void Init()
    {
        base.Init();
    }

    public override void Update()
    {
        base.Update();

       if(anim.GetBool("InCombat") == true)
        {
            Instantiate(bullet, transform.position,Quaternion.identity);
        }
    }
}
