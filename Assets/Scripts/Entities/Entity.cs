using System.Collections;
using System.Collections.Generic;
using DungeonGame.Items;
using UnityEngine;

namespace DungeonGame.Enemies
{
    public class Entity : MonoBehaviour
    {
        [Min(0)] public int maxHealth;
        public Team team = Team.Enemies;
        
        protected int health;
        
        protected void Start()
        {
            health = maxHealth;
        }
        
        public bool Damage(int amount, DamageType damageType, Entity originEntity)
        {
            // return false if Entity is dead oder in the team of the damage source
            if(health <= 0 || originEntity.team == team) return false;
            
            // TODO: add more damage calculations here (damage type, resistance, ...)
            health -= amount;
            
            OnDamage(amount, damageType, originEntity);
            
            if(health <= 0) Destroy(gameObject);
            
            return true;
        }
        
        virtual protected void OnDamage(int amount, DamageType damageType, Entity originEntity)
        {
            
        }
    }
}
