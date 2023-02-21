using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class GantiScene : MonoBehaviour
{
    // Start is called before the first frame update

    
        public void changeMyScene(string namaScene)
        {
            SceneManager.LoadScene(namaScene);
        }
    

    // Update is called once per frame

}
