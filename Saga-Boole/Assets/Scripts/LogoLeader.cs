using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogoLeader : MonoBehaviour
{
    void Start()
    {
        StartCoroutine("CoolDown");
    }

    [System.Obsolete]
    private IEnumerator CoolDown()
    {
        yield return new WaitForSeconds(8);
        Application.LoadLevel(1);
    }

 
}
