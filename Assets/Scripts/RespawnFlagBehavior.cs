using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnFlagBehavior : MonoBehaviour
{
    private RespawnManager _rm;

    [SerializeField]
    private Sprite flaggedSprite;
    private void Start()
    {
        _rm = FindObjectOfType<RespawnManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<PlayerBehaviour>()) {
            _rm.respawnFlag = this;
            GetComponent<Collider2D>().enabled = false;
            SpriteRenderer sr = gameObject.AddComponent<SpriteRenderer>();
            sr.sortingOrder = 15;
            sr.sprite = flaggedSprite;
        }
    }
}
