using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameScript : DataReader
{
    [SerializeField]
    GameObject ball;
    [SerializeField]
    GameObject[] players;
    [SerializeField]
    GameObject[] team;

    int counter;
    private void Start()
    {
        for (int i = 0; i < 29; i++)
        {
            switch (framelist[0].trackedObject[i].team)
            {
                case 0:
                    Instantiate(team[0]);
                    break;
                case 1:
                    Instantiate(team[1]);
                    break;
                case 3:
                    Instantiate(team[2]);
                    break;
                case 4:
                    Instantiate(team[3]);
                    break;
                default:
                    break;
            }
            
        }
        players = GameObject.FindGameObjectsWithTag("Player");
        for (int i = 0; i < players.Length; i++)
        {
           TextMeshPro text = players[i].transform.GetChild(0).GetComponent<TextMeshPro>();
            text.text = "team" + framelist[0].trackedObject[i].team + "   " +"no." + framelist[0].trackedObject[i].playerNumber;
        }
    }
    void Update()
    {
        if (counter< framelist.Count)
        {
            ball.transform.position = framelist[counter].ballData.posistion;
            for (int j = 0; j < players.Length; j++)
            {
                players[j].transform.position = framelist[counter].trackedObject[j].pos;
            }
            counter++;
        }
        else
        {
            print(counter);
        }

    }
}
