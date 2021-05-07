// written Dustin Frandle
// 4/7/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

class CharacterMovmentHelper
{
    //vars
    private Transform movePoint;
    private LayerMask collisonLayer;

    //properties
    public LayerMask CollisonLayer
    {
        get { return collisonLayer; }
        set { collisonLayer = value; }
    }
    public Transform MovePoint
    {
        get { return movePoint; }
        set { movePoint = value; }
    }

    //constructors
    public CharacterMovmentHelper(LayerMask collisonLayer, Transform movePoint)
    {
        CollisonLayer = collisonLayer;
        MovePoint = movePoint;
    }

    //methods
    public bool MoveRight()
    {
        if (!Physics2D.OverlapPoint(movePoint.position + new Vector3(.6f, 0f, 0f), collisonLayer))
        {
            movePoint.position += new Vector3(.6f, 0f, 0f);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool MoveLeft()
    {
        if (!Physics2D.OverlapPoint(movePoint.position + new Vector3(-.6f, 0f, 0f), collisonLayer))
        {
            movePoint.position += new Vector3(-.6f, 0f, 0f);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool MoveUp()
    {
        if (!Physics2D.OverlapPoint(movePoint.position + new Vector3(0f, .6f, 0f), collisonLayer))
        {
            movePoint.position += new Vector3(0f, .6f, 0f);
            return true;
        }
        else
        {
            return false;
        }
    }
    public bool MoveDown()
    {
        if (!Physics2D.OverlapPoint(movePoint.position + new Vector3(0f, -.6f, 0f), collisonLayer))
        {
            movePoint.position += new Vector3(0f, -.6f, 0f);
            return true;
        }
        else
        {
            return false;
        }
    }
}
