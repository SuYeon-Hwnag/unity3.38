using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rhythm_cat_controller : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void LButtondown()
    {
        transform.Translate(-0.5f, 0, 0);
    }
    public void RButtondown()
    {
        transform.Translate(0.5f, 0, 0);
    }
}
