using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catwalk : MonoBehaviour
{
    Animator an;
    // Start is called before the first frame update
    void Start()
    {
        an = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 moveDirection = gameObject.GetComponent<Rigidbody2D>().velocity;
        if (Mathf.Abs(Input.GetAxis("Horizontal")) != 0)
        {
            if(!an.GetCurrentAnimatorStateInfo(0).IsName("catwalk"))
                an.Play("catwalk");
            float angle = Mathf.Atan2(moveDirection.y, moveDirection.x) * Mathf.Rad2Deg;
            transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        }
    }
}
