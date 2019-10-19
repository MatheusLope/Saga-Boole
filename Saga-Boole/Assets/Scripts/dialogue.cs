using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class dialogue : MonoBehaviour
{

    public TextAsset dialog;
    public Text txt;
    private Animator anim;
    public float cooldown;

    private int selected;
    private string str;
 
    void Start()
    {
       anim = GetComponent<Animator>();
        showDialog();
    }
    public void showDialog()
    {
        anim.SetTrigger("open");
        selected = 0;
        str = dialog.text.Split('\n')[selected];
        loadLetters();
    }

    public void nextDialog()
    {
        if (selected + 1 < dialog.text.Split('\n').Length)
        {
            selected++;
            str = dialog.text.Split('\n')[selected];
            loadLetters();
        }
        else
        {
            endDialog();
        }
    }
    public void endDialog()
    {
        anim.SetTrigger("close");
        str = "";
        txt.text = "";
    }
    public void loadLetters()
    {
        txt.text = "";
        char[] chars = str.ToCharArray();
        for(int i = 0; i < chars.Length; i++)
        {
            StartCoroutine(getLetter(chars[i],i));
        }
    }
    IEnumerator getLetter(char l, int x)
    {
        yield return new WaitForSeconds(cooldown * x);
        txt.text += l.ToString();
    }
}
