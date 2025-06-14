using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：1
	//Morbid Swarm
	//病变虫群
	//<b>Choose One -</b> Summon two 1/1 Ants; or Spend 2 <b>Corpses</b> to deal $4_damage to a minion.
	//<b>抉择：</b>召唤两只1/1的蚂蚁；或者消耗2份<b>残骸</b>，对一个随从造成$4点伤害。
	class Sim_EDR_813 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_813at); 
		
        public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            if (choice == 2 || (p.ownFandralStaghelm > 0 && ownplay))
            {
                if (target != null)
                {
                    int damage = (ownplay) ? p.getSpellDamageDamage(4) : p.getEnemySpellDamageDamage(4);
                    p.minionGetDamageOrHeal(target, damage);
                }
            }
            if (choice == 1 || (p.ownFandralStaghelm > 0 && ownplay))
            {
				int place = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, place, ownplay, false);
				p.callKid(kid, place, ownplay);
            }
        }

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY), // 需求选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET)   // 目标必须是随从
            };
        }
		

		/*public override PlayReq[] GetPlayReqs()
        {
            if (choice == 2) // 只有在选择伤害时，才需要目标
            {
                return new PlayReq[] { 
					new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY)   // 需要选择一个目标
					new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),   // 目标必须是随从
                    new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方
				};
            }
			if (choice == 1) // 选择召唤时不需要目标
			{
            return new PlayReq[0]; 
			}
        }*/

	}
}
