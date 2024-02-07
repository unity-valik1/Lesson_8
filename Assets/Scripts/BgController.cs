using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BgController : MonoBehaviour
{
    public float speed;
    public Controller controller;
    private Vector3 startPos;
    void Awake()
    {
        controller = FindObjectOfType<Controller>();
        startPos = transform.position;
    }
    private void Update()
    {
        if(transform.position.x >= 26.5f || transform.position.x <= -26.5f)
        {
            transform.position = startPos; 
        }
        if(controller.isDirectionRun)
        {
            transform.Translate(transform.right * speed * Time.deltaTime);
        }
        else
        {
            transform.Translate(-transform.right * speed * Time.deltaTime);
        }
    }
}
