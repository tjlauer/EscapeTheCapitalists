// Created by: Braxton Fair
// Created on: 04/27/2021

using UnityEngine;
using UnityEngine.SceneManagement;

public class Transporter : MonoBehaviour
{
    public SharedResources.Direction direction = SharedResources.Direction.Top;
    public Animator animator;

    // Array of all the scene names
    public string[] topScenes = new string[] {"E", "E 1", "T", "T 1", "TL", "TL 1", "TR", "TR 1", "TRL", "TRL 1", "TB", "TB 1", "RTB", "RTB 1", "LTB", "LTB 1"};
    public string[] leftScenes = new string[] {"E", "E 1", "TL", "TL 1", "TRL", "TRL 1", "L", "L 1", "LR", "LR 1", "LRB", "LRB 1", "LB", "LB 1", "LTB", "LTB 1"};
    public string[] rightScenes = new string[] {"E", "E 1", "TR", "TR 1", "TRL", "TRL 1", "LR", "LR 1", "LRB", "LRB 1", "R", "R 1", "RB", "RB 1", "RTB", "RTB 1"};
    public string[] bottomScenes = new string[] {"E", "E 1", "TB", "TB 1", "LRB", "LRB 1", "LB", "LB 1", "RB", "RB 1", "B", "B", "RTB", "RTB 1", "LTB", "LTB 1"};

    private void OnTriggerEnter2D(Collider2D collider)
    {
        // Genereate a random number to choose from the list of rooms
        int rand = Random.Range(0, topScenes.Length);

        // Increment the room counter
        SharedResources.RoomVisitCounter++;

        // Make it so we can spawn monsters and treasure chests again
        SharedResources.AbleToSpawnEnemies = true;
        
        // If the collider sees a player
        if (collider.CompareTag("Player")) {
            // Fade out
            animator.SetTrigger("FadeOut");

            // Check each direction and choose the next level to load
            switch (direction) {
                case SharedResources.Direction.Top:
                    SharedResources.playerDirection = SharedResources.Direction.Top;

                    SharedResources.levelToLoad = bottomScenes[rand];

                    break;
                case SharedResources.Direction.Left:
                    SharedResources.playerDirection = SharedResources.Direction.Left;

                    SharedResources.levelToLoad = rightScenes[rand];

                    break;
                case SharedResources.Direction.Right:
                    SharedResources.playerDirection = SharedResources.Direction.Right;

                    SharedResources.levelToLoad = leftScenes[rand];

                    break;
                case SharedResources.Direction.Bottom:
                    SharedResources.playerDirection = SharedResources.Direction.Bottom;
                    SharedResources.levelToLoad = topScenes[rand];
                    break;
            }

            // If there are greater than 10 rooms, start the counter to randomly go to the boss room
            if (SharedResources.RoomVisitCounter >= 3)
            {
                SharedResources.ChanceToBeBoss += 20;
                int chanceToBeBoss = Random.Range(0, 101);

                if (chanceToBeBoss <= SharedResources.ChanceToBeBoss)
                {
                    SharedResources.playerDirection = SharedResources.Direction.Center;

                    SharedResources.levelToLoad = "Boss";
                }
            }
        }
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SharedResources.levelToLoad);
    }
}
