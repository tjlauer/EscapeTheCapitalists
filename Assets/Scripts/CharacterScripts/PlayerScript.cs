// written Dustin Frandle
// 4/7/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour 
{
    //vars
    public Transform movePoint;
    public LayerMask collisonLayer;
    private readonly float moveSpeed = 10f;
    public readonly float movementCooldown = .3f;
    private float timeSinceLastMove = .3f;//starts at .3 so you can move right away
    private bool enemiesCanMove;
    private CharacterMovmentHelper move;

    //properties
    public bool EnemiesCanMove
    {
        get { return enemiesCanMove; }
        set { enemiesCanMove = value;}
    }
    public float TimeSinceLastMove 
    {
        get {return timeSinceLastMove; } // only this class is allowed to change the value - so there is no set 
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
        if (move == null)
        {
            move = new CharacterMovmentHelper(collisonLayer, movePoint);
        }
        timeSinceLastMove += Time.deltaTime;//keeps track of the time since the last move was made
        transform.position = Vector3.MoveTowards(transform.position, movePoint.position, moveSpeed * Time.deltaTime);//moves the player to the movement point

        if(Vector3.Distance(transform.position,movePoint.position)== 0f && timeSinceLastMove > movementCooldown)
        {
            if (Input.GetAxisRaw("Horizontal") > 0f)// move Right
            {
                enemiesCanMove = move.MoveRight();
            }
            else if (Input.GetAxisRaw("Horizontal") < 0f)// move Left
            {
                enemiesCanMove = move.MoveLeft();
            }
            else if (Input.GetAxisRaw("Vertical") > 0f)// move up
            {
                enemiesCanMove = move.MoveUp();
            }
            else if (Input.GetAxisRaw("Vertical") < 0f)// move down
            {
                enemiesCanMove = move.MoveDown();
            }
            timeSinceLastMove = 0f;// a move just happned so this is set to 0
            //stop animation
        }
        else
        {
            //start animation
        }

        
    }
}
