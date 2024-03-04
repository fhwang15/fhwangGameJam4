using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LittleThings : MonoBehaviour
{

    public Transform moveHandle;
    public Vector3 originalPosition;

    // Start is called before the first frame update
    void Start()
    {
        originalPosition = moveHandle.position;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
