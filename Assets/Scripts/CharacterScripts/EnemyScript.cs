// written Dustin Frandle
// 4/7/2021
using Pathfinding;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyScript : MonoBehaviour
{
    //vars
    public Transform movePoint;
    public LayerMask collisonLayer;
    public AIPath pathfinding;
    public PlayerScript player;
    private readonly float moveSpeed = 10f;
    private bool thisCanMove = false;
    private bool moveBuffer = true;
    private CharacterMovmentHelper move;
    private bool hasEncounter;

    //proprties
    public bool ThisCanMove
    {
        get { return thisCanMove; }
        set { thisCanMove = value; }
    }
    public bool HasEncounter
    {
        get { return hasEncounter; }
        set { hasEncounter = value; }
    }


    // Start is called before the first frame update
    void Start()
    {
        movePoint.parent = null;
        move = new CharacterMovmentHelper(collisonLayer, movePoint);
    }

    // Update is called once per frame
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerScript>();
        if (move == null)
        {
            move = new CharacterMovmentHelper(collisonLayer, movePoint);
        }
        float x = Convert.ToSingle(Math.Round(pathfinding.desiredVelocity.x, 2));
        float y = Convert.ToSingle(Math.Round(pathfinding.desiredVelocity.y, 2));


        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);//moves the enemy to the movement point
        if (thisCanMove && moveBuffer)
        {
            thisCanMove = false;
            moveBuffer = false;
        }
        else if (thisCanMove)
        {
            
            //Debug.LogWarning("X: " + x + " ||| Y: " + y +" |||" + name);
            
            if (Math.Abs(x) > Math.Abs(y))//Move horizontaly
            {
                if (x > 0)// move Right
                {
                    thisCanMove = !move.MoveRight();
                    moveBuffer = !thisCanMove;
                }
                else if (x < 0)// move Left
                {
                    thisCanMove = !move.MoveLeft();
                    moveBuffer = !thisCanMove;
                }
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------
            else if (Math.Abs(x) == Math.Abs(y))//diagonal edge case
            {
                if (x > 0)// if you want to go right
                {
                    if (move.MoveRight())// try going right
                    {
                        thisCanMove = false;// if we get here we succseded
                        moveBuffer = !thisCanMove;
                    }
                    else// else try a vertical move
                    {
                        if (y > 0)// if we want to go up
                        {
                            thisCanMove = !move.MoveUp();//try to move Up
                            moveBuffer = !thisCanMove;
                        }
                        else if (y < 0)
                        {
                            thisCanMove = !move.MoveDown();//else try to move down
                            moveBuffer = !thisCanMove;
                        }
                    }
                }
                else if (x < 0)// if you want to go left
                {
                    if (move.MoveLeft())// try going left
                    {
                        thisCanMove = false;// if we get here we succseded
                        moveBuffer = !thisCanMove;
                    }
                    else// else try a vertical move
                    {
                        if (y > 0)// if we want to go up
                        {
                            thisCanMove = !move.MoveUp();//try to move Up
                            moveBuffer = !thisCanMove;
                        }
                        else if (y < 0)
                        {
                            thisCanMove = !move.MoveDown();//else try to move down
                            moveBuffer = !thisCanMove;
                        }
                    }
                }
            }
            //-------------------------------------------------------------------------------------------------------------------------------------------------
            else // move verticaly
            {
                if (y > 0)// move up
                {
                    thisCanMove = !move.MoveUp();
                    moveBuffer = !thisCanMove;
                }
                else if (y < 0)// move down
                {
                    thisCanMove = !move.MoveDown();
                    moveBuffer = !thisCanMove;
                }
            }


            //Debug.LogWarning(name + " Moved");
            //stop animation
        }
        else
        {
            //Debug.LogWarning(name + " Cant Move");
            //start animation
        }

        float distance = Vector2.Distance(transform.position, player.transform.position);
        if (distance <= 0.5 && !hasEncounter)
        {
            hasEncounter = true;
            SharedResources.levelToLoad = SceneManager.GetActiveScene().name;
            SceneManager.LoadScene("EncounterScene");
            Debug.LogError("ENCOUNTER! " + name);
        }
    }
}
