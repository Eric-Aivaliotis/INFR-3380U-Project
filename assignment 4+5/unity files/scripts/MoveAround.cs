using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAround : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(10 * Input.GetAxis("Vertical") * Time.deltaTime,0f, -10 * Input.GetAxis("Horizontal") * Time.deltaTime); 
    }
}
