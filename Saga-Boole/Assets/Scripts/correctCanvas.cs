using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class correctCanvas : MonoBehaviour
{
    Scene scene;
    private void Awake()
    {
        scene = SceneManager.GetActiveScene();
    }
    public void Next(string cena)
    {
        StartCoroutine(delay());
        SceneManager.LoadScene(cena);
    }

    public void Reload()
    {
        StartCoroutine(delay());
        SceneManager.LoadScene(scene.name);
    }

    public void Close()
    {
        this.gameObject.SetActive(false);
    }
    IEnumerator delay()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
