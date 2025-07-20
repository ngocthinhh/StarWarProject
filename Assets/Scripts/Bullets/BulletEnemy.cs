using UnityEngine;

public class BulletEnemy : MonoBehaviour
{
    [SerializeField] private float strength;

    private void Update()
    {
        Move();

        DisableWhenOutMap();
    }

    private void Move()
    {
        transform.Translate(Vector3.up * Time.deltaTime * 10f);
    }

    private void DisableWhenOutMap()
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

    public void SetStrength(float num)
    {
        strength = num;
    }

    public float GetStrength()
    {
        return strength;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!collision.CompareTag("Enemy") && !collision.CompareTag("Boss") && !collision.CompareTag("HealthSafe")
            && !collision.CompareTag("BulletPlayer") && !collision.CompareTag("BulletOrange") && !collision.CompareTag("BulletGreen")
            && !collision.CompareTag("BulletWhite") && !collision.CompareTag("BulletPurple") && !collision.CompareTag("BulletGolden"))
        {
            gameObject.SetActive(false);
        }
    }
}
