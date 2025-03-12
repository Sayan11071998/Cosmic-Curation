using System.Collections.Generic;

namespace CosmicCuration.Enemy
{
    public class EnemyPool
    {
        private EnemyView enemyView;
        private EnemyData enemyData;
        private List<PooledEnemy> pooledEnemies = new List<PooledEnemy>();

        public EnemyPool(EnemyView enemyView, EnemyData enemyData)
        {
            this.enemyView = enemyView;
            this.enemyData = enemyData;
        }

        public EnemyController GetEnemy()
        {
            if (pooledEnemies.Count > 0)
            {
                PooledEnemy enemy = pooledEnemies.Find(item => !item.isUsed);

                if (enemy != null)
                {
                    enemy.isUsed = true;
                    return enemy.Enemy;
                }
            }

            return CreateNewPooledEnemy();
        }

        private EnemyController CreateNewPooledEnemy()
        {
            PooledEnemy newEnemy = new PooledEnemy();
            newEnemy.Enemy = new EnemyController(enemyView, enemyData);
            newEnemy.isUsed = true;
            pooledEnemies.Add(newEnemy);

            return newEnemy.Enemy;
        }

        public void ReturnEnemy(EnemyController returnedEnemy)
        {
            PooledEnemy pooledEnemy = pooledEnemies.Find(item => item.Enemy.Equals(returnedEnemy));
            pooledEnemy.isUsed = false;
        }

        public class PooledEnemy
        {
            public EnemyController Enemy;
            public bool isUsed;
        }
    }
}