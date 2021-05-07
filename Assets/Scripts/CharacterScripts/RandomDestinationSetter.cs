//Written by Dustin Frandle
// 4/27/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class RandomDestinationSetter : MonoBehaviour
{
    public EnemyScript thisEnemy;
    private bool changeDestination = false;
    private bool checkedMove = false;
    private bool stuck = false;
    private int moveCounter = 0;
    public AIPath pathfinding;
    //grid bounds
    float xMax = 8.4f;
    float xMin = -8.4f;
    float yMax = 4.5f;
    float yMin = -4.5f;


    // Start is called before the first frame update
    void Start()
    {
        

    }

    // Update is called once per frame
    void Update()
    {
        if (thisEnemy.ThisCanMove && !checkedMove)
        {
            moveCounter++;
            checkedMove = true;
        }
        else if (!thisEnemy.ThisCanMove && checkedMove)
        {
            checkedMove = false;
        }
        else if (thisEnemy.ThisCanMove && checkedMove && !stuck)
        {
            stuck = true;
        }


        if (moveCounter > 7 || stuck)
        {
            changeDestination = true;
            moveCounter = 0;
        }
        


        if (!pathfinding.pathPending && ( changeDestination || !pathfinding.hasPath || pathfinding.reachedEndOfPath))
        {
            pathfinding.destination = PickRandomPoint();
            pathfinding.SearchPath();
            moveCounter = 0;
            changeDestination = false;
            stuck = false;
        }
    }

    Vector3 PickRandomPoint()
    {
        int x = Random.Range(-5, 5);
        int y = Random.Range(-5, 5);
        Vector3 point = new Vector3(x*.6f,y*.6f, 0f);
        point += pathfinding.position;
        if(point.x > xMax || point.x < xMin)
        {
            point.x = 0;
        }
        if (point.y > yMax || point.y < yMin)
        {
            point.y = 0;
        }
        if (stuck)
        {
            Debug.LogWarning(name + " is stuck! new destintaion: [ " + x + " , " + y + " ] to " + point + "\ncurrent pos: " + pathfinding.position);
        }
        return point;
    }
}
