using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using RAIN.Action;
using RAIN.Core;

[RAINAction]
public class PlayerChase : RAINAction
{
    public GameObject player;
    public override void Start(RAIN.Core.AI ai)
    {
        base.Start(ai);
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public override ActionResult Execute(RAIN.Core.AI ai)
    {
        if (player == null) {
            return ActionResult.FAILURE;
        }
        ai.Motor.MoveTo(player.transform.position);
        //ai.Motor.DefaultRotationSpeed = 0.5f;
        return ActionResult.RUNNING;
        
    }

    public override void Stop(RAIN.Core.AI ai)
    {
        base.Stop(ai);
    }

}