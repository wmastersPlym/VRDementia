using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LillyBob : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] float RotationSpeed = 25;
    [SerializeField] Vector3 RotationMax = new Vector3(10f, 0f, 10f);
    [SerializeField] Vector3 RotationMin = new Vector3(-10f, 0f, -10f);
    Vector3 current;
    Vector3 BobMax;
    Vector3 BobMin;

    private void Start()
    {
        RotationMax += transform.rotation.eulerAngles;
        RotationMin += transform.rotation.eulerAngles;
        
        current = this.transform.rotation.eulerAngles;
    }

    // Update is called once per frame
    private void FixedUpdate()
    {

        this.transform.Rotate(new Vector3(0f, 0f, RotationSpeed) * Time.deltaTime);
    }

    
}
