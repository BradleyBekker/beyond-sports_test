using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallData
{
   public Vector3 posistion { get;}
    public float ballSpeed { get;}
    //clickerFlag
    public BallData(float x ,float y,float z,float speed)
    {
        posistion = new Vector3(x, z, y);
        ballSpeed = speed;
    }
    
    
}
