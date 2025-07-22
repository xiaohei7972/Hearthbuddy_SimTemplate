using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_DRG_232 : SimTemplate //* 光铸狂热者 Lightforged Zealot
	{
		//<b>Battlecry:</b> If your deck has no Neutral cards, equip a __4/2_Truesilver_Champion._
		//<b>战吼：</b>如果你的牌库中没有中立卡牌，便装备一把4/2的真银圣剑。
		CardDB.Card wcard = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.CS2_097);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.equipWeapon(wcard, own.own);

		}
	}
}
