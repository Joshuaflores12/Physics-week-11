using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EditorAttributes;

public class Force : MonoBehaviour
{
    [SerializeField]public float force;
    [SerializeField]public Rigidbody rb;
    [SerializeField]public float mass;
    // Start is called before the first frame update
    void Start()
    {
        
        mass = rb.mass;
    }

    [Button("Force")]
    public void Forces()
    {
        force = 1500f;
        float v = force * Time.deltaTime / mass;
        rb.velocity += new Vector3(v, v, v);
    }

    [Button("Impulse")]

    public void Impulse()
    {
        force = 5f;
        float v = force / mass;
        rb.velocity += new Vector3(v, v, v);
    }

    [Button("Acceleration")]

    public void Acceleration() 
    {
        force = 600f;
        float v = force * Time.deltaTime;
        rb.velocity += new Vector3(v, v, v);
    }

    [Button("VelocityChange")]

    public void VelocityChange() 
    {
        force = 10f;
        float v = force;
        rb.velocity += new Vector3(v, v, v);
    }
}
