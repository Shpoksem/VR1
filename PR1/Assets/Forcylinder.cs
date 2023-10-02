using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forcylinder : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Hide()
    {
        transform.localScale = Vector3.zero;
    }
    public void Show() {
        transform.localScale = Vector3.one;
    }
}

