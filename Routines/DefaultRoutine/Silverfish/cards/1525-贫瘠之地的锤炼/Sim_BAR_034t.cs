using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BAR_034t : SimTemplate //* 驯服野兽（等级2） Tame Beast (Rank 2)
	{
		//Summon a 4/4 Beast with <b>Rush</b>. <i>(Upgrades when youhave 10 Mana.)</i>
		//召唤一只4/4并具有<b>突袭</b>的野兽。<i>（当你有10点法力值时升级。）</i>
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.BAR_034t4);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			int pos = p.ownMinions.Count;
			p.callKid(kid, pos + 1, ownplay);
		}			
		
	}
}
