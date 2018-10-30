using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paralysis : Effector
{
    bool onEntity;

    private void Start()
    {
        onEntity = (gameObject.GetComponent<Health>() != null);
        type = EffectType.Paralysis;
    }
    protected override void DoEffect()
    {
<<<<<<< HEAD
        if(onEntity)
            gameObject.GetComponent<PlayerMovement>().moveSpeed = 0;
=======
        //if(onEntity)
            //gameObject.GetComponent<Health>().moveSpeed = 0;
>>>>>>> Items
    }

    protected override void RevertEffect()
    {
<<<<<<< HEAD
        if (onEntity)
            gameObject.GetComponent<PlayerMovement>().moveSpeed = GetComponent<PlayerMovement>().defaultSpeed;
=======
        //if (onEntity)
            //gameObject.GetComponent<Health>().moveSpeed = GetComponent<Health>().defaultSpeed;
>>>>>>> Items
    }
}
