using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;


public class BaloonBurst : MonoBehaviour
{
    [SerializeField] private Vector3[] spawnPos;
    [SerializeField] private GameObject baloon;
    [SerializeField] private int count=0;
    [SerializeField] private List<GameObject> Baloons;
    [SerializeField] private Material[] material;
    private bool baloonInstentiated;
    int randomVal;
    public int baloonActive = 0;

    public static BaloonBurst instance;
    private void Awake()
    {
        instance = this;
        baloonInstentiated = true;
        SpawnBaloon();
    }
    void Start()
    {
      
        StartCoroutine(BaloonSpawner());
    }
    private void Update()
    {
        Debug.Log("LoadedDevice :" + XRSettings.loadedDeviceName);
    }
    private void SpawnBaloon()
    {
       
    for (int i=0;i<count;i++)
        {
          var obj =  Instantiate(baloon);
            obj.SetActive(false);
            Baloons.Add(obj);
           
        }
    }


         GameObject GetPooledObject()
        {
            for (int i = 0; i < Baloons.Count; i++)
            {

                if (!Baloons[i].activeInHierarchy)
                {
                    return Baloons[i];
                }

            }
            return null;
        }

        IEnumerator BaloonSpawner()
        {

            while ( true)
            {

                GameObject _baloon = GetPooledObject();

                if (_baloon != null)
                {

                    _baloon.transform.position = spawnPos[Random.Range(0, 4)];
                    _baloon.GetComponent<Renderer>().material = material[Random.Range(0, 5)];
                    _baloon.SetActive(true);


                }

                yield return new WaitForSeconds(2f);

            }


        }



    }




