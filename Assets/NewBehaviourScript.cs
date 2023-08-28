using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Windows.Input;

public class NewBehaviourScript : MonoBehaviour
{
    private Animator anim;
    public Transform player;
    // Start is called before the first frame update
    void Start()
    {
        anim = player.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Controlls();
    }

    void Controlls()
    {
        if (Input.GetKey("up"))
        {
            transform.Translate(Vector2.up * 2.5f * Time.deltaTime);
        }

        if (Input.GetKey("down"))
        {
            transform.Translate(Vector2.down * 2.5f * Time.deltaTime);
        }
        if (Input.GetKey("left"))
        {
            transform.Translate(Vector2.left * 2.5f * Time.deltaTime);
        }
        if (Input.GetKey("right"))
        {
            transform.Translate(Vector2.right * 2.5f * Time.deltaTime);
        }
    }
}
