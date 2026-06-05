using UnityEngine;

public class ItemGenerater : MonoBehaviour
{
    public GameObject apple;
    public GameObject bomb;
    public GameObject bamsong;

    private float createTime = 0;



    private void Update()
    {
        createTime += Time.deltaTime;

        if (createTime >= 0.5f)
        {
            Vector3 pos = new Vector3(Random.RandomRange(-2, 3), 3, Random.RandomRange(-2, 3));
            switch (Random.RandomRange(0, 6))
            {
                case 0:
                    Instantiate(bamsong, pos, Quaternion.identity);
                    break;
                case 1:
                    Instantiate(bomb, pos, Quaternion.identity);
                    break;
                default:
                    Instantiate(apple, pos, Quaternion.identity);
                    break;
            }
            createTime = 0;
        }

    }

}
