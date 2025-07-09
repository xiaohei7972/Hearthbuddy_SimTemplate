using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 战士 费用：4
	//City Defenses
	//城防守卫
	//Summon two 0/6 Security with <b>Taunt</b>.They gain +1 Attackwhen damaged.
	//召唤两个0/6并具有<b>嘲讽</b>的守卫。守卫在受到伤害时会获得+1攻击力。
	class Sim_TLC_622 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_622t);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;
			p.callKid(kid, pos, ownplay);
			p.callKid(kid, pos, ownplay);
        }
		
	}
}
