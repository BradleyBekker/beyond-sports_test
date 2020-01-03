using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackedObject 
{
   public int team { get; }
    int trackingID;
    int playerNumber;
    public Vector2 pos { get; }
    float speed;
    public TrackedObject(int Team,int ID,int PlayerNum, float x,float y,float Speed)
    {
        team = Team;
        trackingID = ID;
        playerNumber = PlayerNum;
        pos = new Vector2(x, y);
        speed = Speed;
    }
}
