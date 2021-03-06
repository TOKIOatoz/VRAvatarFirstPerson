using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControllerFirstPersonByTOKI : MonoBehaviour
{
    [SerializeField]
    Vector3 firstPersonOffset = Vector3.zero;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Transform myTransform = this.transform;

        Vector3 localPos = myTransform.localPosition;
        localPos.x = firstPersonOffset.x * (-1);
        localPos.y = firstPersonOffset.y * (-1);
        localPos.z = firstPersonOffset.z * (-1);
        myTransform.localPosition = localPos;
    }
}
