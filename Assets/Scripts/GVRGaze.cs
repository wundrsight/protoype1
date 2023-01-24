
using System.Collections;
using UnityEngine;


public class GVRGaze : MonoBehaviour
{
    private const float _maxDistance = 500;
    private GameObject _gazedAtObject = null;
    [SerializeField] GameObject _player;
    [SerializeField] float _timer;
    [SerializeField] Vector3 _telePos;


    public void Update()
    {
       
     
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, _maxDistance))
        {
            _timer += Time.deltaTime;
          

            if (_timer >= 2)
            {
              
                            
                _gazedAtObject = hit.transform.gameObject;

                TeleporPlayer();              
                _timer = 0;

            }
        }
        else
        {
          
           
            _gazedAtObject = null;

        }

     
    }
    private void TeleporPlayer()
    {
        if (_gazedAtObject.tag == "Teleportal")
        {
        Debug.Log("TELE OBJ :"+_gazedAtObject.name);
            _telePos.x = _gazedAtObject.transform.position.x;
            _telePos.y = _gazedAtObject.transform.position.y;
            _telePos.z = _gazedAtObject.transform.position.z;
            _player.transform.position = new Vector3(_telePos.x, _telePos.y + 2, _telePos.z);
        }
    }
}
