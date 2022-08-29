using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    private Vector2 mousePos;
    private Camera camera;

    private void Start()
    {
        camera = GameObject.Find("Main Camera").GetComponent<Camera>();
    }

    private void Update()
    {
        mousePos = camera.ScreenToWorldPoint(Input.mousePosition); 

        transform.position = mousePos;
    }
}
