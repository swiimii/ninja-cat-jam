using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenuController : MonoBehaviour
{
    public MovementController controller;
    public PauseMenuController pauseMenu;
    // Start is called before the first frame update
    private void Start()
    {
        pauseMenu = this;
        controller = GameObject.FindGameObjectWithTag("Player").GetComponent<MovementController>();

    }
    public void ResumeLevel()
    {
        controller.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }

    public void RestartLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Update is called once per frame
    public void ReturnToMainMenu()
    {
        SceneManager.LoadScene(0);
    }

    public void PauseGame()
    {
        pauseMenu.gameObject.SetActive(true);
        controller.gameObject.SetActive(false);


    }
}
