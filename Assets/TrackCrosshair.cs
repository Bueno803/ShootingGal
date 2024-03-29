using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrackCrosshair : MonoBehaviour
{
    GamePlayAudio m_AudioManager;
    public LayerMask targetLayer;

    public Score score;
    public void Awake()
    {
        m_AudioManager = GameObject.FindGameObjectWithTag("Audio").GetComponent<GamePlayAudio>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        mousePosition.z = 0;
        transform.position = mousePosition;

        if (Input.GetMouseButtonDown(0)) {
            m_AudioManager.PlaySFX(m_AudioManager.gunshot);
            Shoot();
        }
    }

    void Shoot() 
    {
        Vector2 direction = Vector2.down;
        Vector2 crosshairPosition = transform.position;
        RaycastHit2D hit = Physics2D.Raycast(crosshairPosition, direction, Mathf.Infinity, targetLayer);


        if (hit.collider != null) {
            if (hit.collider.CompareTag("Target")) {
                m_AudioManager.PlaySFX(m_AudioManager.hit);
                Destroy(hit.collider.gameObject);
                score.IncreaseScore(10);
            }
        }
        // Debug.Log("Hit" + hit.collider.gameObject); 
    }
}
