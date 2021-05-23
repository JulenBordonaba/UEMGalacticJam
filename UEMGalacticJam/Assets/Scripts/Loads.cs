using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loads : MonoBehaviour
{

    public void quit()
    {
        Application.Quit();
    }
    public void loadscene(string game)
    {
        SceneManager.LoadScene(game);
        Time.timeScale = 1;
        Pause.isPaused = false;
    }

    public void reinicio(string game)
    {
        SceneManager.LoadScene(game);
        Time.timeScale = 1;
        Pause.isPaused = false;
    }
    public void pause()
    {
        Time.timeScale = 0;
    }
    public void resume()
    {
        Time.timeScale = 1;
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
