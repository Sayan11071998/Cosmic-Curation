using CosmicCuration.Utilities;

namespace CosmicCuration.Bullets
{
    public class BulletPool : GenericObjectPool<BulletController>
    {
        private BulletView bulletView;
        private BulletScriptableObject bulletScriptableObject;

        public BulletPool(BulletView bulletView, BulletScriptableObject bulletScriptableObject)
        {
            this.bulletView = bulletView;
            this.bulletScriptableObject = bulletScriptableObject;
        }

        protected override BulletController CreateItem() => new BulletController(bulletView, bulletScriptableObject);

        public BulletController GetBullet() => GetItem();
    }
}