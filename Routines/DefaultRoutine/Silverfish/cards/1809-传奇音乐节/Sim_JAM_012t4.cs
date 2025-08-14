using System;
using System.Collections.Generic;
using System.Text;

namespace HREngine.Bots
{
	//随从 萨满祭司 费用：3 攻击力：3 生命值：2
	//Karaoke Totemcarver
	//唱K图腾师
	//[x]<b>Battlecry:</b> Summon a0/4 Jukebox Totem.<i>(Changes each turn.)</i>@[x]<b>Battlecry:</b> Summon a0/4 Jukebox Totem.
	//<b>战吼：</b>召唤一个0/4的点唱机图腾。<i>（每回合都会改变。）</i>@<b>战吼：</b>召唤一个0/4的点唱机图腾。
	class Sim_JAM_012t4 : SimTemplate
	{
		CardDB.Card kid = CardDB.Instance.getCardDataFromID(CardDB.cardIDEnum.JAM_010);

		public override void getBattlecryEffect(Playfield p, Minion own, Minion target, int choice)
		{
			p.callKid(kid, own.zonepos, own.own);
		}
		
	}
}
