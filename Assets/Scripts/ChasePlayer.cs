using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RAIN.Core;
using RAIN.Action;
[RAINAction]
public class ChasePlayer : RAINAction {
    // float chase_Speed=10f;
    public GameObject player;
    EnemyShoot eShoot;
    // Use this for initialization
    public override void Start(AI ai)
    {
        
        base.Start(ai);
        
        eShoot = ai.WorkingMemory.GetItem<EnemyShoot>("EnemyShoot");
    }
    
    public override ActionResult Execute(AI ai)
    {
       
        eShoot.LookAt();
        if (player == null)
        {
            return ActionResult.FAILURE;
        }
        //  ai.Motor.MoveTo(player.transform.position);

        //ai.Motor.Speed = 8f;
       
        
        return ActionResult.RUNNING;
       // return base.Execute(ai);
    }

    
    public override void Stop(AI ai)
    {
        base.Stop(ai);
    }
}
