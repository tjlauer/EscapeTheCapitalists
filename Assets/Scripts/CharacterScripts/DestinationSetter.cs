//writen by dustin frandle
//4/28/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class DestinationSetter : MonoBehaviour
{
    public AIPath pathfinding;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        pathfinding.destination = GameObject.FindGameObjectWithTag("Player").transform.position;
    }
}
