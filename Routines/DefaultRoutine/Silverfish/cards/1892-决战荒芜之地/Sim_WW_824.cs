using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 德鲁伊 费用：8 攻击力：8 生命值：8
	//Rheastrasza
	//瑞亚丝塔萨
	//[x]<b>Battlecry:</b> If your deck startedwith no duplicates, summonthe Purified Dragon Nest.
	//<b>战吼：</b>如果你的套牌里没有相同的牌，则召唤纯净龙巢。
	class Sim_WW_824 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.WW_824t);
		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			if (p.prozis.noDuplicates)
			{
				int pos = own.own ? p.ownMinions.Count : p.enemyMinions.Count;
				p.callKid(kid, pos, own.own);
			}
		}
		
	}
}
