using UnityEngine;

public class engelScripts : MonoBehaviour
{
    [SerializeField] float speed = 2f;     // engelin sola gidiş hızı
    [SerializeField] float destroyX = -10; // çok sola gidince yok olsun

    void Update()
    {
        // sola kaydır
        transform.position += Vector3.left * speed * Time.deltaTime;

        // ekranın solundan çıkınca destroy
        if (transform.position.x < destroyX)
        {
            Destroy(gameObject);
        }
    }

}
