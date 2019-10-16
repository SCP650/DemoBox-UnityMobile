using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Border : MonoBehaviour
{
    [Tooltip("Up, Down, Left or Right")]
    [SerializeField]
    string location;
     
    // Start is called before the first frame update
    void Start()
    {
        float ScreenHeight = 2*Camera.main.orthographicSize;
        float ScreenWidth = ScreenHeight * Camera.main.aspect;
        float width = 0.5f;

        float up = ScreenHeight/2 + width/2;
        float down = -ScreenHeight/2 - width/2;
        float left = -ScreenWidth/2 - width/2;
        float right = ScreenWidth/2 + width/2;

        float x = 0;
        float y = 0;
        float z = 0;


        //Change location and Scale cooresponding to camera size
        switch (location)
        {
            case "Up":
                transform.position = new Vector3(x, up, z);
                transform.localScale = new Vector3(ScreenWidth, width ,z);
                break;
            case "Left":
                transform.position = new Vector3(left, y, z);
                transform.localScale = new Vector3(width, ScreenHeight, z);
                break;
            case "Right":
                transform.position = new Vector3(right, y, z);
                transform.localScale = new Vector3(width, ScreenHeight, z);
                break;
            case "Down":
                transform.position = new Vector3(x, down, z);
                transform.localScale = new Vector3(ScreenWidth, width, z);
                break;
        }


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
