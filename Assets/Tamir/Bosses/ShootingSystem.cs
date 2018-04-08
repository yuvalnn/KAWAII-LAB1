
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class ShootingSystem : MonoBehaviour
{
    public GameObject projectile;
    //public GameObject gun;

    
    public float timer = 0;
    public int timeMax = 3;
    public int MaxShoot;
    int countShoot = 0;
   




    private void Start()
    {
        
    }

    private void Update()
    {
        CheckIfShoot();
    }

    private void CheckIfShoot()
    {
        if(timer >= timeMax && countShoot < MaxShoot)
        {
            Shoot();
            timer = 0;
            countShoot++;
            
        }

        timer += Time.deltaTime;
    }

    private void Shoot()
    {
        Instantiate(projectile, transform.position, transform.rotation);

        
          
        


    }


   

    /*    public float fireRate;
        public int damage;
        public float fieldOfView;
        public bool beam;
        public List<GameObject> projectileSpawns;

        List<GameObject> m_lastProjectiles = new List<GameObject>();
        float m_fireTimer = 0.0f;
        public GameObject m_target;

        // Update is called once per frame
        void Update()
        {
            if (!m_target)
            {
                if (beam)
                    RemoveLastProjectiles();

                return;
            }

            if (beam && m_lastProjectiles.Count <= 0)
            {
                float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));

                if (angle < fieldOfView)
                {
                    SpawnProjectiles();
                }
            }
            else if (beam && m_lastProjectiles.Count > 0)
            {
                float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));

                if (angle > fieldOfView)
                {
                    RemoveLastProjectiles();
                }
            }
            else
            {
                m_fireTimer += Time.deltaTime;

                if (m_fireTimer >= fireRate)
                {
                    float angle = Quaternion.Angle(transform.rotation, Quaternion.LookRotation(m_target.transform.position - transform.position));

                    if (angle < fieldOfView)
                    {
                        SpawnProjectiles();

                        m_fireTimer = 0.0f;
                    }
                }
            }
        }

        void SpawnProjectiles()
        {
            if (!projectile)
            {
                return;
            }

            m_lastProjectiles.Clear();

            for (int i = 0; i < projectileSpawns.Count; i++)
            {
                if (projectileSpawns[i])
                {
                    GameObject proj = Instantiate(projectile, projectileSpawns[i].transform.position, Quaternion.Euler(projectileSpawns[i].transform.forward)) as GameObject;
                    proj.GetComponent<BaseProjectile>().FireProjectile(projectileSpawns[i], m_target, damage, fireRate);

                    m_lastProjectiles.Add(proj);
                }
            }
        }

        public void SetTarget(GameObject target)
        {
            m_target = target;
        }

        void RemoveLastProjectiles()
        {
            while (m_lastProjectiles.Count > 0)
            {
                Destroy(m_lastProjectiles[0]);
                m_lastProjectiles.RemoveAt(0);
            }
        }
        */
}
