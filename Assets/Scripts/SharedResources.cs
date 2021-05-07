// Created by: Braxton Fair
// Created on: 04/24/2021

using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts.CardFunctions;

public class SharedResources : MonoBehaviour
{
    // An enum to store direction to place the plater
    public enum Direction {
        Top,
        Left,
        Right,
        Bottom,
        Center
    }

    // Get the players direction
    public static Direction playerDirection = Direction.Center;

    // The next level to load
    public static string levelToLoad;

    // Percentage
    public static int ChanceToBeBoss = 0;

    // The amount of rooms visited
    public static int RoomVisitCounter = 1;

    // A lock to not spawn enemies
    public static bool AbleToSpawnEnemies = true;

    // Player properties
    public static int playerHealth = 100;
    public static int budget = 1;

    // The players deck
    public static List<Card> playerDeck = new List<Card>();
}
