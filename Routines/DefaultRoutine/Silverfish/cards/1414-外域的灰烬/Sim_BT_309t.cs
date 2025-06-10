using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_BT_309t : SimTemplate //* 终极坎雷萨德 Kanrethad Prime
	{
		//<b>Battlecry:</b> Summon 3 friendly Demons that died_this game.
		//<b>战吼：</b>召唤三个在本局对战中死亡的友方恶魔。
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.UNG_937);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos - 1, own.own);
			p.callKid(kid, own.zonepos, own.own);
			p.callKid(kid, own.zonepos + 1, own.own);
		}

	}
}
