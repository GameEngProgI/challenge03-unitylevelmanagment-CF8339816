using UnityEngine;

public class levelTriggerScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject levelToLoad;
    public Transform spawnLocation;
  public LevelManager levelManager;  

    void Start()
    {
        //levelManager = FindAnyObjectByType<LevelManager>();   



        levelManager = ServiceHub.Instance.levelManager;




    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Trigger Log");
            //levelChange();


          //  levelManager.levelChange();

            levelManager.levelChange(levelToLoad, spawnLocation);


        }



    }

   











    //// Update is called once per frame
    //void Update()
    //{
        
    //}
}
