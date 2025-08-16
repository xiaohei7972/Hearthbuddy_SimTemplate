using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 圣骑士 费用：5 攻击力：3 生命值：8
	//Sanc'Azel
	//圣沙泽尔
	//<b>Rush</b>After this attacks, turninto a location.
	//<b>突袭</b>在本随从攻击后，变成地标。
	class Sim_VAC_923 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.VAC_923t);
		public override void afterMinionAttack(Playfield p, Minion attacker, Minion defender, bool dontcount)
		{
			if (attacker.Hp > 0)
			{
				p.callKid(kid, attacker.zonepos, attacker.own);
				p.RemoveMinionWithoutDeathrattle(attacker);
			}
		}
	}
}
