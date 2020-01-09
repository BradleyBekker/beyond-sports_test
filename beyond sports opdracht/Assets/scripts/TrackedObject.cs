using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject 
{
   public int team { get; }
    public int trackingID { get; }
    public int playerNumber { get; }
    public Vector3 pos { get; }
    float speed;
    public TrackedObject(int Team,int ID,int PlayerNum, float x,float y,float Speed)
    {
        team = Team;
        trackingID = ID;
        playerNumber = PlayerNum;
        pos = new Vector3(x, 0,y);
        speed = Speed;
    }
}
