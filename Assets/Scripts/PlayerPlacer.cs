// Created by: Braxton Fair
// Created on: 04/23/2021

using UnityEngine;

public class PlayerPlacer : MonoBehaviour
{
    public GameObject player;

    void OnEnable()
    {
        // Switch between each possible player direction
        switch(SharedResources.playerDirection) {
            // If the player should be spawned in the center
            case SharedResources.Direction.Center:
                // Just the beginning, do nothing
                Instantiate(player, new Vector3(0, 0.3F, 0), Quaternion.identity);
                break;
            // If the player entered a top room and needs to be spawned at the bottom
            case SharedResources.Direction.Top:
                Instantiate(player, new Vector3(0, -3.3F, 0), Quaternion.identity);
                break;
            // If the player entered a left room and needs to be spawned at the right
            case SharedResources.Direction.Left:
                Instantiate(player, new Vector3(7.2F, 0.3F, 0), Quaternion.identity);
                break;
            // If the player entered a right room and needs to be spawned at the left
            case SharedResources.Direction.Right:
                Instantiate(player, new Vector3(-7.2F, 0.3F, 0), Quaternion.identity);
                break;
            // If the player entered a bottomr room and needs to be spawned at the top
            case SharedResources.Direction.Bottom:
                Instantiate(player, new Vector3(0, 3.3F, 0), Quaternion.identity);
                break;
        }
    }
}
