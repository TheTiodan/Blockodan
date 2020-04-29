using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    public GameObject panel;
    public void OpenCredits()
    {
        if (panel != null)
        {
            panel.SetActive(true);
        }
    }
    public void CloseCredits()
    {
        if (panel != null)
        {
            panel.SetActive(false);
        }
    }

}
