using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_VAN_EX1_303 : SimTemplate //* 暗影烈焰 Shadowflame
	{
		//Destroy a friendly minion and deal its Attack damage to all enemy minions.
		//消灭一个友方随从，对所有敌方随从造成等同于其攻击力的伤害。
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
            int damage1 = (ownplay) ? p.getSpellDamageDamage(target.Angr) : p.getEnemySpellDamageDamage(target.Angr);

            p.minionGetDestroyed(target);

            p.allMinionOfASideGetDamage(!ownplay, damage1);

		}


        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_FRIENDLY_TARGET),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
            };
        }
	}
}