using CosmicCuration.Utilities;

namespace CosmicCuration.Enemy
{
    public class EnemyPool : GenericObjectPool<EnemyController>
    {
        private EnemyView enemyView;
        private EnemyData enemyData;

        public EnemyPool(EnemyView enemyView, EnemyData enemyData)
        {
            this.enemyView = enemyView;
            this.enemyData = enemyData;
        }

        protected override EnemyController CreateItem() => new EnemyController(enemyView, enemyData);

        public EnemyController GetEnemy() => GetItem();
    }
}