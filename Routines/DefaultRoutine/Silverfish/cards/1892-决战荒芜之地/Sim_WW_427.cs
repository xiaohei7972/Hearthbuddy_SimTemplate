using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 法师 费用：9
	//Sunset Volley
	//夕阳漫射
	//Deal $10 damage randomly split amongall enemies. Summon a random 10-Cost minion.
	//造成$10点伤害，随机分配到所有敌人身上。随机召唤一个法力值消耗为（10）的随从。
  
	class Sim_WW_427 : SimTemplate
    {
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int times = (ownplay) ? p.getSpellDamageDamage(10) : p.getEnemySpellDamageDamage(10);
            p.allCharsOfASideGetRandomDamage(!ownplay, times);
        
			
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
            p.callKid(p.getRandomCardForManaMinion(10), pos, ownplay);

        }    
    }

}
