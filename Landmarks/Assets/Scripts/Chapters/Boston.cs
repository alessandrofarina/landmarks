using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boston : MonoBehaviour
{
    private const string CHAPTER = "Boston";
    private const string PATH_TO_BACKGROUNDS = "Backgrounds/" + CHAPTER + "/";

    void Start()
    {
        Background.set(PATH_TO_BACKGROUNDS + "harbor");
    }


}
