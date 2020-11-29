using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageCreator : MonoBehaviour
{
    // Start is called before the first frame update
    void Awake()
    {
       
    }

    void Start()
    {
        // place items with random position feched through resources
        var jsonTextFile = Resources.Load<TextAsset>("iocl");
        // var obj = JsonUtility.FromJson<ImageCreator>(jsonTextFile);
        // Debug.Log("json data",obj);
        for(int i=1;i<=5;i++){
        SpriteCreator("hotspot"+i,i+5,i+6,i+7);
        }
    }

    public void SpriteCreator(string objectname,int xpos,int ypos,int zpos) {
        GameObject go = new GameObject(objectname);
        SpriteRenderer renderer = go.AddComponent<SpriteRenderer>();
        renderer.sprite = Resources.Load<Sprite>("next-button");
        go.transform.position = new Vector3(xpos,ypos,zpos);
    }

    // Update is called once per frame
    void Update()
    {
    }
}
