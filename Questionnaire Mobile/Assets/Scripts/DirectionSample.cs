using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DirectionSample : MonoBehaviour
{
    public DirectionSampleList[] directions;
    public Text dirText;
    public Text desText;

    List<object> dirList;
    List<int> res;
    List<int> resMax;
    static int max = 0;
    static int index;

    void Start()
    {
        List<int> res = new List<int>() { Task.n1, Task.n2, Task.n3, Task.n4, Task.n5, Task.n6 };
        List<int> resMax = new List<int>() { Task.n1, Task.n2, Task.n3, Task.n4, Task.n5, Task.n6 };
        index = 0;
        resMax.Sort();
        max = resMax[resMax.Count - 1];
        dirList = new List<object>(directions);
        for (int i = 0; i < res.Count; i++)
        {
            if (res[i] == max)
            {
                index = i;
                break;
            }
        }

        DirectionSampleList crntD = dirList[index] as DirectionSampleList;
        dirText.text = crntD.direction;
        desText.text = crntD.description;
    }
}

[System.Serializable]
public class DirectionSampleList
{
    public string direction;
    public string description;
}

