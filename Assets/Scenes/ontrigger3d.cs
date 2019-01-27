using Fungus;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ontrigger3d : MonoBehaviour
{
    public Flowchart flow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        //Flowchart.BroadcastFungusMessage("BossEncounter");
        if(collision.tag == "Player")
            flow.ExecuteBlock("Trigger");
    }
}
