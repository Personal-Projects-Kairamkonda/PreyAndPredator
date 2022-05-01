using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour
{
    public Transform target;
    public float radius;

    private Collider[] hitColliders;

    // Start is called before the first frame update
    void Start()
    {
        SphereCollider triggerCollider = gameObject.AddComponent<SphereCollider>();
        triggerCollider.radius = this.GetComponent<Radius>().triggerRadius;
    }

    /*
    // Update is called once per frame
    void FixedUpdate()
    {
        hitColliders = Physics.OverlapSphere(this.transform.position, radius);

        foreach (var hitcollider in hitColliders)
        {
            Debug.Log(hitcollider.gameObject.name);
        }

    }


    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(this.transform.position,radius);
    }
    */
}
