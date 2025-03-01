using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject preFab;
    public Transform bulletTrash;
    public Transform bulletSpam;
    public GameObject preFab_2;
    private const float Timer = 0.5f;
    private float _currentTime = 0.5f;
    private bool _canShoot = true;

    private void Update()
    {
        if (!_canShoot)
        {
            _canShoot = true;
            _currentTime = Timer;
        }


        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            GameObject bullet = Instantiate(preFab, bulletSpam.position, Quaternion.identity);

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            GameObject bullet_2 = Instantiate(preFab_2, bulletSpam.position, Quaternion.identity);

            bullet_2.transform.SetParent(bulletTrash);

            _canShoot = false;
        }
    }

    private void TimerMethod()
    {
        TimerMethod();
        Shoot();
        if (!_canShoot)
        {
            _currentTime -= Time.deltaTime;
        }
        if (_currentTime < 0)
        {
            _canShoot = true;
            _currentTime = Timer;
        }
    }

    private void Shoot()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot)
        {
            GameObject bullet = Instantiate(preFab, bulletSpam.position, Quaternion.identity);
            bullet.transform.SetParent(bulletTrash);
            _canShoot = false;
            GameObject bullet_2 = Instantiate(preFab_2, bulletSpam.position, Quaternion.identity);
            bullet_2.transform.SetParent(bulletTrash);
            _canShoot = false;
        }
    }
}
    
