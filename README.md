# unity3d_towerdefense

CannonTower/SimpleTower: 
- наследуем от Tower;
- вынесем логику поиска цели в компонент TowerTargeting;
- вынесем логику стрельбы в компонент TowerAttack;
- OPTIONAL: вынесем логику создания снаряда в ProjectileSpawner;
- эту строчку if (m_projectilePrefab == null) return; я уберу, чтобы выводилась ошибка при отсутствии префаба;

TowerTargeting:
- foreach (var monster in FindObjectsOfType<Monster>()) заменить на обход массива монстров в Spawner

CannonProjectile/GuidedProjectile: 
- наследуем от Projectile;
- вынесем логику урона монстру в MonsterHealth;

GuidedProjectile:
- сейчас ограничивается макс. скорость снаряда (if (translation.magnitude > m_speed))
Думаю, можно добавить ограничения минимальной скорости, чтобы монстр не мог убежать.

Monster: 
- вынесем в отдельные компоненты движение и здоровье (MonsterMove, MonsterHealth);

Spawner: 
- заменим создание монстра на префаб;
- будем хранить список всех живых монстров;
* если будет заранее известно число монстров, то можно на старте создавать их пул, чтобы не тратить время на Instantiate каждый раз (потребует больше памяти);








