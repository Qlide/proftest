using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TouchControl : MonoBehaviour
{
    private Vector2 fp; 
    private Vector2 lp;

    public void FixedUpdate()
    {
        foreach (Touch touch in Input.touches)
        {
            if (touch.phase == TouchPhase.Began)
            {
                fp = touch.position;
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Moved)
            {
                lp = touch.position;
            }
            if (touch.phase == TouchPhase.Ended)
            {
                if ((fp.x - lp.x) > 80) // лево
                {
                    SceneManager.LoadScene(7);
                }
                else if ((fp.x - lp.x) < -80) // право
                {
                    SceneManager.LoadScene(6);
                }
            }
        }
    }

    void Start()
    {
        FixedUpdate();
    }
}