using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var height = Camera.main.orthographicSize * 2.0F;
        var width = height * Screen.width / Screen.height;

        if (gameObject.name == "Backgound1")
        {
            transform.localScale = new Vector3(width, height, 0);
        }
        else
        {
            transform.localScale = new Vector3(width + 3f, 5, 0);
        }
    }

    
}
