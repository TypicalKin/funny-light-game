using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace LightGame.Lights
{
    public class LampManager : MonoBehaviour
    {
        [SerializeField]
        public List<Lamp> LampList;

    // Start is called before the first frame update
    void Start()
        {
            foreach (Lamp lamp in LampList)
            {
                lamp.lampManager = this;
            }
        }

        // Update is called once per frame
        void Update()
        {

        }
        public void TurnLampsOff(Lamp ClickedLamp)
        {
            foreach (Lamp lamp in LampList)
            {
                if(lamp != ClickedLamp)
                {
                    lamp.LampOn = false;
                }
            }
        }
    }
}
