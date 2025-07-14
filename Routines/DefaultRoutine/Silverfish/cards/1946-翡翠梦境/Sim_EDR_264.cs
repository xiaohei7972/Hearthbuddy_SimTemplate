using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//法术 圣骑士 费用：1
	//Aegis of Light
	//圣光护盾
	//Summon a random1-Cost minion andgive it <b>Taunt</b>. <b>Imbue</b>your Hero Power.
	//随机召唤一个法力值消耗为（1）的随从并使其获得<b>嘲讽</b>。<b>灌注</b>你的英雄技能。
	class Sim_EDR_264 : SimTemplate
	{


		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			CardDB.Card kid = p.getRandomCardForManaMinion(1);
			int pos = ownplay ? p.ownMinions.Count : p.enemyMinions.Count;

			p.drawACard(CardDB.cardIDEnum.None, ownplay);
			// CardDB.Card kid = p.owncards[p.owncards.Count - 1].card;
			p.callKid(kid, pos, ownplay);
			Minion k = p.ownMinions[pos - 1];
			k.taunt = true;
			p.anzOwnTaunt++;

		}
		
	}
}
