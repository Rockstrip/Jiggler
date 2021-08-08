using UnityEngine;

public class Coin : MonoBehaviour
{
    public void BePicked()
    {
        GetComponentInParent<AudioSource>().Play();
        Destroy(gameObject);
    }
}
