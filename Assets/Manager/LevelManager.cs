using Unity.VisualScripting;
using UnityEngine;

public class LevelManager : MonoBehaviour
{




    public GameObject level01;
    public GameObject level02;
    public GameObject level03;
    public GameObject level04;
    //public Gizmo_TriggerSceneChange level2ChangeTriggerN;
    //public Gizmo_TriggerSceneChange level2ChangeTriggerE;
    //public Gizmo_TriggerSceneChange level2ChangeTriggerW;

    public GameObject level2ChangeTriggerN;
    public GameObject level2ChangeTriggerE;
    public GameObject level2ChangeTriggerW;
    private GameObject player; 
    private GameObject currentActiveLevel;
    public Transform spawnLocation;
    public GameObject levelToLoad;
    public void Start()
    {
        currentActiveLevel = level01; 
        player = ServiceHub.Instance.playerController.gameObject;
    }

    public void levelChange(GameObject levelToLoad, Transform spawnLocation)
    {
        currentActiveLevel.SetActive(false);
        levelToLoad.SetActive(true);
        currentActiveLevel = levelToLoad;

        player.transform.position = spawnLocation.position;
    }


    //public void levelChange()
    //{

    //    if (level01)
    //    {
    //        level01.SetActive(false);
    //        level02.SetActive(true);
    //      //  PlayerController transform.position = spawnLocation.position;
    //    }
    //    if (level02)
    //    {
    //        if (level2ChangeTriggerN)
    //        {
    //            level02.SetActive(false);
    //            level01.SetActive(true);
    //        }
    //        if (level2ChangeTriggerW)
    //        {  
    //            level02.SetActive(false);
    //        level03.SetActive(true);
    //        }
    //        if (level2ChangeTriggerE)
    //        {
    //            level02.SetActive(false);
    //            level04.SetActive(true);
    //        }
    //    }

    //if(level03)
    //   {
    //       level03.SetActive(false);
    //       level02.SetActive(true);

    //   }
    //if (level04)
    //   {
    //       level04.SetActive(false);
    //       level02.SetActive(true);

    //   }







}
    