using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 巫妖王 费用：2
	//Plague Strike
	//凋零打击
	//Deal $3 damage toa minion. If that kills it,summon a 2/2 Zombiewith <b>Rush</b>.
	//对一个随从造成$3点伤害。如果消灭该随从，召唤一个2/2并具有<b>突袭</b>的僵尸。
	class Sim_RLK_Prologue_RLK_018 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.RLK_018t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			if (target != null)
			{
				int dmg = (ownplay) ? p.getSpellDamageDamage(3) : p.getEnemySpellDamageDamage(3);
				p.minionGetDamageOrHeal(target, dmg);
				if (target.Hp <= dmg)
				{
					int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
					p.callKid(kid, pos, ownplay);
				}
			}
		}
        public override PlayReq[] GetPlayReqs()
        {
            return new PlayReq[] {
                new PlayReq(CardDB.ErrorType2.REQ_TARGET_TO_PLAY),
                new PlayReq(CardDB.ErrorType2.REQ_MINION_TARGET),
                // new PlayReq(CardDB.ErrorType2.REQ_ENEMY_TARGET),
            };
        }
		
	}
}
