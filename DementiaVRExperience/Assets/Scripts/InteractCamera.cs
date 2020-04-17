using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class InteractCamera : MonoBehaviour
{

    

    public Camera cam;

    public float timeToInteract = 2f;

    private GameObject interactObject;
    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        // set camera 
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {

        // Raycasting straight from center of camera
        RaycastHit hit;
        Ray ray = cam.ViewportPointToRay( new Vector3(0.5f, 0.5f, 0f) );
        if (Physics.Raycast(ray, out hit)) {


            if(hit.transform.GetComponent<Intractable>() != null) { // looking at something interactable

                if(interactObject != hit.transform.gameObject) { // Wasn't already looking at the object
                    timer = Time.time;
                    interactObject = hit.transform.gameObject;
                } else {
                    if(Time.time - timer > timeToInteract) { // been looking at the obeject for required time
                        hit.transform.GetComponent<Intractable>().Interact();
                    }
                }



                //hit.transform.GetComponent<Intractable>().Interact();
                //print("Object " + hit.transform.name + " is intractable");

                


            } else { // looking at something not interactable
                interactObject = null;

                print("Object " + hit.transform.name + " isn't intractable");
            }
        } else {
            interactObject = null;
            print("Looking at nothing");
        }
    }
}
