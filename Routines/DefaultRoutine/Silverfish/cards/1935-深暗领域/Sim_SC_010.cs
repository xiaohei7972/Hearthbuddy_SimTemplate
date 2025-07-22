using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 无效的 费用：1 攻击力：1 生命值：1
	//Zergling
	//跳虫
	//<b>Battlecry:</b> Summon a1/1 Zergling.
	//<b>战吼：</b>召唤一个1/1的跳虫。
	class Sim_SC_010 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.SC_010);
        public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
        {
			p.callKid(kid, own.zonepos, own.own);
        }
		
	}
}
