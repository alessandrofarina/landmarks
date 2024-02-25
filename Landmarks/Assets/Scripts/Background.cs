using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background : MonoBehaviour
{
    public const string backgroundObjectName = "Background";
    public static Image image;

    void Awake()
    {
        GameObject gameObject = GameObject.Find(backgroundObjectName);
        image = gameObject.GetComponent<Image>();
    }

    public static void set(string path)
    {
        Sprite sprite = Resources.Load<Sprite>(path);
        if (sprite != null)
        {
            image.sprite = sprite;
        }
        else
        {
            Debug.LogError("Sprite not found at path: " + path);
        }
    }

}
