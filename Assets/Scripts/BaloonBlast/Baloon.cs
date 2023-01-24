using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Baloon : MonoBehaviour
{
    float speed;



    private void Start()
    {
        speed = Random.Range(0.5f, 1.5f);


    }
    private void Update()
    {
        transform.Translate(0, speed * Time.deltaTime, 0);

    }

    private void OnTriggerEnter(Collider collision)
    {
        Debug.Log("Collision :" + collision.gameObject.tag);
        if (collision.gameObject.tag == "Destroyer")
        {

            gameObject.SetActive(false);


        }
        else if (collision.gameObject.tag == "Weapon")
        {
            ObjectCLick.instance.ScoreHandler();
            gameObject.SetActive(false);

        }


    }

}
