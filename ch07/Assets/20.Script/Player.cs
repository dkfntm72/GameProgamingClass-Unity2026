using UnityEngine;

public class Player : MonoBehaviour
{
    public float MoveSpeed = 1.0f;

    Rigidbody rb;
    Animator anim;

    Vector3 moveDirection;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        float xInput = Input.GetAxisRaw("Horizontal");
        float zInput = Input.GetAxisRaw("Vertical");

        moveDirection = new Vector3(xInput, 0, zInput);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            anim.SetTrigger("Throw");
        }

        if (moveDirection.magnitude > 0.1f)
        {
            moveDirection.Normalize();
            anim.SetBool("isWalking",true);
            
            transform.forward = moveDirection;
            rb.MovePosition(rb.position + moveDirection * MoveSpeed * Time.deltaTime);


        }
        else
        {
            anim.SetBool("isWalking", false);
        }
    }
}
