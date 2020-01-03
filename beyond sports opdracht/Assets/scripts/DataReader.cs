using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
public class DataReader : MonoBehaviour
{
    protected List<Frame> framelist;
    void Awake()
    {
      framelist = new List<Frame>();
        StreamReader reader = new StreamReader("Assets\\Resources\\match_data.dat");

        for (int i = 0; i < 57294; i++)
        {
            string[] currentLine = reader.ReadLine().Split(':');
            string[] playerData = currentLine[1].Split(';');
            string[] ballData = currentLine[2].Split(',');
            Frame F = new Frame();
            F.frameCount = int.Parse(currentLine[0]);
            F.trackedObject = new List<TrackedObject>();

            for (int j = 0; j < playerData.Length-1; j++)
            {
                string[] currentPlayer = playerData[j].Split(',');
                F.trackedObject.Add(new TrackedObject(int.Parse(currentPlayer[0]), int.Parse(currentPlayer[1]), int.Parse(currentPlayer[2]), float.Parse(currentPlayer[3]), float.Parse(currentPlayer[4]), float.Parse(currentPlayer[5])));
            }

            F.ballData = new BallData(float.Parse(ballData[0]), float.Parse(ballData[1]), float.Parse(ballData[2]), float.Parse(ballData[3]));
            framelist.Add(F);
        }
        reader.Close();
    }


}
