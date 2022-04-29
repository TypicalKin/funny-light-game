using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;


public class Lamp : MonoBehaviour
{
    private bool lampOn = true;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);
            if (hit.collider != null && hit.collider.gameObject == this.gameObject)
            {
                Debug.Log("Hit " + gameObject.name);
                lampOn = !lampOn;
                anim.SetBool("Lamp", lampOn);
            }

        
        }
    }
 
}
