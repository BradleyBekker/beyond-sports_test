using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : DataReader
{
    [SerializeField]
    GameObject ball;
    [SerializeField]
    GameObject[] team;
    [SerializeField]
    Dictionary<int, GameObject> _players = new Dictionary<int, GameObject>();
    int counter;
    private void Start()
    {
        GameObject p;
        for (int i = 0; i < framelist[0].trackedObject.Count; i++)
        {
            switch (framelist[0].trackedObject[i].team)
            {
                 
                case 0:
                     p = Instantiate(team[0]);
                    _players.Add(framelist[0].trackedObject[i].trackingID,p);
                    break;
                case 1:
                     p = Instantiate(team[1]);
                    _players.Add(framelist[0].trackedObject[i].trackingID, p);
                    break;
                case 3:
                     p = Instantiate(team[2]);
                    _players.Add(framelist[0].trackedObject[i].trackingID, p);
                    break;
                case 4:
                     p = Instantiate(team[3]);
                    _players.Add(framelist[0].trackedObject[i].trackingID, p);
                    break;
                case -1:
                    p = Instantiate(team[4]);
                    _players.Add(framelist[0].trackedObject[i].trackingID, p);
                    break;
                default:
                    print("unacounted team" + framelist[0].trackedObject[i].team);
                    break;
            }
           
            
        }

        
         for (int i = 0; i < _players.Count; i++)
         {
            TextMeshPro text = _players[framelist[counter].trackedObject[i].trackingID].transform.GetChild(0).GetComponent<TextMeshPro>();
             text.text = "team" + framelist[0].trackedObject[i].team + "   " +"no." + framelist[0].trackedObject[i].playerNumber;
         }
         
        counter = 0;
    }
   
    void Update()
    {
        if (counter< framelist.Count)
        {
            ball.transform.position = framelist[counter].ballData.posistion;
            for (int j = 0; j < _players.Count; j++)
            {
                
                _players[framelist[counter].trackedObject[j].trackingID].transform.position = framelist[counter].trackedObject[j].pos;
                
            }
            
            counter++;
        }
        else
        {
            print(counter);
        }

    }
}
