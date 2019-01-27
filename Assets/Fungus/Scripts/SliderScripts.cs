using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderScripts : MonoBehaviour
{
    Slider cuteSlider;
    SpriteRenderer disapprovalImg;
    public int max;
    public List<Sprite> sprites;
    // Start is called before the first frame update
    void Start()
    {
        cuteSlider = GameObject.Find("CuteSlider").GetComponent<Slider>();
        disapprovalImg = GameObject.Find("DisapprovalSlider").GetComponent<SpriteRenderer>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetCute(int val)
    {
        cuteSlider.value = val;
    }

    public void setmax(int maxval)
    {
        max = maxval;
    }


    public void SetDisapproval(int val)
    {
        Debug.Log(val.ToString());
        float amt = (float)val / (float)max;
        if (amt < 0f)
        {
            Debug.Log(amt);
            disapprovalImg.sprite = sprites[0];
        }
        else if(amt < .25f)
        {
            Debug.Log(amt);
            disapprovalImg.sprite = sprites[1];
        }
        else if(amt < .50f)
        {
            Debug.Log(amt);
            disapprovalImg.sprite = sprites[2];
        }
        else
        {
            Debug.Log(amt);
            disapprovalImg.sprite = sprites[3];
        }
    }
}
