using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGLoop : MonoBehaviour
{
    public float speed = 0.1F;
    private Vector2 offset = Vector2.zero;
    private Material material;
    void Start()
    {
        material = GetComponent<Renderer>().material;
        offset = material.GetTextureOffset("_MainTex");
    }

   
    void Update()
    {
        offset.x += speed * Time.deltaTime;
        material.SetTextureOffset("_MainTex", offset);
    }
}
