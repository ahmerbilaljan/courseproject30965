using UnityEngine;

public class ExplosionEffect : MonoBehaviour
{
    void Start()
    {
        // Destroy the GameObject after the animation finishes
        Destroy(gameObject, GetComponent<Animator>().GetCurrentAnimatorStateInfo(0).length);
    }
}
