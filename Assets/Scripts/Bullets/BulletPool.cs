using System.Collections.Generic;

namespace CosmicCuration.Bullets
{
    public class BulletPool
    {
        private BulletView bulletView;
        private BulletScriptableObject bulletScriptableObject;
        private List<PooledBullet> pooledBullets = new List<PooledBullet>();

        public BulletPool(BulletView bulletView, BulletScriptableObject bulletScriptableObject)
        {
            this.bulletView = bulletView;
            this.bulletScriptableObject = bulletScriptableObject;
        }

        public BulletController GetBullet()
        {
            if (pooledBullets.Count > 0)
            {
                PooledBullet item = pooledBullets.Find(item => !item.isUsed);

                if (item != null)
                {
                    item.isUsed = true;
                    return item.Bullet;
                }
            }

            return CreateNewPooledBullet();
        }

        private BulletController CreateNewPooledBullet()
        {
            PooledBullet newBullet = new PooledBullet();
            newBullet.Bullet = new BulletController(bulletView, bulletScriptableObject);
            newBullet.isUsed = true;
            pooledBullets.Add(newBullet);

            return newBullet.Bullet;
        }

        public void ReturnBullet(BulletController returnedBullet)
        {
            PooledBullet pooledBullet = pooledBullets.Find(item => item.Bullet.Equals(returnedBullet));
            pooledBullet.isUsed = false;
        }

        public class PooledBullet
        {
            public BulletController Bullet;
            public bool isUsed;
        }
    }
}