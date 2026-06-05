using UnityEngine;
using TMPro;
public class BasketController : MonoBehaviour
{
    private ParticleSystem myPar;
    public TextMeshProUGUI neutralizationText;
    private bool neutralization;
    private float Timer = 0;
    private void Start()
    {
        Application.targetFrameRate = 60;
        neutralization = false;
        myPar = GetComponent<ParticleSystem>();
    }
    private void Update()
    {

        if (neutralization && Time.timeScale == 1) 
        {
            Timer += Time.deltaTime;
            neutralizationText.gameObject.SetActive(true);
            if(Timer>2.0f)
            {
                neutralizationText.gameObject.SetActive(false);
                neutralization = false;
                Timer = 0;
            }
        }
        if (Input.GetMouseButtonDown(0) && !neutralization && Time.timeScale == 1) 
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity))
            {
                float x = Mathf.RoundToInt(hit.point.x);
                float z = Mathf.RoundToInt(hit.point.z);
                transform.position = new Vector3(x, 0, z);
            }
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag=="apple")
        {
            Destroy(other.gameObject);
            Gamemanager.score += 100;
        }
        if (other.gameObject.tag == "bomb")
        {
            Destroy(other.gameObject);
            Gamemanager.score -= 300;
        }
        if (other.gameObject.tag == "bamsong")
        {
            Destroy(other.gameObject);
            myPar.Play();
            neutralization = true;
        }
    }
}
