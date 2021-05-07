// Created by: Braxton Fair
// Created on: 04/23/2021

using UnityEngine;

public class TreasureSpawner : MonoBehaviour
{
    // The treasure chest game object
    public GameObject treasureChest;

    // The chance for it to spawn
    public int ifLessThan = 25;
    public int outOf = 100;

    // Start is called before the first frame update
    void Start()
    {
        // Get all the spawn point
        GameObject point = GameObject.FindGameObjectWithTag("Treasure");

        // For each spawn point, give a chance to spawn a treasure chest there
        int spawnChance = Random.Range(0, outOf);

        // Make sure we are within the bounds to spawn and there is no lock
        if (spawnChance < ifLessThan && SharedResources.AbleToSpawnEnemies == true) {
            Instantiate(treasureChest, point.transform.position, Quaternion.identity);
        }
    }

    void Update()
    {
        GameObject point = GameObject.FindGameObjectWithTag("Treasure");
        GameObject player = GameObject.FindGameObjectWithTag("Player");

        // For each spawn point, give a chance to spawn a treasure chest there
        float distance = Vector2.Distance(point.transform.position, player.transform.position);

        // The player touched a treasure chest
        if (distance <= 1.0)
        {
            // Generate a random card
            int coinFlip = Random.Range(0, 2);
            int count = SpellDatabase.aListOfSpells.Count;
            int randomSpells = Random.Range(0, count);
            int countMinions = MinionDatabase.aListOfMinions.Count;
            int randomMinions = Random.Range(0, countMinions);

            // Choose random Spell
            if (coinFlip == 0)
            {
                var card = SpellDatabase.aListOfSpells[randomSpells];

                SharedResources.playerDeck.Add(card);
            } 
            // Or random Minion
            else if (coinFlip == 1) {
                var card = MinionDatabase.aListOfMinions[randomMinions];

                SharedResources.playerDeck.Add(card);
            }

            // Destroy the treasure object
            Destroy(point);

            GameObject treasure = GameObject.FindGameObjectWithTag("TreasureSpawner");
            Destroy(treasure);
        }
    }
}
