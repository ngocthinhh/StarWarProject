using UnityEngine;

public class BulletController : MonoBehaviour
{
    private void Update()
    {
        Move();

        DeactiveWhenOutMap();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10f);
    }

    private void DeactiveWhenOutMap()
    {
        if (transform.position.x < -23 || transform.position.x > 23)
        {
            gameObject.SetActive(false);
        }

        if (transform.position.y < -23 || transform.position.y > 23)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Player") && !collision.CompareTag("HealthSafe")
            && !collision.CompareTag("BulletPlayer") && !collision.CompareTag("BulletOrange") && !collision.CompareTag("BulletGreen")
            && !collision.CompareTag("BulletWhite") && !collision.CompareTag("BulletPurple") && !collision.CompareTag("BulletGolden"))
        {
            gameObject.SetActive(false);
        }
    }
}
