using UnityEngine;

public class BamsongiCintroller : MonoBehaviour
{
    private void Start()
    {
        Application.targetFrameRate = 60;
        //Shoot(new Vector3(0, 200, 2000));
    }

    private void OnCollisionEnter(Collision collision)
    {
        GetComponent<Rigidbody>().isKinematic = true;
        GetComponent<ParticleSystem>().Play(); 
    }

    public void Shoot(Vector3 dir)
    {
        GetComponent<Rigidbody>().AddForce(dir);
    }
}
