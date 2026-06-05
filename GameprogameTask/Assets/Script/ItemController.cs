using UnityEngine;

public class ItemController : MonoBehaviour
{

    private void Update()
    {
        transform.Translate(Vector3.down * 0.05f);
        if(transform.position.y<-1)
        {
            Destroy(gameObject);
        }
    }
}
