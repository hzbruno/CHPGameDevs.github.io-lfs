using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour

{
    public int speed = -15;
    public Transform down;
    public Transform up;
    public GameObject Skipper;
    private  bool SkipBool =false;
    private float time;
    // Start is called before the first frame update
    void Start()
{

}

// Update is called once per frame
    void Update()
    {
        if (SkipBool == true && time < 2) time += Time.deltaTime;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Skipper.SetActive(true);
            SkipBool = true; 
            if (Input.GetKeyDown(KeyCode.Space)&& SkipBool==true && time >1.5f)
            {
                SceneManager.LoadScene("ViarWink");
            }
        }


        transform.Translate(0, speed * Time.deltaTime, 0);

    if (gameObject.transform.position.y > up.transform.position.y)
    {
            SceneManager.LoadScene("ViarWink");

    }
}
}