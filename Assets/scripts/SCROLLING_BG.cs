using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{
    public float scrollSpeed = 2f; // Speed of scrolling
    private Vector2 startPosition;
    private float backgroundHeight;

    void Start()
    {
        // Save the initial position and calculate background height
        startPosition = transform.position;
        backgroundHeight = GetComponent<SpriteRenderer>().bounds.size.y;
    }

    void Update()
    {
        // Move the background down
        float newPosition = Mathf.Repeat(Time.time * scrollSpeed, backgroundHeight);
        transform.position = startPosition + Vector2.down * newPosition;
    }
}
