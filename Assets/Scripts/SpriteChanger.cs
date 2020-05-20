using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Color color;
    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.color = color;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    ///<summary>
    ///Change the color of the sprite to the color input
    ///</summary>
    public void SampleMethod()
    {
        //spriteRenderer.color = newColor;
    }
}
