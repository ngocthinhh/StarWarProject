using UnityEngine;

public class BlackHoleEnding : MonoBehaviour
{
    [SerializeField] private GameObject player;

    [SerializeField] private GameObject ending;

    private void Update()
    {
        if (player != null)
        {
            if (player.transform.localScale.x > 0f || player.transform.localScale.y > 0f)
            {
                player.transform.localScale = new Vector2(player.transform.localScale.x, player.transform.localScale.y) - new Vector2(3f, 3f) * Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player = collision.gameObject;

        player.GetComponent<PlayerController>().enabled = false;

        AudioManager.Instance.PlayEffect(AudioManager.Instance.blackHoleIn);

        AudioManager.Instance.Pause();

        ending.SetActive(true);
    }
}
