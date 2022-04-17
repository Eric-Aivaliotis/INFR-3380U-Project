using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button_glow : MonoBehaviour
{
    MeshRenderer glowing;

    // Start is called before the first frame update
    void Start()
    {
        glowing = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {glowing.material.EnableKeyword("_EMISSION"); }


    }
}
