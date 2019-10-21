using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonManager : MonoBehaviour
{
    private bool isActive;

    void start()
    {
        isActive = false;
    }
    public void carregaCena(string cena)
    {
        StartCoroutine(delay());
        SceneManager.LoadScene(cena);
    }

    public void sair()
    {
        StartCoroutine(delay());
        Application.Quit();
    }

    public void canvasOnOff(GameObject canvas)
    {
        if (isActive)
        {
            canvas.SetActive(false);
            isActive = false;
        }
        else
        {
            canvas.SetActive(true);
            isActive = true;
        }
    }

    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
