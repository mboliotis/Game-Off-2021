using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    bool menuVisible;
    [SerializeField] GameObject menuContainer;
    private void Start()
    {
        menuVisible = false;
        menuContainer.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (menuVisible)
            {
                menuContainer.SetActive(false);
                menuVisible = false;

            }
            else
            {
                menuContainer.SetActive(true);
                menuVisible = true;
            }
        }
    }

    public void Quit()
    {
        Application.Quit();
    }
}
