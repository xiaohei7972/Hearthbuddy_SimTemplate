using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 巫妖王 费用：6 攻击力：3 生命值：5
	//Hideous Husk
	//丑恶的残躯
	//[x]Your Leeches steal 2 moreHealth from their victims.<b>Battlecry:</b> Summon two0/2 Leeches.
	//你的水蛭从其宿主处偷取的生命值增加2点。<b>战吼：</b>召唤两只0/2的水蛭。
	class Sim_EDR_810 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EDR_810t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            p.callKid(kid, own.zonepos - 1, own.own);
			p.callKid(kid, own.zonepos, own.own);
		}
		
	}
}
