using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
    public class PlayerController : MonoBehaviour
{  

    [SerializeField] float moveSpeed;
    Vector2 moveInput;
    public Animator anim;
    public Animator canvasanim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponentInChildren<Animator>();  
    }

    // Update is called once per frame
    void Update()
    {
        
        moveInput.x = Input.GetAxis("Horizontal");
        moveInput.y = Input.GetAxis("Vertical");

        transform.Translate(moveInput * Time.deltaTime * moveSpeed);

        anim.SetBool("isMoving", (Mathf.Abs(moveInput.x) > 0 || Mathf.Abs(moveInput.y) > 0));
    }
    void OnTriggerEnter2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("porta"))
        {
         canvasanim.SetBool("Fade",true);
           
        }
    }
    void OnTriggerExit2D(Collider2D body)
    {
        if (body.gameObject.CompareTag("porta"))
        {
            canvasanim.SetBool("Fade",false ); 
            if (SceneManager.GetActiveScene().buildIndex == 3)
            SceneManager.LoadScene(4);
            else
            SceneManager.LoadScene(3);
           
        }
        if (body.gameObject.CompareTag("porta2"))
        {
            canvasanim.SetBool("Fade",false ); 
            if (SceneManager.GetActiveScene().buildIndex == 3)
            SceneManager.LoadScene(5);
            else
            SceneManager.LoadScene(3);
           
        }
    }
}
