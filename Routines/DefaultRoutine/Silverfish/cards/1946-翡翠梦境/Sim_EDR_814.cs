using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Infested Breath
	//感染吐息
	//Deal $2 damage. Summon a 0/2 Leech.
	//造成$2点伤害。召唤一条0/2的水蛭。
	class Sim_EDR_814 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_810t);

		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
        {
            int dmg = (ownplay) ? p.getSpellDamageDamage(2) : p.getEnemySpellDamageDamage(2);
            p.minionGetDamageOrHeal(target, dmg);
            int pos = (ownplay) ? p.ownMinions.Count : p.enemyMinions.Count;            
            p.callKid(kid, pos, ownplay, false);
		}

        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),  // 需要选择一个目标
                new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),    // 目标必须是敌方
				new PlayReq(CardDB.ErrorType2.REQ_NUM_MINION_SLOTS, 1), //确保有位置召唤
            };
        }
		
	}
}
