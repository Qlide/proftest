using UnityEngine;
using UnityEngine.UI;

public class ScrollViewSystem : MonoBehaviour
{
    private ScrollRect scrollRect2;

    [SerializeField] private ScrollButton leftButton;
    [SerializeField] private ScrollButton rightButton;

    [SerializeField] private float scrollSpeed = 0.05f;

    // Start is called before the first frame update
    void Start()
    {
        scrollRect2 = GetComponent<ScrollRect>();
    }

    // Update is called once per frame
    void Update()
    {
        if (leftButton != null)
        {
            if (leftButton.isDown)
            {
                ScrollLeft();
            }
        }

        if (rightButton != null)
        {
            if (rightButton.isDown)
            {
                ScrollRight();
            }
        }
    }

    private void ScrollLeft()
    {
        if (scrollRect2 != null)
        {
            if (scrollRect2.horizontalNormalizedPosition >= 0f)
            {
                scrollRect2.horizontalNormalizedPosition -= scrollSpeed;
            }
        }
    }

    private void ScrollRight()
    {
        if (scrollRect2 != null)
        {
            if (scrollRect2.horizontalNormalizedPosition <= 1f)
            {
                scrollRect2.horizontalNormalizedPosition += scrollSpeed;
            }
        }
    }
}
