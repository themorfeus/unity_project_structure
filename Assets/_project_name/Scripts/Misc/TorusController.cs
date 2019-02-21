using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//This controls the torus spinning
public class TorusController : MonoBehaviour
{

    [SerializeField] private float spinSpeed;

    private void Update()
    {
        transform.Rotate(spinSpeed * Time.deltaTime, 0, -spinSpeed * Time.deltaTime);
    }

    public float GetSpinSpeed()
    {
        return spinSpeed;
    }

    public void SetSpinSpeed(float spinSpeed)
    {
        this.spinSpeed = spinSpeed;
    }
}
