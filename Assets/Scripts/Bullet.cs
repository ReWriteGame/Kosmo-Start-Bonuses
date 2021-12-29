using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.GetComponent<Box>())
            gameObject.GetComponent<Destroyable>().Destroy();
    }
}
