using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

namespace LightGame.Lights
{
    public class Lamp : MonoBehaviour
    {
        private bool lampOn = false;
        private Animator anim;
        public LampManager lampManager;
        public bool LampOn
        {
            get
            {
                return this.lampOn;
            }
            set
            {
                this.lampOn = value;
            }
        }
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
                    
                }
                if (lampOn)
                    {
                    lampManager.TurnLampsOff(this);

                }


            }
            anim.SetBool("Lamp", lampOn);
        }

    }
}
