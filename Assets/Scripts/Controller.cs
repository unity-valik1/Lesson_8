using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    public SpriteRenderer spriteRenderer;
    public bool isDirectionRun;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isDirectionRun)
            {
                spriteRenderer.flipX = false;
                isDirectionRun = false;
            }
            else if (!isDirectionRun)
            {
                spriteRenderer.flipX = true;
                isDirectionRun = true;
            }
        }
    }
}
