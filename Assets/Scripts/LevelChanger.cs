// Created by: Braxton Fair
// Created on: 04/23/2021

using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{
    // Reference to an Animator
    public Animator animator;

    // Fade to level animation
    public void FadeToLevel()
    {
        animator.SetTrigger("FadeOut");
    }

    // Load the next scene after the animation
    public void OnFadeComplete()
    {
        SceneManager.LoadScene(SharedResources.levelToLoad);
    }
}
