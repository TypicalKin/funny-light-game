using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEngine;

public class Elevator : MonoBehaviour
{
    private bool isDragging = false;
    private Vector2 startDragPos;

    void Update()
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            if (Input.GetMouseButtonDown(0))
            {
               
                RaycastHit2D hit = Physics2D.Raycast(mousePos, Vector2.zero);
                if (hit.collider != null && hit.collider.gameObject == this.gameObject)
                {
                    if (isDragging == false)
                    {
                        startDragPos = transform.position - mousePos;
                    }
                    //start drag{
                    
                    isDragging = true;
                    
                }


            }

            if (isDragging)
            {
                Debug.Log("Drag " + gameObject.name);
            Vector3 elevatorPos = new Vector3(transform.position.x, mousePos.y + startDragPos.y, 0);
            if (Camera.main.WorldToViewportPoint(elevatorPos).y < 0.9 && Camera.main.WorldToViewportPoint(elevatorPos).y > 0.25)

            {
                transform.position = new Vector2(transform.position.x, mousePos.y + startDragPos.y);
            }
            }
            if (Input.GetMouseButtonUp(0))
            {
                //end drag
                isDragging = false;

        }
        }

    }