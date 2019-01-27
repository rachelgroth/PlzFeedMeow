using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        int l = 0; //loop
        while (l == 0)
        {
            l = 1;
            if (collision.tag == "Player")
            {
                GetComponent<Animator>().Play("dooropen");
                
            }

        }

    }
}