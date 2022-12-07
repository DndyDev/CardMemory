using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public const int gridRows = 2;
    public const int gridColumns = 4;
    public const float offsetX = 2f;
    public const float offsetY = 2.5f;

    [SerializeField] private MemoryCard originalCard;
    [SerializeField] private Sprite[] images;


    private void Start()
    {
        Vector3 startPostion = originalCard.transform.position;

        for (int i = 0; i < gridColumns; i++)
        {
            for (int j = 0; j < gridRows; j++)
            {
                MemoryCard card;
                if (i == 0 && j == 0)
                {
                    card = originalCard;
                }
                else
                {
                    card = Instantiate(originalCard) as MemoryCard;
                }
                int id = Random.Range(0, images.Length);
                originalCard.setCard(id, images[id]);

                float positionX = (offsetX * i) + startPostion.x;
                float positionY = -(offsetY * j) + startPostion.y;
                originalCard.transform.position = new Vector3(positionX, positionY, startPostion.z);
            }

        }
    }
}
