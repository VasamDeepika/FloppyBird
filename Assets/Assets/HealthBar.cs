using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthBar : MonoBehaviour
{
    Transform bar;
    // Start is called before the first frame update
    void Start()
    {
        bar = transform.Find("bar");
    }
    void Setsize(int size)
    {
        bar.localScale = new Vector3(size, 2f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
