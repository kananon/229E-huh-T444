using UnityEngine;

public class Wind : MonoBehaviour
{
    public float force = 20f;

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            other.GetComponent<Rigidbody>().AddForce(Vector3.up * force);
        }
    }
}