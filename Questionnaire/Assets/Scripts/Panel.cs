using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel : MonoBehaviour
{
    public GameObject ButtonShow;
    public GameObject ButtonHide;

    void Start()
    {
        ButtonShow.SetActive(false);
        ButtonHide.SetActive(true);
    }

    public void ShowButton()
    {
        ButtonShow.SetActive(false);
        ButtonHide.SetActive(true);
    }

    public void HideButton()
    {
        ButtonShow.SetActive(true);
        ButtonHide.SetActive(false);
    }
}
