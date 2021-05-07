// written Dustin Frandle
// 4/7/2021
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyControler : MonoBehaviour
{
    private GameObject[] listOfEnemies;
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
        listOfEnemies = GameObject.FindGameObjectsWithTag("Enemies");
        player = GameObject.FindGameObjectWithTag("Player");
        if (player.GetComponent<PlayerScript>().EnemiesCanMove)
        {
            foreach(var enemy in listOfEnemies)
            {
                try
                {
                    enemy.GetComponent<EnemyScript>().ThisCanMove = true;
                }
                catch(Exception e)
                {
                    Debug.LogError("Could not get enemy \n" + e.Message + "\n-----------\n"+ e.StackTrace);
                }
            }
            player.GetComponent<PlayerScript>().EnemiesCanMove = false;
        }
    }
}
