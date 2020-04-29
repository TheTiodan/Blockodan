using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Options : MonoBehaviour
{
    public GameObject Panel;
    public void ShowOptions()
    {
        if(Panel !=null)
        {
            Panel.SetActive(true);
        }
    }
    public void CloseOptions()
    {
        if (Panel != null)
        {
            Panel.SetActive(false);
        }
    }
}
