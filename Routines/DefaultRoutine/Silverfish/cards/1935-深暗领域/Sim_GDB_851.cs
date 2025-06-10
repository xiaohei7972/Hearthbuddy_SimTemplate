using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_GDB_851 : SimTemplate //* 星域相变射线 Astral Phaser

//<b>Choose One -</b>Deal 2 damage to two random enemy minions; or Make one Dormant for 2 turns.
//<b>抉择：</b>随机对两个敌方随从造成2点伤害；或者使一个敌方随从休眠2回合。
	{
		
		
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                int damage = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
                List<Minion> temp2 = new List<Minion>(p.enemyMinions);
                temp2.Sort((a, b) => a.Hp.CompareTo(b.Hp));
                int i = 0;
                foreach (Minion enemy in temp2)
                {
                    p.minionGetDamageOrHeal(enemy, damage);
                    i++;
                    if (i == 2) break;
                }
            }
            
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (target != null)
                {
                    target.dormant = 2; // 使目标随从休眠2回合
                }
            }
		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需要一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET), // 需要一个随从目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET), // 需要一个敌方目标
            };
        }
	}
}