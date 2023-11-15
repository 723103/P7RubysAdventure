using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Healthcollectable : MonoBehaviour
{
    // Start is called before the first frame update
    void OntriggerEnter2D(Collider2D other)
    {
        Rubycontroller controller = other.GetComponent<Rubycontroller>();
        if (controller != null)
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
}

       