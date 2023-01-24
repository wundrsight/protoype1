using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ObjectCLick : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI scoreText;
    private Camera camera;
    public int score;
    public static ObjectCLick instance;

    void Start()
    {
        instance = this;
        camera = gameObject.GetComponent<Camera>();
        
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        { 
            Ray ray = camera.ScreenPointToRay(Input.mousePosition);
            RaycastHit rayhit;
            if (Physics.Raycast(ray, out rayhit)&&rayhit.collider.gameObject.tag=="Baloon")
            {
                rayhit.collider.gameObject.SetActive(false);
                ScoreHandler();
                scoreText.text = "Score: " + score;

            }
        }
    }
    public void ScoreHandler()
    {
        BaloonBurst.instance.baloonActive--;
        score++;
        scoreText.text = "Score: " + score;
    }

}
