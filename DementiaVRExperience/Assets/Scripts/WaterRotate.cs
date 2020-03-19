using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterRotate : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float RotationSpeed = 25;

    // Update is called once per frame
    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0f,0f,RotationSpeed) * Time.deltaTime);
    }
}
