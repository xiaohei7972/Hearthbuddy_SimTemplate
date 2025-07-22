using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：5 攻击力：3 生命值：4
	//Slagclaw
	//熔爪巨龙
	//[x]<b>Battlecry:</b> Summon two2/1 Sizzling Cinders.<b>Kindred:</b> Trigger your SizzlingCinders' <b>Deathrattles.</b>
	//<b>战吼：</b>召唤两个2/1的炽烈烬火。<b>延系：</b>触发你的炽烈烬火的<b>亡语</b>。
	class Sim_TLC_482 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.TLC_249);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos - 1, own.own, false);
			p.callKid(kid, own.zonepos, own.own);
		}
		
	}
}
