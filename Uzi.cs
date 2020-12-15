using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzi : Weapon
{
    public override void Shoot(Transform shootPoint)
    {
        CreateBullet(shootPoint.position);
        CreateBullet(new Vector3(shootPoint.position.x - 0.3f, shootPoint.position.y));
    }
    
    private void CreateBullet(Vector3 position)
    {
        Instantiate(Bullet, position, Quaternion.identity);
    }
}
