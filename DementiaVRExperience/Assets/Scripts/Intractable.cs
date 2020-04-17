using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


[System.Serializable]
public class OnInteractEvent : UnityEvent { };
public class Intractable : MonoBehaviour
{

    public OnInteractEvent OnInteract;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Interact() {
        OnInteract.Invoke();
    }

    public void TestInteract() {
        print("Test intereact from " + transform.name);
    }
}
