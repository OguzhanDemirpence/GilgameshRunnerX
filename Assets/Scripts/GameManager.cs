using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private GameObject fruit;
    [SerializeField] private Camera camera;
    [SerializeField] private Vector3 offset;
    private GameObject kralGýlgamesh;

    private List<GameObject> fruitList = new List<GameObject>();
    private GameObject temp;
    void Start()
    {
        kralGýlgamesh = Instantiate(player, player.transform.position, Quaternion.identity);
        FruitDuplication();
    }

    // Update is called once per frame
    void Update()
    {
        CameraPos();
    }

    private void FruitDuplication()
    {
        for (int i = 0; i < 10; i++)
        {
            Vector3 fruitPos = new Vector3(Random.Range(-5, 5), .5f, i * 18 - 90);
            temp = Instantiate(fruit, fruitPos, Quaternion.identity);
            //fruitList.Add(temp);
        }
    }
    private void CameraPos()
    {
        camera.transform.position = kralGýlgamesh.transform.position + offset;
    }
}
