using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class ShootScript : MonoBehaviour
{
    public static ShootScript instance;
    [SerializeField] GameObject bulletSpawnPos;
    [SerializeField] TMP_Text shootText;

    private int bulletAmount;
    private bool isCanShoot;
    private float delayShoot;

    private void Start()
    {
        isCanShoot = true;
        instance = this;
        bulletAmount = 0;
        UpdateShoot();
    }

    private void Update()
    {
        if (Keyboard.current.spaceKey.isPressed && isCanShoot)
        {
            if (bulletAmount > 0)
            {
                GameObject bullet = BulletPooling.instance.GetPooledObject();
                if (bullet != null)
                {
                    bullet.transform.position = bulletSpawnPos.transform.position;
                    bullet.transform.rotation = bulletSpawnPos.transform.rotation;
                    bullet.SetActive(true);
                    isCanShoot = false;
                }
                SubShoot();
            }
        }
        else if (isCanShoot == false)
        {
            delayShoot += Time.deltaTime;
        }

        if (delayShoot > 0.8f)
        {
            isCanShoot = true;
        }
    }

    public void AddShoot(int numberToAdd)
    {
        bulletAmount += numberToAdd;
        UpdateShoot();
    }

    private void SubShoot()
    {
        bulletAmount -= 1;
        UpdateShoot();
    }

    private void UpdateShoot()
    {
        shootText.text = bulletAmount.ToString();
    }
}
