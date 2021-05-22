using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public static bool isPaused = false;

    public AudioSource songAudioSource;

    public GameObject pauseCanvas;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isPaused)
            {
                Resume();
            }
            else
            {
                pause();
            }
        }
    }

    public void PauseResume()
    {
        if (isPaused)
        {
            isPaused = false;
            Time.timeScale = 1;
            songAudioSource.UnPause();
        }
        else
        {
            isPaused = true;
            Time.timeScale = 0;
            songAudioSource.Pause();
        }
    }

    public void pause()
    {
        isPaused = true;
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);
        songAudioSource.Pause();
    }

    public void Resume()
    {
        isPaused = false;
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
        songAudioSource.UnPause();
    }


}
