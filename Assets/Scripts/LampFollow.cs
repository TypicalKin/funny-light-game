using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LampFollow : MonoBehaviour
{
    [SerializeField] private GameObject Player;
    [SerializeField] private float speed = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        //transform.position = new Vector2(Lamp1);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
    }
}
