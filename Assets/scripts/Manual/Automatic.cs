using EditorAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Automatic : MonoBehaviour
{
    [SerializeField] public float force;
    [SerializeField] public Rigidbody rb;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    [Button("Force")]
    public void Force()
    {
        force = 1500f;
        rb.AddForce(Vector2.up * force, ForceMode.Force);
    }

    [Button("Impulse")]

    public void Impulse() 
    {
        force = 5f;
        rb.AddForce(Vector2.up * force, ForceMode.Impulse);
    }

    [Button("Acceleration")]

    public void Acceleration() 
    {
        force = 600f;
        rb.AddForce(Vector2.up * force, ForceMode.Acceleration);
    }

    [Button("VelocityChange")]

    public void VelocityChange() 
    {
        force = 10f;
        rb.AddForce(Vector2.up * force, ForceMode.VelocityChange);
    }

}
