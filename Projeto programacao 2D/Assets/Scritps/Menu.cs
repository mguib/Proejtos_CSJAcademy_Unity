using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public GameObject pauseMenu;
    bool activeMenu;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            activeMenu = !activeMenu;
            pauseMenu.SetActive(activeMenu);
        }
    }

    public void StartGame()
    {
        SceneManager.LoadScene(0);
    }

    public void ExitOptionMenu(GameObject go)
    {
        go.SetActive(false);
    }

    public void ActrivitOptionMenu(GameObject go)
    {
        go.SetActive(true);
    }
}
