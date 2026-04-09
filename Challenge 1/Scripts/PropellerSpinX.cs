using UnityEngine;

public class PropellerSpinX : MonoBehaviour
{
    public float spinSpeed = 1000.0f;

    void Update()
    {
        transform.Rotate(Vector3.forward, spinSpeed * Time.deltaTime);
    }
}