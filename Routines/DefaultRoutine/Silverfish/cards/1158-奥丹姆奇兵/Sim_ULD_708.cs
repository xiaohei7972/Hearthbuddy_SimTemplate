using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_ULD_708 : SimTemplate //* 电缆长枪 Livewire Lance
	{
		//After your Hero attacks, add a <b>Lackey</b> to your hand.
		//在你的英雄攻击后，将一张<b>跟班</b>牌置入你的手牌。
		CardDB.Card card = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.ULD_708);
		public override void onCardPlay(Playfield p, bool ownplay, Minion target, int choice)
		{
			p.equipWeapon(card, ownplay);
		}
	}
}