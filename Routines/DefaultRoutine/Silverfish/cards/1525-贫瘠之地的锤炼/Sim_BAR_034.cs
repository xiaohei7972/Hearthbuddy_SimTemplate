using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_034 : SimTemplate //* 驯服野兽（等级1） Tame Beast (Rank 1)
	{
		//Summon a 2/2 Beast with <b>Rush</b>. <i>(Upgrades when youhave 5 Mana.)</i>
		//召唤一只2/2并具有<b>突袭</b>的野兽。<i>（当你有5点法力值时升级。）</i>
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_034t3);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = p.ownMinions.Count;
			p.callKid(kid, pos + 1, ownplay);
		}		
	}
}
