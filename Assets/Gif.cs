using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gif : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite[] frames;
    public int fps = 10;

    private Vector2 pivot;
    private Rect rect;
    private Rect textureRect;

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        int index = (int)(Time.time * fps) % frames.Length;
        spriteRenderer.sprite = frames[index];
        
    }
}
