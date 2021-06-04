using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ButtonActivation : MonoBehaviour
{
    Button thisButton;
    public bool isActiveByTime;
    public float timeToActive;
    private void Start()
    {
        thisButton = GetComponent<Button>();
        thisButton.interactable = false;
    }
    private void Update()
    {
        if (isActiveByTime)
        {
            timeToActive -= Time.deltaTime;
            if (timeToActive <= 0)
            {
                thisButton.interactable = true;
            }
        }
        else
        {
            if(GameManager.instance.vasosLLenos == 3)
            {
                thisButton.interactable = true;
            }
        }
    }
}
