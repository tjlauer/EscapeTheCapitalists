//written by dustin frandle
//4/27/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Treasuer : MonoBehaviour
{
    private bool hasEncounter;
    public PlayerScript player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position == player.transform.position && !hasEncounter)
        {
            Debug.LogError("TREASUER! " + name);
            hasEncounter = true;
        }
    }
}
