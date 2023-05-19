using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scanes : MonoBehaviour
{
    public void NextScene(int scene_Number)
    {
        SceneManager.LoadScene(scene_Number);
    }
}
