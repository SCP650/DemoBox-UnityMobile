using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slider : MonoBehaviour
{

    private bool IsSelected;
    private float ScreenWidth;
    private float ScreenHeight;
    private float SelfSize;
    // Start is called before the first frame update
    void Start()
    {
        IsSelected = false;
        ScreenHeight = 2f * Camera.main.orthographicSize;
        ScreenWidth = ScreenHeight * Camera.main.aspect;
        SelfSize = transform.localScale.x;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButton(0))
        {
            Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            IsSelected = true;
            float x = Mathf.Clamp(mouse.x, -ScreenWidth/2 + SelfSize, ScreenWidth/2 - SelfSize);
            transform.position = new Vector3(x ,transform.position.y,0);
            
        }
 

    }

}
