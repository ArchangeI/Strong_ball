using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 3;
    private Rigidbody enemyRb;
    private GameObject player; //��� ������������ �������
    private PlayerController playerCon; //��� ���� gameOver

    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
        playerCon = GameObject.Find("Player").GetComponent<PlayerController>();
    }

    void Update()
    {
        if (!playerCon.gameOver)
        {
            Vector3 lookDirection = (player.transform.position - transform.position).normalized; //normalized �� �� ����� ������� ����� �������� ��� ������ ������
            enemyRb.AddForce(lookDirection * speed);
        }
        if(transform.position.y < -10)
        {
            Destroy(gameObject);
        }
    }
}
