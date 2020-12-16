using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    private float _offset = -0.3f;
    public override void Shoot(Transform shootPoint)
    {        
        CreateBullet(shootPoint.position);
        CreateBullet(new Vector3(shootPoint.position.x - _offset, shootPoint.position.y));
    }
    
    private void CreateBullet(Vector3 position)
    {
        Instantiate(Bullet, position, Quaternion.identity);
    }
}
