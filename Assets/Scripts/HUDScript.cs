//writen by dustin frandle
//4/28/2021
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUDScript : MonoBehaviour
{
    public Canvas hudAssets;
    public Text health;
    public Text deckSize;
    public Text roomCount;
    public GameObject pauseMenu;

    // Start is called before the first frame update
    void Start()
    {
        pauseMenu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        health.text = "" + SharedResources.playerHealth;
        deckSize.text = "" + SharedResources.playerDeck.Count;
        roomCount.text = "" + SharedResources.RoomVisitCounter;
        hudAssets.worldCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    public void ShowMenu()
    {
        pauseMenu.SetActive(true);
    }

    public void HideMenu()
    {
        pauseMenu.SetActive(false);
    }
    public void Quit()
    {
        SceneManager.LoadScene("MainMenu");
    }
}
