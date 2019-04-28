using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static bool paused = false;
    public GameObject pauseMenuUI;

    public bool Paused { get => paused; set => paused = value; }

    void Start()
    {
        pauseMenuUI.SetActive(false);
    }
    // Pauses and unpauses the game.
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (paused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }
    // If paused resume game, set time scale to normal and enable components.
    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        paused = false;
        GameObject.Find("ShieldCircle").GetComponent<PulseWave>().Animator.enabled = true;
        GameObject.Find("ShieldCircle").GetComponent<PulseWave>().Audio.Play();
        GameObject.Find("Main Camera").GetComponent<ShakeBehaviour>().enabled = true;
    }
    // Pause the game. Freeze time and disable components.
    public void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        paused = true;
        GameObject.Find("ShieldCircle").GetComponent<PulseWave>().Animator.enabled = false;
        GameObject.Find("ShieldCircle").GetComponent<PulseWave>().Audio.Pause();
        GameObject.Find("Main Camera").GetComponent<ShakeBehaviour>().enabled = false;
    }
    // Exits game.
    public void Exit()
    {
        Application.Quit();
    }
    // Returns to HomeScreen.
    public void HomeScreen()
    {
        SceneManager.LoadScene("SelectDifficulty");
    }
}
