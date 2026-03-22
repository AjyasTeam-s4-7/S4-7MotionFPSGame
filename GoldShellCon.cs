using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoldShellCon : MonoBehaviour
{
    Rigidbody rb;
    public ParticleSystem pung;
    private bool touch = false;
    private int cn;
    private int scn;
    private int ItemDamage = 0;
    private int DamageUP5 = 0;
    private int mujuk = 0;
    public void Shoot(Vector3 dir)
    {
        //Debug.Log(dir);
        rb.AddForce(dir, ForceMode.Impulse);
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (rb.position.z > 5)
        {
            gameObject.SetActive(false);
            Destroy(gameObject, 1);
        }
        if (rb.position.y < 0.2f)
        {
            gameObject.SetActive(false);
            Destroy(gameObject, 1);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        mujuk = Random.Range(0, 2);
        ItemDamage = 81 * mujuk;
        if (collision.collider.tag == "Target")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(1, 11);   // 1~10
                scn = Random.Range(0, 2);   // 0~1
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target1")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(11, 21);  // 11~20
                scn = Random.Range(2, 4);   // 2~3
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target2")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(21, 51);  // 21~50
                scn = Random.Range(4, 8);   // 4~7
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target3")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(51, 101); // 51~100
                scn = Random.Range(8, 14);   // 8~13
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target4")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(101, 201);   // 101~200
                scn = Random.Range(14, 25);   // 14~24
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target5")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(201, 501);    // 201~500
                scn = Random.Range(25, 56);   // 25~55
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target6")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(501, 1001);   // 501~1000
                scn = Random.Range(56, 107);   // 56~106
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
        if (collision.collider.tag == "Target7")
        {
            if (touch == false)
            {
                touch = true;
                rb.isKinematic = true;
                pung.Play();
                cn = Random.Range(1001, 2001);  // 1001~2000
                scn = Random.Range(107, 208);   // 107~207
                Debug.Log(ItemDamage);
                Debug.Log(DamageUP5);
                Debug.Log("ÀçÈ­ : " + cn);
                Debug.Log("¹Ì³×¶ö : " + scn);
                HpCon.Instance.EnermyHP_cur(ItemDamage + DamageUP5);
                CoinCon.Instance.Get_Coin(cn);
                CoinCon.Instance.Get_SpecialCoin(scn);
                Destroy(gameObject, 1);
            }
        }
    }
}
