using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;

public class HitTrigger : MonoBehaviour
{
    public UnityEvent onTrigger;
    public bool destroyThing = false;

    private void OnTriggerEnter(Collider other)
    {
        if(destroyThing)
        {
            Destroy(other.gameObject);
        }
        // Run the event!
        onTrigger.Invoke();
    }
}
