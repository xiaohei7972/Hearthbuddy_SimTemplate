using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	class Sim_TRL_316 : SimTemplate //* 加亚莱，龙鹰之神 Jan'alai, the Dragonhawk
//[x]<b>Battlecry:</b> If your Hero Powerdealt 8 damage this game,summon Ragnaros theFirelord.@ <i>({0} left!)</i>@ <i>(Ready!)</i>
//<b>战吼：</b>在本局对战中，如果你的英雄技能累计造成了8点伤害，则召唤炎魔之王拉格纳罗斯。@<i>（还剩下{0}点！）</i>@<i>（已经就绪！）</i> 
	{
        CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.EX1_298);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
            if (target != null) p.callKid(kid, own.zonepos, own.own);
		}


	}
}