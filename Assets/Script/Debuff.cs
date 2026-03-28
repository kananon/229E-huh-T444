using UnityEngine;

public class ConfuseDebuff : MonoBehaviour
{
    public float duration = 5f;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            PlayerController pm = other.GetComponent<PlayerController>();
            if (pm != null)
            {
                StartCoroutine(ApplyDebuff(pm));
            }
        }
    }

    System.Collections.IEnumerator ApplyDebuff(PlayerController player)
    {
        player.isConfused = true;
        yield return new WaitForSeconds(duration);
        player.isConfused = false;
    }
}