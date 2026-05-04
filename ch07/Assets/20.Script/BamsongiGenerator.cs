using UnityEngine;

public class BamsongiGenerator : MonoBehaviour
{
    public GameObject bamsongiPrefab;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject bamsoni = Instantiate(bamsongiPrefab);
            bamsoni.transform.position = transform.position;
            Vector3 dir = new Vector3(0, 200, 1000);
            bamsoni.GetComponent<BamsongiCintroller>().Shoot(dir);
        }
    }
}
