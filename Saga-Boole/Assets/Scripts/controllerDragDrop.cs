using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
//using UnityEngine.UI;

public class controllerDragDrop : MonoBehaviour, IHasChanged
{

    [SerializeField] Transform slots;
    string answer;
    [SerializeField] string currentAnswer;

    [SerializeField] GameObject correct;
    [SerializeField] GameObject worng;

    void Start()
    {
        HasChanged();
    }

    public void HasChanged()
    {

        System.Text.StringBuilder builder = new System.Text.StringBuilder();
        builder.Append(" - ");

        foreach (Transform slotTransform in slots)
        {
            GameObject item = slotTransform.GetComponent<Slot>().item;
            if (item)
            {
                builder.Append(item.name);
                builder.Append(" - ");
            }
        }
        answer = builder.ToString();
    }

    public void Validation()
    {
        if (string.Compare(answer, currentAnswer) == 0)
        {
            correct.SetActive(true);
        }
        else
        {
            worng.SetActive(true);
        }
    }

}


namespace UnityEngine.EventSystems
{
    public interface IHasChanged : IEventSystemHandler
    {
        void HasChanged();

    }
}
